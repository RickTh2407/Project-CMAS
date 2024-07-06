namespace WinFormsApp1
{
    partial class CmasDoctorExercises
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
            DgExercise = new DataGridView();
            HomeBtn = new Button();
            PatientsBtn = new Button();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DgExercise).BeginInit();
            SuspendLayout();
            // 
            // DgExercise
            // 
            DgExercise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgExercise.Location = new Point(165, 12);
            DgExercise.Name = "DgExercise";
            DgExercise.Size = new Size(757, 442);
            DgExercise.TabIndex = 1;
            DgExercise.CellContentClick += DgExercise_CellContentClick;
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
            PatientsBtn.Location = new Point(12, 70);
            PatientsBtn.Name = "PatientsBtn";
            PatientsBtn.Size = new Size(125, 51);
            PatientsBtn.TabIndex = 2;
            PatientsBtn.Text = "Patients";
            PatientsBtn.UseVisualStyleBackColor = true;
            PatientsBtn.Click += PatientsBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 402);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 51);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CmasDoctorExercises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 466);
            Controls.Add(BackBtn);
            Controls.Add(PatientsBtn);
            Controls.Add(HomeBtn);
            Controls.Add(DgExercise);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CmasDoctorExercises";
            Text = "CmasDoctorExercises";
            ((System.ComponentModel.ISupportInitialize)DgExercise).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView DgExercise;
        private Button HomeBtn;
        private Button PatientsBtn;
        private Button BackBtn;
    }
}