namespace WinFormsApp1
{
    partial class CmasDoctorAdvice
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
            DgAdvice = new DataGridView();
            HomeBtn = new Button();
            PatientsBtn = new Button();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DgAdvice).BeginInit();
            SuspendLayout();
            // 
            // DgAdvice
            // 
            DgAdvice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgAdvice.Location = new Point(164, 12);
            DgAdvice.Name = "DgAdvice";
            DgAdvice.Size = new Size(758, 442);
            DgAdvice.TabIndex = 0;
            DgAdvice.CellContentClick += DgAdvice_CellContentClick;
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(12, 12);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(125, 51);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // PatientsBtn
            // 
            PatientsBtn.Location = new Point(12, 69);
            PatientsBtn.Name = "PatientsBtn";
            PatientsBtn.Size = new Size(125, 51);
            PatientsBtn.TabIndex = 2;
            PatientsBtn.Text = "Patients";
            PatientsBtn.UseVisualStyleBackColor = true;
            PatientsBtn.Click += PatientsBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 403);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 51);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CmasDoctorAdvice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 466);
            Controls.Add(BackBtn);
            Controls.Add(PatientsBtn);
            Controls.Add(HomeBtn);
            Controls.Add(DgAdvice);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CmasDoctorAdvice";
            Text = "CmasDoctorAdvice";
            ((System.ComponentModel.ISupportInitialize)DgAdvice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgAdvice;
        private Button HomeBtn;
        private Button PatientsBtn;
        private Button BackBtn;
    }
}