namespace ProductivityTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void studyBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the crud operations form,
            // hide the first form and show the crud operations form.
            CrudOperationsForm crudOperationsForm = new("Study Session");
            Hide();
            crudOperationsForm.Show();

            // Subscribing to an event (FormClosed) using the "+=" operator, meaning
            // adding an event handler to the event.
            // s is the sender of the event, so crudOperationsForm.
            // args is an instance of FormClosedEventArgs, it contains the event data.
            // When the crud operations form is closed, the first form will also be closed,
            // preventing the application from remaining in memory with the first form hidden.
            crudOperationsForm.FormClosed += (s, args) => Close();
        }
    }
}
