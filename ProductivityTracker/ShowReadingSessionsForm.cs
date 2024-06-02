using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class ShowReadingSessionsForm : Form
    {
        private readonly ProductivityContext _context;

        public ShowReadingSessionsForm()
        {
            InitializeComponent();
            _context = new ProductivityContext();
            LoadReadingSessions("All");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            CrudOperationsForm crudOperationsForm = new("Reading");
            Hide();
            crudOperationsForm.Show();
        }

        private void LoadReadingSessions(string status)
        {
            readingSessionsLb.Items.Clear();

            var readingSessions = _context.ReadingSession.ToList();
            int counter = 0;
            if (status == "All")
            {
                readingSessions = _context.ReadingSession.ToList();
            }
            else if (status == "Reading")
            {
                readingSessions = _context.ReadingSession
                    .Where(r => r.PagesRead < r.TotalPages && r.PagesRead != 0).ToList();
            }
            else if (status == "Completed")
            {
                readingSessions = _context.ReadingSession
                    .Where(r => r.PagesRead == r.TotalPages).ToList();
            }
            else if (status == "Plan to Read")
            {
                readingSessions = _context.ReadingSession
                    .Where(r => r.PagesRead == 0).ToList();
            }

            foreach (var readingSession in readingSessions)
            {
                if (readingSession.Authors != "")
                {
                    readingSessionsLb.Items.Add(
                        $"#{++counter}: " +
                        $"{readingSession.Title} | " +
                        $"by {readingSession.Authors} | " +
                        $"{readingSession.TotalPages} Pages | " +
                        $"{readingSession.PagesRead} Pages Read | " +
                        $"Id = {readingSession.Id}");
                }
                else
                {
                    readingSessionsLb.Items.Add(
                        $"#{++counter}: " +
                        $"{readingSession.Title} | " +
                        $"{readingSession.TotalPages} Pages | " +
                        $"{readingSession.PagesRead} Pages Read | " +
                        $"Id = {readingSession.Id}");
                }

                if (readingSession.PagesRead != 0)
                {
                    readingSessionsLb.Items.Add(
                        $"{readingSession.Date} | " +
                        $"{readingSession.StartTime} - " +
                        $"{readingSession.EndTime} | " +
                        $"{readingSession.Duration.Hours}h{readingSession.Duration.Minutes}m");
                }
                readingSessionsLb.Items.Add("");
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton == readingRb)
            {
                LoadReadingSessions("Reading");
            }
            else if (radioButton == completedRb)
            {
                LoadReadingSessions("Completed");
            }
            else if (radioButton == planToReadRb)
            {
                LoadReadingSessions("Plan to Read");
            }
        }

        private void readingSessionsLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (readingSessionsLb.SelectedItem != null)
            {
                var indexId = readingSessionsLb.SelectedItem!.ToString()!.IndexOf('=');
                string readingSessionId;
                var readingSession = new ReadingSession { Title = "" };
                if (indexId != -1)
                {
                    readingSessionId = readingSessionsLb.SelectedItem!.ToString()!.Substring(indexId + 2);
                    readingSession = _context.ReadingSession.Find(int.Parse(readingSessionId));

                    AddReadingSessionForm addReadingSessionForm = new(readingSession!);
                    Hide();
                    addReadingSessionForm.Show();

                    addReadingSessionForm.FormClosed += (s, args) => Close();
                }
                else
                {
                    MessageBox.Show("Please select the correct reading session!", Name = "Warning");
                }
            }
        }
    }
}
