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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            patientToolStripMenuItem = new ToolStripMenuItem();
            rapportToolStripMenuItem = new ToolStripMenuItem();
            rapportToolStripMenuItem1 = new ToolStripMenuItem();
            adviceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, patientToolStripMenuItem, rapportToolStripMenuItem, rapportToolStripMenuItem1, adviceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(68, 24);
            patientToolStripMenuItem.Text = "Patient";
            // 
            // rapportToolStripMenuItem
            // 
            rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            rapportToolStripMenuItem.Size = new Size(63, 24);
            rapportToolStripMenuItem.Text = "Result";
            // 
            // rapportToolStripMenuItem1
            // 
            rapportToolStripMenuItem1.Name = "rapportToolStripMenuItem1";
            rapportToolStripMenuItem1.Size = new Size(77, 24);
            rapportToolStripMenuItem1.Text = "Rapport";
            // 
            // adviceToolStripMenuItem
            // 
            adviceToolStripMenuItem.Name = "adviceToolStripMenuItem";
            adviceToolStripMenuItem.Size = new Size(68, 24);
            adviceToolStripMenuItem.Text = "Advice";
            // 
            // CmasDoctorExercises
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CmasDoctorExercises";
            Text = "CmasDoctorExercises";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem rapportToolStripMenuItem;
        private ToolStripMenuItem rapportToolStripMenuItem1;
        private ToolStripMenuItem adviceToolStripMenuItem;
    }
}