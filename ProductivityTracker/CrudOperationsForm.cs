using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class CrudOperationsForm : Form
    {
        private string _task;
        public CrudOperationsForm(string task)
        {
            InitializeComponent();
            taskLabel.Text = $"{task} Operations";
            taskLabel.Location = new Point(270, 20);
            _task = task;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new();
            Hide();
            firstForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (_task == "Study Session")
            {
                AddStudySessionForm addStudySessionForm = new(new StudySession());
                Hide();
                addStudySessionForm.Show();

                addStudySessionForm.FormClosed += (s, args) => Close();
            }
            else if (_task == "Workout")
            {
                var exercise = new Exercise { Name = "" };
                List<Exercise> exerciseList = [];
                exerciseList.Add(exercise);
                var workout = new Workout { Exercise = exerciseList };

                AddWorkoutForm addWorkoutForm = new(workout);
                Hide();
                addWorkoutForm.Show();

                addWorkoutForm.FormClosed += (s, args) => Close();
            }
            else
            {
                var readingSession = new ReadingSession { Title = "" };
                AddReadingSessionForm addReadingSessionForm = new(readingSession);
                Hide();
                addReadingSessionForm.Show();

                addReadingSessionForm.FormClosed += (s, args) => Close();
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (_task == "Study Session")
            {
                ShowStudySessionsForm showStudySessionsForm = new();
                Hide();
                showStudySessionsForm.Show();

                showStudySessionsForm.FormClosed += (s, args) => Close();
            }
            else if (_task == "Workout")
            {
                ShowWorkoutsForm showWorkoutsForm = new();
                Hide();
                showWorkoutsForm.Show();

                showWorkoutsForm.FormClosed += (s, args) => Close();
            }
            else
            {
                ShowReadingSessionsForm showReadingSessionsForm = new();
                Hide();
                showReadingSessionsForm.Show();

                showReadingSessionsForm.FormClosed += (s, args) => Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (_task == "Study Session")
            {
                ShowStudySessionsForm showStudySessionsForm = new();
                Hide();
                showStudySessionsForm.Show();

                showStudySessionsForm.FormClosed += (s, args) => Close();
            }
            else if (_task == "Workout")
            {
                ShowWorkoutsForm showWorkoutsForm = new();
                Hide();
                showWorkoutsForm.Show();

                showWorkoutsForm.FormClosed += (s, args) => Close();
            }
            else
            {
                ShowReadingSessionsForm showReadingSessionsForm = new();
                Hide();
                showReadingSessionsForm.Show();

                showReadingSessionsForm.FormClosed += (s, args) => Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_task == "Study Session")
            {
                ShowStudySessionsForm showStudySessionsForm = new();
                Hide();
                showStudySessionsForm.Show();

                showStudySessionsForm.FormClosed += (s, args) => Close();
            }
            else if (_task == "Workout")
            {
                ShowWorkoutsForm showWorkoutsForm = new();
                Hide();
                showWorkoutsForm.Show();

                showWorkoutsForm.FormClosed += (s, args) => Close();
            }
            else
            {
                ShowReadingSessionsForm showReadingSessionsForm = new();
                Hide();
                showReadingSessionsForm.Show();

                showReadingSessionsForm.FormClosed += (s, args) => Close();
            }
        }
    }
}
