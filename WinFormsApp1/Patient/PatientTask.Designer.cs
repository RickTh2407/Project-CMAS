namespace WinFormsApp1
{
    partial class PatientTask
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
            NextTaskButton = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(0, 1);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(129, 72);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ResultsButton
            // 
            ResultsButton.Location = new Point(0, 72);
            ResultsButton.Name = "ResultsButton";
            ResultsButton.Size = new Size(129, 67);
            ResultsButton.TabIndex = 1;
            ResultsButton.Text = "Results";
            ResultsButton.UseVisualStyleBackColor = true;
            ResultsButton.Click += ResultsButton_Click;
            // 
            // AdviceButton
            // 
            AdviceButton.Location = new Point(0, 137);
            AdviceButton.Name = "AdviceButton";
            AdviceButton.Size = new Size(129, 71);
            AdviceButton.TabIndex = 2;
            AdviceButton.Text = "Advice";
            AdviceButton.UseVisualStyleBackColor = true;
            AdviceButton.Click += AdviceButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(39, 513);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // NextTaskButton
            // 
            NextTaskButton.Location = new Point(766, 535);
            NextTaskButton.Name = "NextTaskButton";
            NextTaskButton.Size = new Size(94, 29);
            NextTaskButton.TabIndex = 4;
            NextTaskButton.Text = "Next Task";
            NextTaskButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(156, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(506, 431);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(718, 54);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(204, 431);
            dataGridView2.TabIndex = 6;
            // 
            // PatientTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 587);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(NextTaskButton);
            Controls.Add(BackButton);
            Controls.Add(AdviceButton);
            Controls.Add(ResultsButton);
            Controls.Add(HomeButton);
            Name = "PatientTask";
            Text = "PatientTask";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button ResultsButton;
        private Button AdviceButton;
        private Button BackButton;
        private Button NextTaskButton;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}