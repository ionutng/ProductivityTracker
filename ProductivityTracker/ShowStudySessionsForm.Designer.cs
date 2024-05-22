namespace ProductivityTracker
{
    partial class ShowStudySessionsForm
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
            studySessionsLb = new ListBox();
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
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 5;
            label1.Text = "Study Sessions";
            // 
            // studySessionsLb
            // 
            studySessionsLb.FormattingEnabled = true;
            studySessionsLb.ItemHeight = 27;
            studySessionsLb.Location = new Point(200, 110);
            studySessionsLb.Name = "studySessionsLb";
            studySessionsLb.Size = new Size(480, 328);
            studySessionsLb.TabIndex = 6;
            studySessionsLb.SelectedIndexChanged += studySessionsLb_SelectedIndexChanged;
            // 
            // ShowStudySessionsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(studySessionsLb);
            Controls.Add(label1);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ShowStudySessionsForm";
            Text = "ShowStudySessionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackBtn;
        private Button exitBtn;
        private Label label1;
        private ListBox studySessionsLb;
    }
}