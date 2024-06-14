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
            menuStrip1 = new MenuStrip();
            patientToolStripMenuItem = new ToolStripMenuItem();
            resultToolStripMenuItem = new ToolStripMenuItem();
            rapportToolStripMenuItem = new ToolStripMenuItem();
            excerciseToolStripMenuItem = new ToolStripMenuItem();
            adviceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { patientToolStripMenuItem, resultToolStripMenuItem, rapportToolStripMenuItem, excerciseToolStripMenuItem, adviceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Navbar";
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
            // rapportToolStripMenuItem
            // 
            rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            rapportToolStripMenuItem.Size = new Size(77, 24);
            rapportToolStripMenuItem.Text = "Rapport";
            rapportToolStripMenuItem.Click += rapportToolStripMenuItem_Click;
            // 
            // excerciseToolStripMenuItem
            // 
            excerciseToolStripMenuItem.Name = "excerciseToolStripMenuItem";
            excerciseToolStripMenuItem.Size = new Size(83, 24);
            excerciseToolStripMenuItem.Text = "Excercise";
            excerciseToolStripMenuItem.Click += excerciseToolStripMenuItem_Click;
            // 
            // adviceToolStripMenuItem
            // 
            adviceToolStripMenuItem.Name = "adviceToolStripMenuItem";
            adviceToolStripMenuItem.Size = new Size(68, 24);
            adviceToolStripMenuItem.Text = "Advice";
            adviceToolStripMenuItem.Click += adviceToolStripMenuItem_Click;
            // 
            // Cmas_Doctor_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 621);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Cmas_Doctor_Home";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem resultToolStripMenuItem;
        private ToolStripMenuItem rapportToolStripMenuItem;
        private ToolStripMenuItem excerciseToolStripMenuItem;
        private ToolStripMenuItem adviceToolStripMenuItem;
    }
}