namespace WinFormsApp1
{
    partial class Cmas_Doctor_Home
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
            DgNotifications = new DataGridView();
            PatientsBtn = new Button();
            LogOutBtn = new Button();
            WelcomeText = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)DgNotifications).BeginInit();
            SuspendLayout();
            // 
            // DgNotifications
            // 
            DgNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgNotifications.Location = new Point(535, 12);
            DgNotifications.Name = "DgNotifications";
            DgNotifications.Size = new Size(387, 442);
            DgNotifications.TabIndex = 0;
            DgNotifications.CellContentClick += DgNotifications_CellContentClick;
            // 
            // PatientsBtn
            // 
            PatientsBtn.Location = new Point(12, 12);
            PatientsBtn.Name = "PatientsBtn";
            PatientsBtn.Size = new Size(125, 51);
            PatientsBtn.TabIndex = 1;
            PatientsBtn.Text = "Patients";
            PatientsBtn.UseVisualStyleBackColor = true;
            PatientsBtn.Click += PatientsBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Location = new Point(12, 403);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(125, 51);
            LogOutBtn.TabIndex = 3;
            LogOutBtn.Text = "Log out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // WelcomeText
            // 
            WelcomeText.Location = new Point(210, 12);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(240, 219);
            WelcomeText.TabIndex = 4;
            WelcomeText.Text = "";
            WelcomeText.TextChanged += WelcomeText_TextChanged;
            // 
            // Cmas_Doctor_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 466);
            Controls.Add(WelcomeText);
            Controls.Add(LogOutBtn);
            Controls.Add(PatientsBtn);
            Controls.Add(DgNotifications);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cmas_Doctor_Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)DgNotifications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgNotifications;
        private Button PatientsBtn;
        private Button LogOutBtn;
        private RichTextBox WelcomeText;
    }
}