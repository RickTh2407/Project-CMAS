namespace WinFormsApp1
{
    partial class PatientStartTest
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
            StartTestButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(1, 2);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(128, 72);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ResultsButton
            // 
            ResultsButton.Location = new Point(0, 73);
            ResultsButton.Name = "ResultsButton";
            ResultsButton.Size = new Size(129, 66);
            ResultsButton.TabIndex = 1;
            ResultsButton.Text = "Results";
            ResultsButton.UseVisualStyleBackColor = true;
            ResultsButton.Click += ResultsButton_Click;
            // 
            // AdviceButton
            // 
            AdviceButton.Location = new Point(0, 138);
            AdviceButton.Name = "AdviceButton";
            AdviceButton.Size = new Size(129, 67);
            AdviceButton.TabIndex = 2;
            AdviceButton.Text = "Advice";
            AdviceButton.UseVisualStyleBackColor = true;
            AdviceButton.Click += AdviceButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(48, 515);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(94, 29);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // StartTestButton
            // 
            StartTestButton.Location = new Point(657, 515);
            StartTestButton.Name = "StartTestButton";
            StartTestButton.Size = new Size(248, 29);
            StartTestButton.TabIndex = 4;
            StartTestButton.Text = "Start Test";
            StartTestButton.UseVisualStyleBackColor = true;
            StartTestButton.Click += StartTestButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(271, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(519, 358);
            dataGridView1.TabIndex = 5;
            // 
            // PatientStartTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 582);
            Controls.Add(dataGridView1);
            Controls.Add(StartTestButton);
            Controls.Add(BackButton);
            Controls.Add(AdviceButton);
            Controls.Add(ResultsButton);
            Controls.Add(HomeButton);
            Name = "PatientStartTest";
            Text = "PatientStartTest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private Button ResultsButton;
        private Button AdviceButton;
        private Button BackButton;
        private Button StartTestButton;
        private DataGridView dataGridView1;
    }
}