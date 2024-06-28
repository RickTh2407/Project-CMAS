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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            patientToolStripMenuItem = new ToolStripMenuItem();
            resultToolStripMenuItem = new ToolStripMenuItem();
            adviceToolStripMenuItem = new ToolStripMenuItem();
            exerciseToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, patientToolStripMenuItem, resultToolStripMenuItem, adviceToolStripMenuItem, exerciseToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(68, 24);
            patientToolStripMenuItem.Text = "Patient";
            patientToolStripMenuItem.Click += patientToolStripMenuItem_Click;
            // 
            // resultToolStripMenuItem
            // 
            resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            resultToolStripMenuItem.Size = new Size(63, 24);
            resultToolStripMenuItem.Text = "Result";
            resultToolStripMenuItem.Click += resultToolStripMenuItem_Click;
            // 
            // adviceToolStripMenuItem
            // 
            adviceToolStripMenuItem.Name = "adviceToolStripMenuItem";
            adviceToolStripMenuItem.Size = new Size(68, 24);
            adviceToolStripMenuItem.Text = "Advice";
            adviceToolStripMenuItem.Click += adviceToolStripMenuItem_Click;
            // 
            // exerciseToolStripMenuItem1
            // 
            exerciseToolStripMenuItem1.Name = "exerciseToolStripMenuItem1";
            exerciseToolStripMenuItem1.Size = new Size(76, 24);
            exerciseToolStripMenuItem1.Text = "Exercise";
            exerciseToolStripMenuItem1.Click += exerciseToolStripMenuItem1_Click;
            // 
            // CmasDoctorRapport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CmasDoctorRapport";
            Text = "CmasDoctorRapport";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem resultToolStripMenuItem;
        private ToolStripMenuItem adviceToolStripMenuItem;
        private ToolStripMenuItem exerciseToolStripMenuItem1;
    }
}