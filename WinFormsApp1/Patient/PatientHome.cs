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
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientResults patientResults = new PatientResults();
            patientResults.Show();
        }

        private void AdviceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientAdvice patientAdvice = new PatientAdvice();
            patientAdvice.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientStartTest patient = new PatientStartTest();
            patient.Show();
        }
    }
}
