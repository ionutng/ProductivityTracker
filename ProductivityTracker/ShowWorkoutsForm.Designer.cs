namespace ProductivityTracker
{
    partial class ShowWorkoutsForm
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
            workoutsLb = new ListBox();
            fullWorkoutLb = new ListBox();
            editWorkoutBtn = new Button();
            deleteWorkoutBtn = new Button();
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
            label1.Location = new Point(350, 20);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 5;
            label1.Text = "Workouts";
            // 
            // workoutsLb
            // 
            workoutsLb.FormattingEnabled = true;
            workoutsLb.ItemHeight = 27;
            workoutsLb.Location = new Point(10, 110);
            workoutsLb.Name = "workoutsLb";
            workoutsLb.Size = new Size(405, 328);
            workoutsLb.TabIndex = 6;
            workoutsLb.SelectedIndexChanged += workoutsLb_SelectedIndexChanged;
            // 
            // fullWorkoutLb
            // 
            fullWorkoutLb.FormattingEnabled = true;
            fullWorkoutLb.ItemHeight = 27;
            fullWorkoutLb.Location = new Point(457, 110);
            fullWorkoutLb.Name = "fullWorkoutLb";
            fullWorkoutLb.Size = new Size(405, 328);
            fullWorkoutLb.TabIndex = 7;
            // 
            // editWorkoutBtn
            // 
            editWorkoutBtn.Location = new Point(228, 500);
            editWorkoutBtn.Name = "editWorkoutBtn";
            editWorkoutBtn.Size = new Size(187, 34);
            editWorkoutBtn.TabIndex = 8;
            editWorkoutBtn.Text = "Edit Workout";
            editWorkoutBtn.UseVisualStyleBackColor = true;
            editWorkoutBtn.Click += editWorkoutBtn_Click;
            // 
            // deleteWorkoutBtn
            // 
            deleteWorkoutBtn.Location = new Point(457, 500);
            deleteWorkoutBtn.Name = "deleteWorkoutBtn";
            deleteWorkoutBtn.Size = new Size(187, 34);
            deleteWorkoutBtn.TabIndex = 9;
            deleteWorkoutBtn.Text = "Delete Workout";
            deleteWorkoutBtn.UseVisualStyleBackColor = true;
            deleteWorkoutBtn.Click += deleteWorkoutBtn_Click;
            // 
            // ShowWorkoutsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(deleteWorkoutBtn);
            Controls.Add(editWorkoutBtn);
            Controls.Add(fullWorkoutLb);
            Controls.Add(workoutsLb);
            Controls.Add(label1);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ShowWorkoutsForm";
            Text = "ShowWorkoutsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Button goBackBtn;
        private Label label1;
        private ListBox workoutsLb;
        private ListBox fullWorkoutLb;
        private Button editWorkoutBtn;
        private Button deleteWorkoutBtn;
    }
}