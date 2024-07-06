namespace WinFormsApp1
{
    partial class CmasDoctorResult
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
            BackBtn = new Button();
            HomeBtn = new Button();
            PatientsBtn = new Button();
            DgResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgResults).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 403);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 51);
            BackBtn.TabIndex = 7;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(12, 12);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(125, 51);
            HomeBtn.TabIndex = 8;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // PatientsBtn
            // 
            PatientsBtn.Location = new Point(12, 69);
            PatientsBtn.Name = "PatientsBtn";
            PatientsBtn.Size = new Size(125, 51);
            PatientsBtn.TabIndex = 9;
            PatientsBtn.Text = "Patients";
            PatientsBtn.UseVisualStyleBackColor = true;
            PatientsBtn.Click += PatientsBtn_Click;
            // 
            // DgResults
            // 
            DgResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgResults.Location = new Point(176, 12);
            DgResults.Name = "DgResults";
            DgResults.Size = new Size(746, 442);
            DgResults.TabIndex = 10;
            DgResults.CellContentClick += DgResults_CellContentClick;
            // 
            // CmasDoctorResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 466);
            Controls.Add(DgResults);
            Controls.Add(PatientsBtn);
            Controls.Add(HomeBtn);
            Controls.Add(BackBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CmasDoctorResult";
            Text = "CmasDoctorResult";
            ((System.ComponentModel.ISupportInitialize)DgResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BackBtn;
        private Button HomeBtn;
        private Button PatientsBtn;
        private DataGridView DgResults;
    }
}