namespace WinFormsApp1
{
    partial class PatientResults
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
            AdviceButton = new Button();
            BackButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(1, 1);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(134, 72);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ExerciseButton
            // 
            ExerciseButton.Location = new Point(1, 70);
            ExerciseButton.Name = "ExerciseButton";
            ExerciseButton.Size = new Size(134, 77);
            ExerciseButton.TabIndex = 1;
            ExerciseButton.Text = "Exercise";
            ExerciseButton.UseVisualStyleBackColor = true;
            ExerciseButton.Click += ExerciseButton_Click;
            // 
            // AdviceButton
            // 
            AdviceButton.Location = new Point(1, 146);
            AdviceButton.Name = "AdviceButton";
            AdviceButton.Size = new Size(134, 67);
            AdviceButton.TabIndex = 2;
            AdviceButton.Text = "Advice";
            AdviceButton.UseVisualStyleBackColor = true;
            AdviceButton.Click += AdviceButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(31, 525);
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
            dataGridView1.Location = new Point(307, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(513, 508);
            dataGridView1.TabIndex = 4;
            // 
            // PatientResults
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 581);
            Controls.Add(dataGridView1);
            Controls.Add(BackButton);
            Controls.Add(AdviceButton);
            Controls.Add(ExerciseButton);
            Controls.Add(HomeButton);
            Name = "PatientResults";
            Text = "PatientResults";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button ExerciseButton;
        private Button AdviceButton;
        private Button BackButton;
        private DataGridView dataGridView1;
    }
}