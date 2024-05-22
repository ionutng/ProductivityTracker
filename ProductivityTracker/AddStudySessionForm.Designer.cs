namespace ProductivityTracker
{
    partial class AddStudySessionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            goBackBtn = new Button();
            exitBtn = new Button();
            label1 = new Label();
            dateLabel = new Label();
            dateDtp = new DateTimePicker();
            startTimeLabel = new Label();
            startTimeDtp = new DateTimePicker();
            endTimeDtp = new DateTimePicker();
            endTimeLabel = new Label();
            addStudySessionBtn = new Button();
            deleteStudySessionBtn = new Button();
            SuspendLayout();
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(10, 500);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(112, 34);
            goBackBtn.TabIndex = 4;
            goBackBtn.Text = "Back";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(750, 500);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 25);
            label1.Name = "label1";
            label1.Size = new Size(311, 41);
            label1.TabIndex = 5;
            label1.Text = "Add a Study Session";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(232, 141);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(58, 27);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Date";
            // 
            // dateDtp
            // 
            dateDtp.Location = new Point(296, 135);
            dateDtp.Name = "dateDtp";
            dateDtp.Size = new Size(328, 35);
            dateDtp.TabIndex = 7;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new Point(179, 197);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(111, 27);
            startTimeLabel.TabIndex = 8;
            startTimeLabel.Text = "Start Time";
            // 
            // startTimeDtp
            // 
            startTimeDtp.Location = new Point(296, 191);
            startTimeDtp.Name = "startTimeDtp";
            startTimeDtp.Size = new Size(117, 35);
            startTimeDtp.TabIndex = 9;
            // 
            // endTimeDtp
            // 
            endTimeDtp.Location = new Point(296, 247);
            endTimeDtp.Name = "endTimeDtp";
            endTimeDtp.Size = new Size(117, 35);
            endTimeDtp.TabIndex = 11;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new Point(185, 253);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(105, 27);
            endTimeLabel.TabIndex = 10;
            endTimeLabel.Text = "End Time";
            // 
            // addStudySessionBtn
            // 
            addStudySessionBtn.Location = new Point(296, 325);
            addStudySessionBtn.Name = "addStudySessionBtn";
            addStudySessionBtn.Size = new Size(233, 34);
            addStudySessionBtn.TabIndex = 12;
            addStudySessionBtn.Text = "Add Study Session";
            addStudySessionBtn.UseVisualStyleBackColor = true;
            addStudySessionBtn.Click += addStudySessionBtn_Click;
            // 
            // deleteStudySessionBtn
            // 
            deleteStudySessionBtn.Location = new Point(296, 376);
            deleteStudySessionBtn.Name = "deleteStudySessionBtn";
            deleteStudySessionBtn.Size = new Size(233, 34);
            deleteStudySessionBtn.TabIndex = 14;
            deleteStudySessionBtn.Text = "Delete Study Session";
            deleteStudySessionBtn.UseVisualStyleBackColor = true;
            deleteStudySessionBtn.Visible = false;
            deleteStudySessionBtn.Click += deleteStudySessionBtn_Click;
            // 
            // AddStudySessionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(deleteStudySessionBtn);
            Controls.Add(addStudySessionBtn);
            Controls.Add(endTimeDtp);
            Controls.Add(endTimeLabel);
            Controls.Add(startTimeDtp);
            Controls.Add(startTimeLabel);
            Controls.Add(dateDtp);
            Controls.Add(dateLabel);
            Controls.Add(label1);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddStudySessionForm";
            Text = "AddStudySessionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackBtn;
        private Button exitBtn;
        private Label label1;
        private Label dateLabel;
        private DateTimePicker dateDtp;
        private Label startTimeLabel;
        private DateTimePicker startTimeDtp;
        private DateTimePicker endTimeDtp;
        private Label endTimeLabel;
        private Button addStudySessionBtn;
        private Button deleteStudySessionBtn;
    }
}