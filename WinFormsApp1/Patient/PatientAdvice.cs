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
    public partial class PatientAdvice : Form
    {
        public PatientAdvice()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome patientHome = new PatientHome();
            patientHome.Show();
        }

        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientStartTest patientStartTest = new PatientStartTest();
            patientStartTest.Show();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientResults result = new PatientResults();
            result.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome patientHome = new PatientHome();
            patientHome.Show();
        }
    }
}
