using System;
using System.Windows.Forms;

namespace FlightBookingProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if (user == "alexandru" && pass == "test")
            {
                FlightBooking fForm = new FlightBooking();
                fForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
