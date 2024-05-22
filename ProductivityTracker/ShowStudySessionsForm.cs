using Microsoft.IdentityModel.Tokens;
using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class ShowStudySessionsForm : Form
    {
        private readonly ProductivityContext _context;
        public ShowStudySessionsForm()
        {
            InitializeComponent();
            _context = new ProductivityContext();
            LoadStudySessions();
            studySessionsLb.SelectionMode = SelectionMode.One;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            CrudOperationsForm crudOperationsForm = new("Study Session");
            Hide();
            crudOperationsForm.Show();
        }

        private void LoadStudySessions()
        {
            int counter = 0;
            var studySessions = _context.StudySession.ToList();
            foreach (var studySession in studySessions)
            {
                studySessionsLb.Items.Add(
                    $"#{++counter}: " +
                    $"{studySession.Date} | " +
                    $"{studySession.StartTime} - " +
                    $"{studySession.EndTime} | " +
                    $"{studySession.Duration.Hours}h:{studySession.Duration.Minutes}m | " +
                    $"Id = {studySession.Id}");
            }
        }

        private void studySessionsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studySessionsLb.SelectedItem != null)
            {
                var indexId = studySessionsLb.SelectedItem!.ToString()!.IndexOf('=');
                var studySessionId = studySessionsLb.SelectedItem!.ToString()!.Substring(indexId + 2);
                var studySession = _context.StudySession.Find(int.Parse(studySessionId));

                AddStudySessionForm addStudySessionForm = new(studySession!);
                Hide();
                addStudySessionForm.Show();

                addStudySessionForm.FormClosed += (s, args) => Close();
            }
            else
            {
                MessageBox.Show("Please select a study session in order to edit or delete!", Name = "Warning");
            }
        }
    }
}
