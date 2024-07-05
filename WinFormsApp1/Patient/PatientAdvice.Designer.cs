namespace WinFormsApp1
{
    partial class PatientAdvice
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
            HomeButton = new Button();
            ExerciseButton = new Button();
            ResultsButton = new Button();
            BackButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(0, 0);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(139, 82);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ExerciseButton
            // 
            ExerciseButton.Location = new Point(0, 79);
            ExerciseButton.Name = "ExerciseButton";
            ExerciseButton.Size = new Size(139, 76);
            ExerciseButton.TabIndex = 1;
            ExerciseButton.Text = "Exercise";
            ExerciseButton.UseVisualStyleBackColor = true;
            ExerciseButton.Click += ExerciseButton_Click;
            // 
            // ResultsButton
            // 
            ResultsButton.Location = new Point(-1, 153);
            ResultsButton.Name = "ResultsButton";
            ResultsButton.Size = new Size(140, 76);
            ResultsButton.TabIndex = 2;
            ResultsButton.Text = "Results";
            ResultsButton.UseVisualStyleBackColor = true;
            ResultsButton.Click += ResultsButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(39, 525);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 515);
            dataGridView1.TabIndex = 4;
            // 
            // PatientAdvice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 599);
            Controls.Add(dataGridView1);
            Controls.Add(BackButton);
            Controls.Add(ResultsButton);
            Controls.Add(ExerciseButton);
            Controls.Add(HomeButton);
            Name = "PatientAdvice";
            Text = "PatientAdvice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button ExerciseButton;
        private Button ResultsButton;
        private Button BackButton;
        private DataGridView dataGridView1;
    }
}