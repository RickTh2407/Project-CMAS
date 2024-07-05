namespace WinFormsApp1
{
    partial class PatientStartTask
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
            ResultsButton = new Button();
            AdviceButton = new Button();
            BackButton = new Button();
            TaskStartButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(-2, 3);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(125, 65);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            // 
            // ResultsButton
            // 
            ResultsButton.Location = new Point(-1, 65);
            ResultsButton.Name = "ResultsButton";
            ResultsButton.Size = new Size(126, 66);
            ResultsButton.TabIndex = 1;
            ResultsButton.Text = "Results";
            ResultsButton.UseVisualStyleBackColor = true;
            // 
            // AdviceButton
            // 
            AdviceButton.Location = new Point(-2, 129);
            AdviceButton.Name = "AdviceButton";
            AdviceButton.Size = new Size(127, 64);
            AdviceButton.TabIndex = 2;
            AdviceButton.Text = "Advice";
            AdviceButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(52, 519);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // TaskStartButton
            // 
            TaskStartButton.Location = new Point(651, 529);
            TaskStartButton.Name = "TaskStartButton";
            TaskStartButton.Size = new Size(221, 29);
            TaskStartButton.TabIndex = 4;
            TaskStartButton.Text = "Start Task";
            TaskStartButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(557, 394);
            dataGridView1.TabIndex = 6;
            // 
            // PatientStartTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 586);
            Controls.Add(dataGridView1);
            Controls.Add(TaskStartButton);
            Controls.Add(BackButton);
            Controls.Add(AdviceButton);
            Controls.Add(ResultsButton);
            Controls.Add(HomeButton);
            Name = "PatientStartTask";
            Text = "PatientStartTask";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button ResultsButton;
        private Button AdviceButton;
        private Button BackButton;
        private Button TaskStartButton;
        private DataGridView dataGridView1;
    }
}