namespace WinFormsApp1
{
    partial class PatientHome
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
            ExerciseButton = new Button();
            ResultButton = new Button();
            AdviceButton = new Button();
            LogoutButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExerciseButton
            // 
            ExerciseButton.Location = new Point(0, -1);
            ExerciseButton.Name = "ExerciseButton";
            ExerciseButton.Size = new Size(130, 73);
            ExerciseButton.TabIndex = 0;
            ExerciseButton.Text = "Exercise";
            ExerciseButton.UseVisualStyleBackColor = true;
            ExerciseButton.Click += ExerciseButton_Click;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(0, 68);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(130, 70);
            ResultButton.TabIndex = 1;
            ResultButton.Text = "Results";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // AdviceButton
            // 
            AdviceButton.Location = new Point(0, 134);
            AdviceButton.Name = "AdviceButton";
            AdviceButton.Size = new Size(130, 61);
            AdviceButton.TabIndex = 2;
            AdviceButton.Text = "Advice";
            AdviceButton.UseVisualStyleBackColor = true;
            AdviceButton.Click += AdviceButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(34, 518);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(834, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 442);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 93);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 5;
            label1.Text = "Welcome user ";
            // 
            // PatientHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 624);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(LogoutButton);
            Controls.Add(AdviceButton);
            Controls.Add(ResultButton);
            Controls.Add(ExerciseButton);
            Name = "PatientHome";
            Text = "PatientHome";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExerciseButton;
        private Button ResultButton;
        private Button AdviceButton;
        private Button LogoutButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}