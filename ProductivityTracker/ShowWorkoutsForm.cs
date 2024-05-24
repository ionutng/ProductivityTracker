using ProductivityTracker.Models;
using System.Diagnostics.Metrics;

namespace ProductivityTracker
{
    public partial class ShowWorkoutsForm : Form
    {
        private readonly ProductivityContext _context;
        public ShowWorkoutsForm()
        {
            InitializeComponent();
            _context = new ProductivityContext();
            LoadWorkouts();
            workoutsLb.SelectionMode = SelectionMode.One;
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

        private void LoadWorkouts()
        {
            int counter = 0;
            var workouts = _context.Workout.ToList();

            foreach (var workout in workouts)
            {
                workoutsLb.Items.Add(
                    $"#{++counter}: " +
                    $"{workout.Date} | " +
                    $"{workout.StartTime} - " +
                    $"{workout.EndTime} | " +
                    $"Id = {workout.Id}");
            }
        }

        private void workoutsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workoutsLb.SelectedItem != null)
            {
                var workout = GetSelectedWorkoutFromListBox();
                var exercises = _context.Exercise.Where(e => e.WorkoutId == workout.Id).ToList();
                var runs = _context.Run.Where(r => r.WorkoutId == workout.Id).ToList();

                fullWorkoutLb.Items.Clear();

                fullWorkoutLb.Items.Add(
                    $"{workout!.Date} | " +
                    $"{workout.StartTime} - " +
                    $"{workout.EndTime} | " +
                    $"{workout.Duration.Hours}h:{workout.Duration.Minutes}m");

                fullWorkoutLb.Items.Add("");
                foreach (var exercise in exercises)
                {
                    fullWorkoutLb.Items.Add(
                        $"{exercise.Name} - {exercise.Sets}x{exercise.Reps}");
                }

                fullWorkoutLb.Items.Add("");
                foreach (var run in runs)
                {
                    fullWorkoutLb.Items.Add(
                        $"{run.Distance}km | " +
                        $"{run.Time.Hours}h{run.Time.Minutes}m{run.Time.Seconds}s | " +
                        $"{run.Pace.Hours}'{run.Pace.Minutes}\"");
                }
            }
            else
            {
                MessageBox.Show("Please select a workout in order to edit or delete!", Name = "Warning");
            }
        }

        private void editWorkoutBtn_Click(object sender, EventArgs e)
        {
            if (workoutsLb.SelectedItem != null)
            {
                var workout = GetSelectedWorkoutFromListBox();

                AddWorkoutForm addWorkoutForm = new(workout!);
                Hide();
                addWorkoutForm.Show();

                addWorkoutForm.FormClosed += (s, args) => Close();
            }
            else
            {
                MessageBox.Show("Please select a workout in order to edit or delete!", Name = "Warning");
            }
        }

        private void deleteWorkoutBtn_Click(object sender, EventArgs e)
        {
            if (workoutsLb.SelectedItem != null)
            {
                var workout = GetSelectedWorkoutFromListBox();

                AddWorkoutForm addWorkoutForm = new(workout!);
                Hide();
                addWorkoutForm.Show();

                addWorkoutForm.FormClosed += (s, args) => Close();
            }
            else
            {
                MessageBox.Show("Please select a workout in order to edit or delete!", Name = "Warning");
            }
        }

        private Workout GetSelectedWorkoutFromListBox()
        {
            var indexId = workoutsLb.SelectedItem!.ToString()!.IndexOf('=');
            var workoutId = int.Parse(workoutsLb.SelectedItem!.ToString()!.Substring(indexId + 2));
            var workout = _context.Workout.FirstOrDefault(e => e.Id == workoutId);

            return workout!;
        }
    }
}
