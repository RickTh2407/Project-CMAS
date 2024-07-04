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

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            CmasDoctorPatient patient = new CmasDoctorPatient();
            patient.Show();
            this.Close();
        }

        private void WelcomeBox_TextChanged(object sender, EventArgs e)
        {
            WelcomeBox.AppendText("Welkom" + "Username\n");
        }
    }
}
