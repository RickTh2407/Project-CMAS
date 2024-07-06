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
    public partial class CmasDoctorPatient : Form
    {
        public CmasDoctorPatient()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Cmas_Doctor_Home home = new Cmas_Doctor_Home();
            home.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Cmas_Doctor_Home home = new Cmas_Doctor_Home();
            home.Show();
            this.Close();
        }

        private void DgPatientOverview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
