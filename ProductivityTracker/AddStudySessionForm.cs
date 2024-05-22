using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class AddStudySessionForm : Form
    {
        private readonly ProductivityContext _context;
        private StudySession _studySession;

        public AddStudySessionForm(StudySession studySession)
        {
            InitializeComponent();
            _context = new ProductivityContext();
            _studySession = studySession;

            // Set the custom format string and display the control as an up-down control.
            dateDtp.Format = DateTimePickerFormat.Custom;
            dateDtp.CustomFormat = "dddd, MMM dd, yyyy";
            startTimeDtp.Format = DateTimePickerFormat.Custom;
            startTimeDtp.CustomFormat = "HH:mm";
            startTimeDtp.ShowUpDown = true;
            endTimeDtp.Format = DateTimePickerFormat.Custom;
            endTimeDtp.CustomFormat = "HH:mm";
            endTimeDtp.ShowUpDown = true;

            // If there is a studySession
            if (_studySession.Id != 0)
            {
                var startTime = new TimeOnly(_studySession.StartTime.Hour, _studySession.StartTime.Minute);
                var endTime = new TimeOnly(_studySession.EndTime.Hour, _studySession.EndTime.Minute);
                var date = new DateTime(_studySession.Date, startTime);
                dateDtp.Value = date;
                startTimeDtp.Value = date;
                date = new DateTime(_studySession.Date, endTime);
                endTimeDtp.Value = date;
                addStudySessionBtn.Text = "Edit Study Session";
                Text = "EditStudySessionForm";
                deleteStudySessionBtn.Visible = true;
            }
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

        private void addStudySessionBtn_Click(object sender, EventArgs e)
        {
            var date = DateOnly.Parse(dateDtp.Value.ToString("dd-MMM-yyyy"));
            var startTime = TimeOnly.Parse(startTimeDtp.Value.ToString("HH:mm"));
            var endTime = TimeOnly.Parse(endTimeDtp.Value.ToString("HH:mm"));

            if (addStudySessionBtn.Text == "Add Study Session")
            {
                var study = new StudySession
                {
                    Date = date,
                    StartTime = startTime,
                    EndTime = endTime,
                    Duration = endTime - startTime
                };

                _context.StudySession.Add(study);
                _context.SaveChanges();
            }
            else
            {
                _studySession.Date = date;
                _studySession.StartTime = startTime;
                _studySession.EndTime = endTime;
                _studySession.Duration = endTime - startTime;

                _context.StudySession.Update(_studySession);
                _context.SaveChanges();

            }
            CrudOperationsForm crudOperationsForm = new("Study Session");
            Hide();
            crudOperationsForm.Show();

            crudOperationsForm.FormClosed += (s, args) => Close();
        }

        private void deleteStudySessionBtn_Click(object sender, EventArgs e)
        {
            _context.StudySession.Remove(_studySession);
            _context.SaveChanges();

            CrudOperationsForm crudOperationsForm = new("Study Session");
            Hide();
            crudOperationsForm.Show();

            crudOperationsForm.FormClosed += (s, args) => Close();
        }
    }
}
