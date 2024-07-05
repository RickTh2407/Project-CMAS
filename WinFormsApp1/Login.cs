namespace WinFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientHome home = new PatientHome();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
