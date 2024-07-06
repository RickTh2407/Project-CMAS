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
    public partial class CmasDoctorResult : Form
    {
        public CmasDoctorResult()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Cmas_Doctor_Home home = new Cmas_Doctor_Home();
            home.Show();
            this.Close();
        }

        private void PatientsBtn_Click(object sender, EventArgs e)
        {
            CmasDoctorPatient patients = new CmasDoctorPatient();
            patients.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            CmasDoctorRapport rapport = new CmasDoctorRapport();
            rapport.Show();
            this.Close();
        }

        private void DgResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
