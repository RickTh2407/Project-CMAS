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
    public partial class Cmas_Doctor_Home : Form
    {
        public Cmas_Doctor_Home()
        {
            InitializeComponent();
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

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorRapport rapport = new CmasDoctorRapport();
            rapport.Show();
            this.Close();
        }

        private void excerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorExercises exercises = new CmasDoctorExercises();
            exercises.Show();
            this.Close();
        }

        private void adviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmasDoctorAdvice advice = new CmasDoctorAdvice();
            advice.Show();
            this.Close();
        }
    }
}
