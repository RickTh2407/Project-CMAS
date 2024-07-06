namespace WinFormsApp1
{
    partial class CmasDoctorRapport
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
            PatientsBtn = new Button();
            HomeBtn = new Button();
            BackBtn = new Button();
            DgPatients = new DataGridView();
            PbGraph = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DgPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbGraph).BeginInit();
            SuspendLayout();
            // 
            // PatientsBtn
            // 
            PatientsBtn.Location = new Point(12, 68);
            PatientsBtn.Name = "PatientsBtn";
            PatientsBtn.Size = new Size(125, 51);
            PatientsBtn.TabIndex = 2;
            PatientsBtn.Text = "Patients";
            PatientsBtn.UseVisualStyleBackColor = true;
            PatientsBtn.Click += PatientsBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(12, 11);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(125, 51);
            HomeBtn.TabIndex = 1;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 403);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 51);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // DgPatients
            // 
            DgPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPatients.Location = new Point(191, 11);
            DgPatients.Name = "DgPatients";
            DgPatients.Size = new Size(422, 442);
            DgPatients.TabIndex = 7;
            DgPatients.CellContentClick += DgPatients_CellContentClick;
            // 
            // PbGraph
            // 
            PbGraph.Location = new Point(662, 11);
            PbGraph.Name = "PbGraph";
            PbGraph.Size = new Size(260, 247);
            PbGraph.TabIndex = 8;
            PbGraph.TabStop = false;
            PbGraph.Click += PbGraph_Click;
            // 
            // CmasDoctorRapport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 466);
            Controls.Add(PbGraph);
            Controls.Add(DgPatients);
            Controls.Add(BackBtn);
            Controls.Add(HomeBtn);
            Controls.Add(PatientsBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CmasDoctorRapport";
            Text = "CmasDoctorRapport";
            ((System.ComponentModel.ISupportInitialize)DgPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbGraph).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PatientsBtn;
        private Button HomeBtn;
        private Button BackBtn;
        private DataGridView DgPatients;
        private PictureBox PbGraph;
    }
}