namespace ProductivityTracker
{
    partial class CrudOperationsForm
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
            exitBtn = new Button();
            goBackBtn = new Button();
            taskLabel = new Label();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            showBtn = new Button();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(750, 500);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(10, 500);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(112, 34);
            goBackBtn.TabIndex = 2;
            goBackBtn.Text = "Back";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskLabel.Location = new Point(318, 23);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(103, 41);
            taskLabel.TabIndex = 3;
            taskLabel.Text = "label1";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(375, 150);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(112, 34);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(375, 270);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(112, 34);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(375, 330);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(112, 34);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(375, 210);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(112, 34);
            showBtn.TabIndex = 7;
            showBtn.Text = "Show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // CrudOperationsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(showBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(taskLabel);
            Controls.Add(goBackBtn);
            Controls.Add(exitBtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CrudOperationsForm";
            Text = "CrudOperations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Button goBackBtn;
        private Label taskLabel;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button showBtn;
    }
}