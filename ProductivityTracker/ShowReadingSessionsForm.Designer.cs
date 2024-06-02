namespace ProductivityTracker
{
    partial class ShowReadingSessionsForm
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
            label1 = new Label();
            statusGb = new GroupBox();
            completedRb = new RadioButton();
            planToReadRb = new RadioButton();
            readingRb = new RadioButton();
            goBackBtn = new Button();
            exitBtn = new Button();
            readingSessionsLb = new ListBox();
            statusGb.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 22);
            label1.Name = "label1";
            label1.Size = new Size(265, 41);
            label1.TabIndex = 0;
            label1.Text = "Reading Sessions";
            // 
            // statusGb
            // 
            statusGb.Controls.Add(completedRb);
            statusGb.Controls.Add(planToReadRb);
            statusGb.Controls.Add(readingRb);
            statusGb.Location = new Point(303, 88);
            statusGb.Name = "statusGb";
            statusGb.Size = new Size(261, 150);
            statusGb.TabIndex = 17;
            statusGb.TabStop = false;
            statusGb.Text = "Status";
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
            // goBackBtn
            // 
            goBackBtn.Location = new Point(10, 600);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(112, 34);
            goBackBtn.TabIndex = 19;
            goBackBtn.Text = "Back";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(750, 600);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 18;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // readingSessionsLb
            // 
            readingSessionsLb.FormattingEnabled = true;
            readingSessionsLb.ItemHeight = 27;
            readingSessionsLb.Location = new Point(10, 279);
            readingSessionsLb.Name = "readingSessionsLb";
            readingSessionsLb.Size = new Size(852, 301);
            readingSessionsLb.TabIndex = 20;
            readingSessionsLb.SelectedIndexChanged += readingSessionsLb_SelectedIndexChanged;
            // 
            // ShowReadingSessionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 644);
            Controls.Add(readingSessionsLb);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Controls.Add(statusGb);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ShowReadingSessionsForm";
            Text = "ShowReadingSessionsForm";
            statusGb.ResumeLayout(false);
            statusGb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox statusGb;
        private RadioButton completedRb;
        private RadioButton planToReadRb;
        private RadioButton readingRb;
        private Button goBackBtn;
        private Button exitBtn;
        private ListBox readingSessionsLb;
    }
}