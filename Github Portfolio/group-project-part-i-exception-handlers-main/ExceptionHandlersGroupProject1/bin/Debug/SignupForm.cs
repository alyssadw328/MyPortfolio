// Exception Handler Group Project
// 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlersGroupProject1
{
    public partial class SignupForm : Form
    {
        SqlCommand sqlCMD;
        SqlConnection conn;
        SqlDataReader rdr;

        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginAuthenticationDatabase.mdf;Integrated Security=True;Encrypt=False");
            conn.Open();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            // if-else statement to check/confirm username and password
            if (usernameTextBox.Text != string.Empty || createPasswordTextBox.Text != string.Empty || confirmPasswordTextBox.Text != string.Empty)
            {
                if (createPasswordTextBox.Text == confirmPasswordTextBox.Text)
                {
                    sqlCMD = new SqlCommand("select * FROM LoginAuthenticationTable WHERE username='" + usernameTextBox.Text + "'", conn);

                    rdr = sqlCMD.ExecuteReader();

                    if (rdr.Read())
                    {
                        rdr.Close();

                        // display error message
                        MessageBox.Show("WARNING! Username already exists. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        rdr.Close();
                        sqlCMD = new SqlCommand("insert into LoginAuthenticationTable (username, password) values(@username,@password)", conn);

                        sqlCMD.Parameters.AddWithValue("username", usernameTextBox.Text);

                        sqlCMD.Parameters.AddWithValue("password", createPasswordTextBox.Text);

                        sqlCMD.ExecuteNonQuery();

                        MessageBox.Show("Account created. You can now login.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Passwords MUST match! Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Invalid entry. Please enter value in all fields to continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginNowButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginForm loginForm = new loginForm();

            loginForm.ShowDialog();
        }       
    }
}
