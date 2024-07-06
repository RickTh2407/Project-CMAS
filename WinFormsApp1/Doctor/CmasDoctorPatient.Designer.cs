namespace WinFormsApp1
{
    partial class CmasDoctorPatient
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
            DgPatientOverview = new DataGridView();
            HomeBtn = new Button();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DgPatientOverview).BeginInit();
            SuspendLayout();
            // 
            // DgPatientOverview
            // 
            DgPatientOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPatientOverview.Location = new Point(248, 12);
            DgPatientOverview.Name = "DgPatientOverview";
            DgPatientOverview.Size = new Size(674, 442);
            DgPatientOverview.TabIndex = 1;
            DgPatientOverview.CellContentClick += DgPatientOverview_CellContentClick;
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
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 403);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(125, 51);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CmasDoctorPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 466);
            Controls.Add(BackBtn);
            Controls.Add(HomeBtn);
            Controls.Add(DgPatientOverview);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CmasDoctorPatient";
            Text = "CmasDoctorPatient";
            ((System.ComponentModel.ISupportInitialize)DgPatientOverview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgPatientOverview;
        private Button HomeBtn;
        private Button BackBtn;
    }
}