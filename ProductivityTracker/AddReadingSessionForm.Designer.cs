namespace ProductivityTracker
{
    partial class AddReadingSessionForm
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
            readingSessionLabel = new Label();
            titleLabel = new Label();
            titleTb = new TextBox();
            authorsTb = new TextBox();
            authorsLabel = new Label();
            pagesLabel = new Label();
            pagesNud = new NumericUpDown();
            completedRb = new RadioButton();
            readingRb = new RadioButton();
            planToReadRb = new RadioButton();
            statusGb = new GroupBox();
            pagesReadNud = new NumericUpDown();
            pagesReadLabel = new Label();
            addReadingSessionBtn = new Button();
            endTimeDtp = new DateTimePicker();
            endTimeLabel = new Label();
            startTimeDtp = new DateTimePicker();
            startTimeLabel = new Label();
            dateDtp = new DateTimePicker();
            dateLabel = new Label();
            deleteReadingSessionBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pagesNud).BeginInit();
            statusGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pagesReadNud).BeginInit();
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
            // readingSessionLabel
            // 
            readingSessionLabel.AutoSize = true;
            readingSessionLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readingSessionLabel.Location = new Point(250, 25);
            readingSessionLabel.Name = "readingSessionLabel";
            readingSessionLabel.Size = new Size(346, 41);
            readingSessionLabel.TabIndex = 5;
            readingSessionLabel.Text = "Add a Reading Session";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(91, 115);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(113, 27);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Book Title";
            // 
            // titleTb
            // 
            titleTb.Location = new Point(210, 112);
            titleTb.Name = "titleTb";
            titleTb.Size = new Size(150, 35);
            titleTb.TabIndex = 7;
            // 
            // authorsTb
            // 
            authorsTb.Location = new Point(210, 182);
            authorsTb.Name = "authorsTb";
            authorsTb.Size = new Size(150, 35);
            authorsTb.TabIndex = 9;
            // 
            // authorsLabel
            // 
            authorsLabel.Location = new Point(101, 185);
            authorsLabel.Name = "authorsLabel";
            authorsLabel.Size = new Size(113, 27);
            authorsLabel.TabIndex = 8;
            authorsLabel.Text = "Author(s)";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new Point(136, 255);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new Size(68, 27);
            pagesLabel.TabIndex = 10;
            pagesLabel.Text = "Pages";
            // 
            // pagesNud
            // 
            pagesNud.Location = new Point(210, 253);
            pagesNud.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            pagesNud.Name = "pagesNud";
            pagesNud.Size = new Size(150, 35);
            pagesNud.TabIndex = 11;
            // 
            // completedRb
            // 
            completedRb.AutoSize = true;
            completedRb.Location = new Point(14, 34);
            completedRb.Name = "completedRb";
            completedRb.Size = new Size(142, 31);
            completedRb.TabIndex = 13;
            completedRb.TabStop = true;
            completedRb.Text = "Completed";
            completedRb.UseVisualStyleBackColor = true;
            completedRb.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // readingRb
            // 
            readingRb.AutoSize = true;
            readingRb.Location = new Point(14, 71);
            readingRb.Name = "readingRb";
            readingRb.Size = new Size(116, 31);
            readingRb.TabIndex = 14;
            readingRb.TabStop = true;
            readingRb.Text = "Reading";
            readingRb.UseVisualStyleBackColor = true;
            readingRb.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // planToReadRb
            // 
            planToReadRb.AutoSize = true;
            planToReadRb.Location = new Point(14, 108);
            planToReadRb.Name = "planToReadRb";
            planToReadRb.Size = new Size(161, 31);
            planToReadRb.TabIndex = 15;
            planToReadRb.TabStop = true;
            planToReadRb.Text = "Plan to Read";
            planToReadRb.UseVisualStyleBackColor = true;
            planToReadRb.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // statusGb
            // 
            statusGb.Controls.Add(completedRb);
            statusGb.Controls.Add(planToReadRb);
            statusGb.Controls.Add(readingRb);
            statusGb.Location = new Point(436, 92);
            statusGb.Name = "statusGb";
            statusGb.Size = new Size(261, 150);
            statusGb.TabIndex = 16;
            statusGb.TabStop = false;
            statusGb.Text = "Status";
            // 
            // pagesReadNud
            // 
            pagesReadNud.Location = new Point(566, 259);
            pagesReadNud.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            pagesReadNud.Name = "pagesReadNud";
            pagesReadNud.Size = new Size(131, 35);
            pagesReadNud.TabIndex = 18;
            pagesReadNud.Visible = false;
            // 
            // pagesReadLabel
            // 
            pagesReadLabel.AutoSize = true;
            pagesReadLabel.Location = new Point(436, 261);
            pagesReadLabel.Name = "pagesReadLabel";
            pagesReadLabel.Size = new Size(124, 27);
            pagesReadLabel.TabIndex = 17;
            pagesReadLabel.Text = "Pages Read";
            pagesReadLabel.Visible = false;
            // 
            // addReadingSessionBtn
            // 
            addReadingSessionBtn.Location = new Point(210, 498);
            addReadingSessionBtn.Name = "addReadingSessionBtn";
            addReadingSessionBtn.Size = new Size(257, 34);
            addReadingSessionBtn.TabIndex = 19;
            addReadingSessionBtn.Text = "Add Reading Session";
            addReadingSessionBtn.UseVisualStyleBackColor = true;
            addReadingSessionBtn.Click += addReadingSessionBtn_Click;
            // 
            // endTimeDtp
            // 
            endTimeDtp.Location = new Point(318, 437);
            endTimeDtp.Name = "endTimeDtp";
            endTimeDtp.Size = new Size(117, 35);
            endTimeDtp.TabIndex = 25;
            endTimeDtp.Value = new DateTime(2024, 6, 5, 12, 3, 0, 0);
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new Point(207, 443);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(105, 27);
            endTimeLabel.TabIndex = 24;
            endTimeLabel.Text = "End Time";
            // 
            // startTimeDtp
            // 
            startTimeDtp.Location = new Point(318, 381);
            startTimeDtp.Name = "startTimeDtp";
            startTimeDtp.Size = new Size(117, 35);
            startTimeDtp.TabIndex = 23;
            startTimeDtp.Value = new DateTime(2024, 6, 5, 12, 2, 0, 0);
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new Point(201, 387);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(111, 27);
            startTimeLabel.TabIndex = 22;
            startTimeLabel.Text = "Start Time";
            // 
            // dateDtp
            // 
            dateDtp.Location = new Point(318, 325);
            dateDtp.Name = "dateDtp";
            dateDtp.Size = new Size(328, 35);
            dateDtp.TabIndex = 21;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(254, 331);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(58, 27);
            dateLabel.TabIndex = 20;
            dateLabel.Text = "Date";
            // 
            // deleteReadingSessionBtn
            // 
            deleteReadingSessionBtn.Location = new Point(473, 498);
            deleteReadingSessionBtn.Name = "deleteReadingSessionBtn";
            deleteReadingSessionBtn.Size = new Size(257, 34);
            deleteReadingSessionBtn.TabIndex = 26;
            deleteReadingSessionBtn.Text = "Delete Reading Session";
            deleteReadingSessionBtn.UseVisualStyleBackColor = true;
            deleteReadingSessionBtn.Visible = false;
            deleteReadingSessionBtn.Click += deleteReadingSessionBtn_Click;
            // 
            // AddReadingSessionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(deleteReadingSessionBtn);
            Controls.Add(endTimeDtp);
            Controls.Add(endTimeLabel);
            Controls.Add(startTimeDtp);
            Controls.Add(startTimeLabel);
            Controls.Add(dateDtp);
            Controls.Add(dateLabel);
            Controls.Add(addReadingSessionBtn);
            Controls.Add(pagesReadNud);
            Controls.Add(pagesReadLabel);
            Controls.Add(statusGb);
            Controls.Add(pagesNud);
            Controls.Add(pagesLabel);
            Controls.Add(authorsTb);
            Controls.Add(authorsLabel);
            Controls.Add(titleTb);
            Controls.Add(titleLabel);
            Controls.Add(readingSessionLabel);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddReadingSessionForm";
            Text = "AddReadingSessionForm";
            ((System.ComponentModel.ISupportInitialize)pagesNud).EndInit();
            statusGb.ResumeLayout(false);
            statusGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pagesReadNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackBtn;
        private Button exitBtn;
        private Label readingSessionLabel;
        private Label titleLabel;
        private TextBox titleTb;
        private TextBox authorsTb;
        private Label authorsLabel;
        private Label pagesLabel;
        private NumericUpDown pagesNud;
        private RadioButton completedRb;
        private RadioButton readingRb;
        private RadioButton planToReadRb;
        private GroupBox statusGb;
        private NumericUpDown pagesReadNud;
        private Label pagesReadLabel;
        private Button addReadingSessionBtn;
        private DateTimePicker endTimeDtp;
        private Label endTimeLabel;
        private DateTimePicker startTimeDtp;
        private Label startTimeLabel;
        private DateTimePicker dateDtp;
        private Label dateLabel;
        private Button deleteReadingSessionBtn;
    }
}