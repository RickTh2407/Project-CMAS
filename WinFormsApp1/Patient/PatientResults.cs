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
    public partial class PatientResults : Form
    {
        public PatientResults()
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

        private void AdviceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientAdvice patientAdvice = new PatientAdvice();
            patientAdvice.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome patientHome = new PatientHome();
            patientHome.Show();
        }
    }
}
