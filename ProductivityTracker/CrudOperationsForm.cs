using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class CrudOperationsForm : Form
    {
        public CrudOperationsForm(string task)
        {
            InitializeComponent();
            taskLabel.Text = $"{task} Operations";
            taskLabel.Location = new Point(250, 20);
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
            AddStudySessionForm addStudySessionForm = new(new StudySession());
            Hide();
            addStudySessionForm.Show();

            addStudySessionForm.FormClosed += (s, args) => Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            ShowStudySessionsForm showStudySessionsForm = new();
            Hide();
            showStudySessionsForm.Show();

            showStudySessionsForm.FormClosed += (s, args) => Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ShowStudySessionsForm showStudySessionsForm = new();
            Hide();
            showStudySessionsForm.Show();

            showStudySessionsForm.FormClosed += (s, args) => Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ShowStudySessionsForm showStudySessionsForm = new();
            Hide();
            showStudySessionsForm.Show();

            showStudySessionsForm.FormClosed += (s, args) => Close();
        }
    }
}
