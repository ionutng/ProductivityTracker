using Microsoft.EntityFrameworkCore;
using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class AddWorkoutForm : Form
    {
        private readonly ProductivityContext _context;
        private List<Exercise> exercisesList = [];
        private List<Run> runsList = [];
        private Workout _workout;

        public AddWorkoutForm(Workout workout)
        {
            InitializeComponent();
            _context = new ProductivityContext();
            _workout = workout;

            dateDtp.Format = DateTimePickerFormat.Custom;
            dateDtp.CustomFormat = "dddd, MMM dd, yyyy";
            startTimeDtp.Format = DateTimePickerFormat.Custom;
            startTimeDtp.CustomFormat = "HH:mm";
            startTimeDtp.ShowUpDown = true;
            endTimeDtp.Format = DateTimePickerFormat.Custom;
            endTimeDtp.CustomFormat = "HH:mm";
            endTimeDtp.ShowUpDown = true;
            timeDtp.Format = DateTimePickerFormat.Time;
            timeDtp.ShowUpDown = true;
            paceDtp.Format = DateTimePickerFormat.Custom;
            paceDtp.CustomFormat = "HH:mm";
            paceDtp.ShowUpDown = true;

            if (_workout.Id != 0)
            {
                var exercises = _context.Exercise.Where(e => e.WorkoutId == _workout.Id).ToList();
                var runs = _context.Run.Where(r => r.WorkoutId == _workout.Id).ToList();

                foreach (var exercise in exercises)
                {
                    exerciseLb.Items.Add(
                        $"{exercise.Name} : {exercise.Sets}x{exercise.Reps}");
                }

                foreach (var run in runs)
                {
                    runLb.Items.Add(
                        $"{run.Distance}km | " +
                        $"{run.Time.Hours}h{run.Time.Minutes}m{run.Time.Seconds}s | " +
                        $"{run.Pace.Hours}'{run.Pace.Minutes}\"");
                }

                dateDtp.Value = new DateTime(_workout.Date, _workout.StartTime);
                startTimeDtp.Value = new DateTime(_workout.Date, _workout.StartTime);
                endTimeDtp.Value = new DateTime(_workout.Date, _workout.EndTime);
                titleLabel.Text = "Edit a Workout";
                addWorkoutBtn.Text = "Edit Workout";
                Text = "EditWorkoutForm";
                deleteWorkoutBtn.Visible = true;
                editExerciseBtn.Visible = true;
                deleteExerciseBtn.Visible = true;
                editRunBtn.Visible = true;
                deleteRunBtn.Visible = true;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            CrudOperationsForm crudOperationsForm = new("Workout");
            Hide();
            crudOperationsForm.Show();
        }

        private void addExerciseBtn_Click(object sender, EventArgs e)
        {
            var name = nameTb.Text.Trim();
            var sets = int.Parse(setsNud.Value.ToString());
            var reps = int.Parse(repsNud.Value.ToString());

            if (!Validation.ExerciseValidation(name, sets, reps)) return;

            var exercise = new Exercise
            {
                Name = name,
                Sets = sets,
                Reps = reps
            };

            exerciseLb.Items.Add($"{exercise.Name} : {exercise.Sets}x{exercise.Reps}");
            exercisesList.Add(exercise);

            nameTb.Clear();
            setsNud.Value = 0;
            repsNud.Value = 0;
        }

        private void addRunBtn_Click(object sender, EventArgs e)
        {
            var distance = distanceTb.Text.Trim();
            var time = TimeSpan.Parse(timeDtp.Value.ToString("HH:mm:ss"));
            var pace = TimeSpan.Parse(paceDtp.Value.ToString("HH:mm"));

            if(!Validation.RunValidation(distance, time, pace)) return;

            var run = new Run
            {
                Distance = float.Parse(distance),
                Time = time,
                Pace = pace
            };

            runLb.Items.Add($"{run.Distance}km | " +
                $"{run.Time.Hours}h{run.Time.Minutes}m{run.Time.Seconds}s | " +
                $"{run.Pace.Hours}'{run.Pace.Minutes}\"");
            runsList.Add(run);

            distanceTb.Text = "";
            timeDtp.Value = new DateTime(new DateOnly(2024, 1, 1), new TimeOnly(0, 10, 0));
            paceDtp.Value = new DateTime(new DateOnly(2024, 1, 1), new TimeOnly(0, 4, 36));
        }

        private void addWorkoutBtn_Click(object sender, EventArgs e)
        {
            var date = DateOnly.Parse(dateDtp.Value.ToString("dd-MMM-yyyy"));
            var startTime = TimeOnly.Parse(startTimeDtp.Value.ToString("HH:mm"));
            var endTime = TimeOnly.Parse(endTimeDtp.Value.ToString("HH:mm"));

            if (!Validation.DateValidation(date, startTime, endTime)) return;

            if (addWorkoutBtn.Text == "Add Workout")
            {
                var workout = new Workout
                {
                    Date = date,
                    StartTime = startTime,
                    EndTime = endTime,
                    Duration = endTime - startTime,
                    Exercise = exercisesList,
                    Run = runsList
                };

                _context.Workout.Add(workout);
                _context.SaveChanges();
            }
            else
            {
                _workout.Date = date;
                _workout.StartTime = startTime;
                _workout.EndTime = endTime;
                _workout.Duration = endTime - startTime;
                _workout.Exercise = exercisesList;
                _workout.Run = runsList;

                _context.Workout.Update(_workout);
                _context.SaveChanges();
            }

            CrudOperationsForm crudOperationsForm = new("Workout");
            Hide();
            crudOperationsForm.Show();

            crudOperationsForm.FormClosed += (s, args) => Close();
        }

        private void exerciseLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_workout.Id != 0)
            {
                if (exerciseLb.SelectedItem != null)
                {
                    var exercise = GetSelectedExerciseFromListBox();
                    nameTb.Text = exercise!.Name;
                    setsNud.Value = exercise.Sets;
                    repsNud.Value = exercise.Reps;
                }
                else
                {
                    MessageBox.Show("Please select an exercise in order to edit or delete!", Name = "Warning");
                }
            }
        }

        private void editExerciseBtn_Click(object sender, EventArgs e)
        {
            var exercise = GetSelectedExerciseFromListBox();

            exercise!.Name = nameTb.Text.Trim();
            exercise.Sets = int.Parse(setsNud.Value.ToString());
            exercise.Reps = int.Parse(repsNud.Value.ToString());

            _context.Exercise.Update(exercise);
            _context.SaveChanges();

            ClearExerciseDetails();
            RefreshExerciseLists();
        }

        private void deleteExerciseBtn_Click_1(object sender, EventArgs e)
        {
            var exercise = GetSelectedExerciseFromListBox();

            _context.Exercise.Remove(exercise!);
            _context.SaveChanges();

            ClearExerciseDetails();
            RefreshExerciseLists();
        }

        private void runLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_workout.Id != 0)
            {
                if (runLb.SelectedItem != null)
                {
                    var run = GetSelectedRunFromListBox();

                    distanceTb.Text = run!.Distance.ToString();
                    timeDtp.Value = new DateTime(new DateOnly(2024, 1, 1), TimeOnly.FromTimeSpan(run.Time));
                    paceDtp.Value = new DateTime(new DateOnly(2024, 1, 1), TimeOnly.FromTimeSpan(run.Pace));
                }
                else
                {
                    MessageBox.Show("Please select an exercise in order to edit or delete!", Name = "Warning");
                }
            }
        }

        private void editRunBtn_Click(object sender, EventArgs e)
        {
            if (runLb.SelectedItem != null)
            {
                var run = GetSelectedRunFromListBox();

                run!.Distance = float.Parse(distanceTb.Text.Trim());
                run.Time = TimeSpan.Parse(timeDtp.Value.ToString("HH:mm:ss"));
                run.Pace = TimeSpan.Parse(paceDtp.Value.ToString("HH:mm"));

                _context.Run.Update(run);
                _context.SaveChanges();

                ClearRunDetails();
                RefreshRunLists();
            }
            else
            {
                MessageBox.Show("Please select an exercise in order to edit or delete!", Name = "Warning");
            }
        }

        private void deleteRunBtn_Click(object sender, EventArgs e)
        {
            var run = GetSelectedRunFromListBox();

            _context.Run.Remove(run!);
            _context.SaveChanges();

            ClearRunDetails();
            RefreshRunLists();
        }

        private void deleteWorkoutBtn_Click(object sender, EventArgs e)
        {
            _context.Workout.Remove(_workout);
            _context.SaveChanges();

            CrudOperationsForm crudOperationsForm = new("Workout");
            Hide();
            crudOperationsForm.Show();

            crudOperationsForm.FormClosed += (s, args) => Close();
        }

        private Exercise GetSelectedExerciseFromListBox()
        {
            var exerciseNameIndex = exerciseLb.SelectedItem!.ToString()!.IndexOf(':');
            var exerciseName = exerciseLb.SelectedItem.ToString()!.Substring(0, exerciseNameIndex - 1);
            var exercise = _context.Exercise.FirstOrDefault(e => e.Name == exerciseName);

            return exercise!;
        }

        private void ClearExerciseDetails()
        {
            nameTb.Clear();
            setsNud.Value = 0;
            repsNud.Value = 0;
        }

        private void RefreshExerciseLists()
        {
            exerciseLb.Items.Clear();
            exercisesList.RemoveRange(0, exercisesList.Count);
            var exercises = _context.Exercise.Where(e => e.WorkoutId == _workout.Id).ToList();
            foreach (var ex in exercises)
            {
                exerciseLb.Items.Add($"{ex.Name} : {ex.Sets}x{ex.Reps}");
                exercisesList.Add(ex);
            }
        }

        private Run GetSelectedRunFromListBox()
        {
            var runDistanceIndex = runLb.SelectedItem!.ToString()!.IndexOf('k');
            var runDistance = float.Parse(runLb.SelectedItem.ToString()!.Substring(0, runDistanceIndex));
            var runPaceIndex = runLb.SelectedItem!.ToString()!.IndexOf('\'');
            var runPace = runLb.SelectedItem.ToString()!.Substring(runPaceIndex - 1);
            var timeParts = runPace.Split('\'');
            var runPaceTs = new TimeSpan(int.Parse(timeParts[0]), int.Parse(timeParts[1].Split('"')[0]), 0);
            var run = _context.Run.FirstOrDefault(r => r.Distance == runDistance && r.Pace == runPaceTs);

            return run!;
        }

        private void ClearRunDetails()
        {
            distanceTb.Clear();
            timeDtp.Value = new DateTime(new DateOnly(2024, 1, 1), new TimeOnly(0, 10, 0));
            paceDtp.Value = new DateTime(new DateOnly(2024, 1, 1), new TimeOnly(4, 46));
        }

        private void RefreshRunLists()
        {
            var run = GetSelectedRunFromListBox();
            runLb.Items.Clear();
            runsList.RemoveRange(0, runsList.Count);
            var runs = _context.Run.Where(r => r.Distance == run!.Distance && r.Pace == run.Pace).ToList();
            foreach (var r in runs)
            {
                runLb.Items.Add(
                    $"{r.Distance}km | " +
                    $"{r.Time.Hours}h{r.Time.Minutes}m{r.Time.Seconds}s | " +
                    $"{r.Pace.Hours}'{r.Pace.Minutes}\"");
                runsList.Add(r);
            }
        }
    }
}
