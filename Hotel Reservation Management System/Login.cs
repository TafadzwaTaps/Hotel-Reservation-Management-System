using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=HotelRoomReservation;Persist Security Info=True;User ID=sa;Password=Qwerty23;Encrypt=False;TrustServerCertificate=True");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from [User] where UserName= '" + UsernameTxtBox.Text + "' and PasswordHash= '" + PasswordTxtBox.Text + "'", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login successful, welcome master");
                Hide();
                HomePage home = new HomePage();
                home.Show();
            }
            else if (UsernameTxtBox.Text == "" && PasswordTxtBox.Text == "")
            {
                MessageBox.Show("please enter a username and password");
            }
            else if (UsernameTxtBox.Text == "")
            {
                MessageBox.Show("please enter a username");
            }
            else if (PasswordTxtBox.Text == "")
            {
                MessageBox.Show("please enter a password");
            }
            else
            {
                MessageBox.Show("wrong user name or password entered");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                PasswordTxtBox.PasswordChar = '\0';
            }
            else 
            {
                PasswordTxtBox.PasswordChar = '*';
            }
        }
    }
}
