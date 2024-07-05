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
    public partial class PatientTask : Form
    {
        public PatientTask()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome home = new PatientHome();
            home.Show();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientResults results = new PatientResults();
            results.Show();
        }

        private void AdviceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientAdvice advice = new PatientAdvice();
            advice.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome home = new PatientHome();
            home.Show();
        }
    }
}
