using ProductivityTracker.Models;

namespace ProductivityTracker
{
    public partial class AddReadingSessionForm : Form
    {
        private readonly ProductivityContext _context;
        private ReadingSession _readingSession;


        public AddReadingSessionForm(ReadingSession readingSession)
        {
            InitializeComponent();
            _context = new ProductivityContext();
            _readingSession = readingSession;

            // Set the custom format string and display the control as an up-down control.
            dateDtp.Format = DateTimePickerFormat.Custom;
            dateDtp.CustomFormat = "dddd, MMM dd, yyyy";
            startTimeDtp.Format = DateTimePickerFormat.Custom;
            startTimeDtp.CustomFormat = "HH:mm";
            startTimeDtp.ShowUpDown = true;
            endTimeDtp.Format = DateTimePickerFormat.Custom;
            endTimeDtp.CustomFormat = "HH:mm";
            endTimeDtp.ShowUpDown = true;

            // If there is a readingSession
            if (_readingSession.Id != 0)
            {
                titleTb.Text = _readingSession.Title;
                authorsTb.Text = _readingSession.Authors;
                pagesNud.Value = _readingSession.TotalPages;
                pagesReadNud.Value = _readingSession.PagesRead;
                var startTime = new TimeOnly(_readingSession.StartTime.Hour, _readingSession.StartTime.Minute);
                var endTime = new TimeOnly(_readingSession.EndTime.Hour, _readingSession.EndTime.Minute);
                var date = new DateTime(_readingSession.Date, startTime);
                dateDtp.Value = date;
                startTimeDtp.Value = date;
                date = new DateTime(_readingSession.Date, endTime);
                endTimeDtp.Value = date;
                addReadingSessionBtn.Text = "Edit Reading Session";
                Text = "EditReadingSessionForm";
                readingSessionLabel.Text = "Edit a Reading Session";
                deleteReadingSessionBtn.Visible = true;
            }
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

        private void addReadingSessionBtn_Click(object sender, EventArgs e)
        {
            var title = titleTb.Text.Trim();
            var authors = authorsTb.Text.Trim();
            var pages = int.Parse(pagesNud.Value.ToString());
            var pagesRead = 0;
            var date = DateOnly.Parse(dateDtp.Value.ToString("dd-MMM-yyyy"));
            var startTime = TimeOnly.Parse(startTimeDtp.Value.ToString("HH:mm"));
            var endTime = TimeOnly.Parse(endTimeDtp.Value.ToString("HH:mm"));

            if (readingRb.Checked)
            {
                pagesRead = int.Parse(pagesReadNud.Value.ToString());
            }
            else if (completedRb.Checked)
            {
                pagesRead = pages;
            }
            else if (planToReadRb.Checked)
            {
                pagesRead = 0;
            }

            var readingSession = new ReadingSession { Title = "" };

            if (addReadingSessionBtn.Text == "Add Reading Session")
            {
                if (planToReadRb.Checked)
                {
                    readingSession = new ReadingSession
                    {
                        Title = title,
                        Authors = authors,
                        TotalPages = pages,
                        PagesRead = pagesRead,
                        Date = date
                    };
                }
                else if (completedRb.Checked || readingRb.Checked)
                {
                    readingSession = new ReadingSession
                    {
                        Title = title,
                        Authors = authors,
                        TotalPages = pages,
                        PagesRead = pagesRead,
                        Date = date,
                        StartTime = startTime,
                        EndTime = endTime,
                        Duration = endTime - startTime
                    };
                }

                _context.ReadingSession.Add(readingSession);
                _context.SaveChanges();
            }
            else
            {
                _readingSession.Title = title;
                _readingSession.Authors = authors;
                _readingSession.TotalPages = pages;
                _readingSession.PagesRead = pagesRead;
                _readingSession.Date = date;
                _readingSession.StartTime = startTime;
                _readingSession.EndTime = endTime;
                _readingSession.Duration = endTime - startTime;

                _context.ReadingSession.Update(_readingSession);
                _context.SaveChanges();
            }

            CrudOperationsForm crudOperationsForm = new("Reading");
            Hide();
            crudOperationsForm.Show();

            crudOperationsForm.FormClosed += (s, args) => Close();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton == readingRb)
            {
                pagesReadNud.Visible = true;
                pagesReadLabel.Visible = true;
                startTimeDtp.Visible = true;
                startTimeLabel.Visible = true;
                endTimeDtp.Visible = true;
                endTimeLabel.Visible = true;
            }
            else if (radioButton == completedRb)
            {
                pagesReadNud.Visible = false;
                pagesReadLabel.Visible = false;
                startTimeDtp.Visible = true;
                startTimeLabel.Visible = true;
                endTimeDtp.Visible = true;
                endTimeLabel.Visible = true;
            }
            else if (radioButton == planToReadRb)
            {
                pagesReadNud.Visible = false;
                pagesReadLabel.Visible = false;
                startTimeDtp.Visible = false;
                startTimeLabel.Visible = false;
                endTimeDtp.Visible = false;
                endTimeLabel.Visible = false;
            }
        }

        private void deleteReadingSessionBtn_Click(object sender, EventArgs e)
        {
            _context.ReadingSession.Remove(_readingSession);
            _context.SaveChanges();

            CrudOperationsForm crudOperationsForm = new("Reading");
            Hide();
            crudOperationsForm.Show();

            crudOperationsForm.FormClosed += (s, args) => Close();
        }
    }
}
