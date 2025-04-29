using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Sports Statistics Application
//Group Project 1 - Exception Handlers
//Ryan Chang, Jared Daniels, Donn Gerald, Josh Pitts, Alyssa Walker
//CPT-206-A80S

namespace ExceptionHandlersGroupProject1
{
    public partial class formDashboard : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["AccessDB"].ConnectionString;
        public formDashboard()
        {
            InitializeComponent();
        }

        // Search for team stats
        private void btnSearchTeam_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxTeam.Text.Trim(); // Get user input from textbox
            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a team name.");
                return;
            }

            // Modify query to search for the team in the correct table and retrieve necessary fields
            string query = "SELECT TeamName, Wins, Losses FROM Teams WHERE TeamName LIKE @search";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Retrieve team data
                    string teamName = dataTable.Rows[0]["TeamName"].ToString();
                    int wins = Convert.ToInt32(dataTable.Rows[0]["Wins"]);
                    int losses = Convert.ToInt32(dataTable.Rows[0]["Losses"]);

                    // Pass data to frmTeamStats
                    frmTeamStats frm = new frmTeamStats(teamName, wins, losses);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Team not found. Please try again.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nBAStatsDBDataSet1.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.nBAStatsDBDataSet1.Games);

        }
    }
}
