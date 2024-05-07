using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtBox.Text == "" || EmailTxtBox.Text == "" || PasswordTxtBox.Text == "" || FirstNameTxtBox.Text == "" ||LastNameTxtBox.Text == "" || PhoneNumberTxtBox.Text == "" || PhysicalAddressTxtBox.Text == "" || UserRoleComboBox.Text == "")
            {
                MessageBox.Show("Missing information", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PhoneNumberTxtBox.Text.Length > 10 && PhoneNumberTxtBox.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                try
                {
                    SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Betlook;Integrated Security=True");
                    connection.Open();
                    if (MessageBox.Show("Are you sure you want to submit this data, please confirm before submitting", "Important Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query = "INSERT INTO User VALUES ('" + UsernameTxtBox.Text + "','" + EmailTxtBox.Text + "','" + PasswordTxtBox.Text + "','" + FirstNameTxtBox.Text + "','" + LastNameTxtBox.Text + "','" + PhoneNumberTxtBox.Text + "','" + PhysicalAddressTxtBox.Text + "','" + UserRoleComboBox.SelectedItem.ToString() + "')";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data successfully recorded", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        UsernameTxtBox.Clear();
                        EmailTxtBox.Clear();
                        PasswordTxtBox.Clear();
                        FirstNameTxtBox.Clear();
                        LastNameTxtBox.Clear();
                        PhoneNumberTxtBox.Clear();
                        PhysicalAddressTxtBox.Clear();
                        Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
