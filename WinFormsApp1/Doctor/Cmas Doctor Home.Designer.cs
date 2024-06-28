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
            PatientsButton = new Button();
            WelcomeBox = new TextBox();
            SuspendLayout();
            // 
            // PatientsButton
            // 
            PatientsButton.Location = new Point(12, 65);
            PatientsButton.Name = "PatientsButton";
            PatientsButton.Size = new Size(224, 109);
            PatientsButton.TabIndex = 0;
            PatientsButton.Text = "Patients";
            PatientsButton.UseVisualStyleBackColor = true;
            PatientsButton.Click += PatientsButton_Click;
            // 
            // WelcomeBox
            // 
            WelcomeBox.Location = new Point(343, 163);
            WelcomeBox.Name = "WelcomeBox";
            WelcomeBox.Size = new Size(258, 27);
            WelcomeBox.TabIndex = 1;
            WelcomeBox.Text = " ";
            WelcomeBox.TextChanged += WelcomeBox_TextChanged;
            // 
            // Cmas_Doctor_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(WelcomeBox);
            Controls.Add(PatientsButton);
            Name = "Cmas_Doctor_Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PatientsButton;
        private TextBox WelcomeBox;
    }
}