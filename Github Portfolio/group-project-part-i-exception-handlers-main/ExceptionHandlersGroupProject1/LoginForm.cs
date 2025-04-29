using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExceptionHandlersGroupProject1
{
    public partial class loginForm : Form
    {
        SqlCommand sqlCMD;
        SqlConnection conn;
        SqlDataReader rdr;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LoginAuthenticationDatabase.mdf;Integrated Security=True;Encrypt=False");
            conn.Open();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // if-else statement to confirm username/password
            if (usernameTextBox.Text != string.Empty || passwordTextBox.Text != string.Empty)
            {
                sqlCMD = new SqlCommand("select * FROM LoginAuthenticationTable WHERE username='" + usernameTextBox.Text + "'and password='" + passwordTextBox.Text + "'", conn);

                rdr = sqlCMD.ExecuteReader();

                if (rdr.Read())
                {
                    rdr.Close();
                    this.Hide();
                    formDashboard formDashboard = new formDashboard();
                    formDashboard.ShowDialog();
                }

                else
                {
                    rdr.Close();
                    MessageBox.Show("No account exists with this username/password. Please try again or click to signup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please enter the correct values in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void signupLbl_Click(object sender, EventArgs e)
        {
            // Hides the label from user
            this.Hide();

            // Instance of SignupForm class created
            SignupForm signupForm = new SignupForm();

            // Display SignupForm
            signupForm.ShowDialog();    
        }

       

        
    }
}
