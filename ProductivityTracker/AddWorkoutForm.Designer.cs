namespace ProductivityTracker
{
    partial class AddWorkoutForm
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
            titleLabel = new Label();
            nameLabel = new Label();
            nameTb = new TextBox();
            setsLabel = new Label();
            setsNud = new NumericUpDown();
            repsNud = new NumericUpDown();
            repsLabel = new Label();
            exerciseLb = new ListBox();
            addExerciseBtn = new Button();
            distanceLabel = new Label();
            timeLabel = new Label();
            paceLabel = new Label();
            addRunBtn = new Button();
            runLb = new ListBox();
            addWorkoutBtn = new Button();
            endTimeDtp = new DateTimePicker();
            endTimeLabel = new Label();
            startTimeDtp = new DateTimePicker();
            startTimeLabel = new Label();
            dateDtp = new DateTimePicker();
            dateLabel = new Label();
            timeDtp = new DateTimePicker();
            distanceTb = new TextBox();
            paceDtp = new DateTimePicker();
            deleteWorkoutBtn = new Button();
            editExerciseBtn = new Button();
            deleteExerciseBtn = new Button();
            deleteRunBtn = new Button();
            editRunBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)setsNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repsNud).BeginInit();
            SuspendLayout();
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(10, 800);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(112, 34);
            goBackBtn.TabIndex = 4;
            goBackBtn.Text = "Back";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(750, 800);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(297, 21);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(235, 41);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "Add a Workout";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 108);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 27);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(87, 105);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(284, 35);
            nameTb.TabIndex = 7;
            // 
            // setsLabel
            // 
            setsLabel.AutoSize = true;
            setsLabel.Location = new Point(30, 159);
            setsLabel.Name = "setsLabel";
            setsLabel.Size = new Size(51, 27);
            setsLabel.TabIndex = 8;
            setsLabel.Text = "Sets";
            // 
            // setsNud
            // 
            setsNud.Location = new Point(87, 157);
            setsNud.Name = "setsNud";
            setsNud.Size = new Size(141, 35);
            setsNud.TabIndex = 9;
            // 
            // repsNud
            // 
            repsNud.Location = new Point(87, 210);
            repsNud.Name = "repsNud";
            repsNud.Size = new Size(141, 35);
            repsNud.TabIndex = 11;
            // 
            // repsLabel
            // 
            repsLabel.AutoSize = true;
            repsLabel.Location = new Point(21, 212);
            repsLabel.Name = "repsLabel";
            repsLabel.Size = new Size(60, 27);
            repsLabel.TabIndex = 10;
            repsLabel.Text = "Reps";
            // 
            // exerciseLb
            // 
            exerciseLb.FormattingEnabled = true;
            exerciseLb.ItemHeight = 27;
            exerciseLb.Location = new Point(12, 311);
            exerciseLb.Name = "exerciseLb";
            exerciseLb.Size = new Size(359, 166);
            exerciseLb.TabIndex = 12;
            exerciseLb.SelectedIndexChanged += exerciseLb_SelectedIndexChanged;
            // 
            // addExerciseBtn
            // 
            addExerciseBtn.Location = new Point(87, 262);
            addExerciseBtn.Name = "addExerciseBtn";
            addExerciseBtn.Size = new Size(174, 34);
            addExerciseBtn.TabIndex = 13;
            addExerciseBtn.Text = "Add Exercise";
            addExerciseBtn.UseVisualStyleBackColor = true;
            addExerciseBtn.Click += addExerciseBtn_Click;
            // 
            // distanceLabel
            // 
            distanceLabel.AutoSize = true;
            distanceLabel.Location = new Point(474, 108);
            distanceLabel.Name = "distanceLabel";
            distanceLabel.Size = new Size(96, 27);
            distanceLabel.TabIndex = 20;
            distanceLabel.Text = "Distance";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(510, 159);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(60, 27);
            timeLabel.TabIndex = 22;
            timeLabel.Text = "Time";
            // 
            // paceLabel
            // 
            paceLabel.AutoSize = true;
            paceLabel.Location = new Point(510, 206);
            paceLabel.Name = "paceLabel";
            paceLabel.Size = new Size(59, 27);
            paceLabel.TabIndex = 24;
            paceLabel.Text = "Pace";
            // 
            // addRunBtn
            // 
            addRunBtn.Location = new Point(576, 262);
            addRunBtn.Name = "addRunBtn";
            addRunBtn.Size = new Size(160, 34);
            addRunBtn.TabIndex = 26;
            addRunBtn.Text = "Add Run";
            addRunBtn.UseVisualStyleBackColor = true;
            addRunBtn.Click += addRunBtn_Click;
            // 
            // runLb
            // 
            runLb.FormattingEnabled = true;
            runLb.ItemHeight = 27;
            runLb.Location = new Point(474, 311);
            runLb.Name = "runLb";
            runLb.Size = new Size(334, 166);
            runLb.TabIndex = 27;
            runLb.SelectedIndexChanged += runLb_SelectedIndexChanged;
            // 
            // addWorkoutBtn
            // 
            addWorkoutBtn.Location = new Point(297, 709);
            addWorkoutBtn.Name = "addWorkoutBtn";
            addWorkoutBtn.Size = new Size(197, 34);
            addWorkoutBtn.TabIndex = 28;
            addWorkoutBtn.Text = "Add Workout";
            addWorkoutBtn.UseVisualStyleBackColor = true;
            addWorkoutBtn.Click += addWorkoutBtn_Click;
            // 
            // endTimeDtp
            // 
            endTimeDtp.Location = new Point(297, 646);
            endTimeDtp.Name = "endTimeDtp";
            endTimeDtp.Size = new Size(127, 35);
            endTimeDtp.TabIndex = 34;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new Point(186, 652);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new Size(105, 27);
            endTimeLabel.TabIndex = 33;
            endTimeLabel.Text = "End Time";
            // 
            // startTimeDtp
            // 
            startTimeDtp.Location = new Point(297, 590);
            startTimeDtp.Name = "startTimeDtp";
            startTimeDtp.Size = new Size(127, 35);
            startTimeDtp.TabIndex = 32;
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new Point(180, 596);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new Size(111, 27);
            startTimeLabel.TabIndex = 31;
            startTimeLabel.Text = "Start Time";
            // 
            // dateDtp
            // 
            dateDtp.Location = new Point(297, 534);
            dateDtp.Name = "dateDtp";
            dateDtp.Size = new Size(328, 35);
            dateDtp.TabIndex = 30;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(233, 540);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(58, 27);
            dateLabel.TabIndex = 29;
            dateLabel.Text = "Date";
            // 
            // timeDtp
            // 
            timeDtp.Location = new Point(576, 153);
            timeDtp.Name = "timeDtp";
            timeDtp.Size = new Size(127, 35);
            timeDtp.TabIndex = 35;
            timeDtp.Value = new DateTime(2024, 5, 22, 0, 10, 0, 0);
            // 
            // distanceTb
            // 
            distanceTb.Location = new Point(576, 100);
            distanceTb.Name = "distanceTb";
            distanceTb.Size = new Size(127, 35);
            distanceTb.TabIndex = 36;
            // 
            // paceDtp
            // 
            paceDtp.Location = new Point(575, 200);
            paceDtp.Name = "paceDtp";
            paceDtp.Size = new Size(128, 35);
            paceDtp.TabIndex = 37;
            paceDtp.Value = new DateTime(2024, 5, 22, 4, 46, 0, 0);
            // 
            // deleteWorkoutBtn
            // 
            deleteWorkoutBtn.Location = new Point(297, 760);
            deleteWorkoutBtn.Name = "deleteWorkoutBtn";
            deleteWorkoutBtn.Size = new Size(197, 34);
            deleteWorkoutBtn.TabIndex = 38;
            deleteWorkoutBtn.Text = "Delete Workout";
            deleteWorkoutBtn.UseVisualStyleBackColor = true;
            deleteWorkoutBtn.Visible = false;
            deleteWorkoutBtn.Click += deleteWorkoutBtn_Click;
            // 
            // editExerciseBtn
            // 
            editExerciseBtn.Location = new Point(10, 492);
            editExerciseBtn.Name = "editExerciseBtn";
            editExerciseBtn.Size = new Size(163, 34);
            editExerciseBtn.TabIndex = 39;
            editExerciseBtn.Text = "Edit Exercise";
            editExerciseBtn.UseVisualStyleBackColor = true;
            editExerciseBtn.Click += editExerciseBtn_Click;
            // 
            // deleteExerciseBtn
            // 
            deleteExerciseBtn.Location = new Point(183, 492);
            deleteExerciseBtn.Name = "deleteExerciseBtn";
            deleteExerciseBtn.Size = new Size(188, 34);
            deleteExerciseBtn.TabIndex = 40;
            deleteExerciseBtn.Text = "Delete Exercise";
            deleteExerciseBtn.UseVisualStyleBackColor = true;
            deleteExerciseBtn.Click += deleteExerciseBtn_Click_1;
            // 
            // deleteRunBtn
            // 
            deleteRunBtn.Location = new Point(647, 492);
            deleteRunBtn.Name = "deleteRunBtn";
            deleteRunBtn.Size = new Size(188, 34);
            deleteRunBtn.TabIndex = 42;
            deleteRunBtn.Text = "Delete Run";
            deleteRunBtn.UseVisualStyleBackColor = true;
            deleteRunBtn.Click += deleteRunBtn_Click;
            // 
            // editRunBtn
            // 
            editRunBtn.Location = new Point(474, 492);
            editRunBtn.Name = "editRunBtn";
            editRunBtn.Size = new Size(163, 34);
            editRunBtn.TabIndex = 41;
            editRunBtn.Text = "Edit Run";
            editRunBtn.UseVisualStyleBackColor = true;
            editRunBtn.Click += editRunBtn_Click;
            // 
            // AddWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 844);
            Controls.Add(deleteRunBtn);
            Controls.Add(editRunBtn);
            Controls.Add(deleteExerciseBtn);
            Controls.Add(editExerciseBtn);
            Controls.Add(deleteWorkoutBtn);
            Controls.Add(paceDtp);
            Controls.Add(distanceTb);
            Controls.Add(timeDtp);
            Controls.Add(endTimeDtp);
            Controls.Add(endTimeLabel);
            Controls.Add(startTimeDtp);
            Controls.Add(startTimeLabel);
            Controls.Add(dateDtp);
            Controls.Add(dateLabel);
            Controls.Add(addWorkoutBtn);
            Controls.Add(runLb);
            Controls.Add(addRunBtn);
            Controls.Add(paceLabel);
            Controls.Add(timeLabel);
            Controls.Add(distanceLabel);
            Controls.Add(addExerciseBtn);
            Controls.Add(exerciseLb);
            Controls.Add(repsNud);
            Controls.Add(repsLabel);
            Controls.Add(setsNud);
            Controls.Add(setsLabel);
            Controls.Add(nameTb);
            Controls.Add(nameLabel);
            Controls.Add(titleLabel);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddWorkoutForm";
            Text = "AddWorkoutForm";
            ((System.ComponentModel.ISupportInitialize)setsNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)repsNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackBtn;
        private Button exitBtn;
        private Label titleLabel;
        private Label nameLabel;
        private TextBox nameTb;
        private Label setsLabel;
        private NumericUpDown setsNud;
        private NumericUpDown repsNud;
        private Label repsLabel;
        private ListBox exerciseLb;
        private Button addExerciseBtn;
        private Label distanceLabel;
        private Label timeLabel;
        private Label paceLabel;
        private Button addRunBtn;
        private ListBox runLb;
        private Button addWorkoutBtn;
        private DateTimePicker endTimeDtp;
        private Label endTimeLabel;
        private DateTimePicker startTimeDtp;
        private Label startTimeLabel;
        private DateTimePicker dateDtp;
        private Label dateLabel;
        private DateTimePicker timeDtp;
        private TextBox distanceTb;
        private DateTimePicker paceDtp;
        private Button deleteWorkoutBtn;
        private Button editExerciseBtn;
        private Button deleteExerciseBtn;
        private Button deleteRunBtn;
        private Button editRunBtn;
    }
}