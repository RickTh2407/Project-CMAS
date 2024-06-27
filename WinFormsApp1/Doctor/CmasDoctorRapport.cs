using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CmasDoctorRapport : Form
    {
        public CmasDoctorRapport()
        {
            InitializeComponent();
        }

        private void adviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorAdvice advice = new CmasDoctorAdvice();
            advice.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cmas_Doctor_Home home = new Cmas_Doctor_Home();
            home.Show();
            this.Close();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorPatient patient = new CmasDoctorPatient();
            patient.Show();
            this.Close();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorResult result = new CmasDoctorResult();
            result.Show();
            this.Close();
        }

        private void exerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorRapport rapport = new CmasDoctorRapport();
            rapport.Show();
            this.Close();
        }

        private void exerciseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CmasDoctorExercises exercise = new CmasDoctorExercises();
            exercise.Show();
            this.Close();
        }
    }
}
