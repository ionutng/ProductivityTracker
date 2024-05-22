namespace ProductivityTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            studyBtn = new Button();
            workoutBtn = new Button();
            readBtn = new Button();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(750, 500);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 21);
            label1.Name = "label1";
            label1.Size = new Size(309, 41);
            label1.TabIndex = 1;
            label1.Text = "Productivity Tracker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 76);
            label2.Name = "label2";
            label2.Size = new Size(180, 22);
            label2.TabIndex = 2;
            label2.Text = "Log a productive task";
            // 
            // studyBtn
            // 
            studyBtn.Location = new Point(375, 150);
            studyBtn.Name = "studyBtn";
            studyBtn.Size = new Size(112, 34);
            studyBtn.TabIndex = 3;
            studyBtn.Text = "Study";
            studyBtn.UseVisualStyleBackColor = true;
            // 
            // workoutBtn
            // 
            workoutBtn.Location = new Point(375, 210);
            workoutBtn.Name = "workoutBtn";
            workoutBtn.Size = new Size(112, 34);
            workoutBtn.TabIndex = 4;
            workoutBtn.Text = "Workout";
            workoutBtn.UseVisualStyleBackColor = true;
            // 
            // readBtn
            // 
            readBtn.Location = new Point(375, 270);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(112, 34);
            readBtn.TabIndex = 5;
            readBtn.Text = "Read";
            readBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(readBtn);
            Controls.Add(workoutBtn);
            Controls.Add(studyBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Label label1;
        private Label label2;
        private Button studyBtn;
        private Button workoutBtn;
        private Button readBtn;
    }
}
