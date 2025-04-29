using System;
using System.IO;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace ExceptionHandlersGroupProject1
{
    public partial class frmTeamStats : Form
    {
        private string teamName;
        private int wins;
        private int losses;
        private string filePathBOS = "celtics logo.png";
        private string filePathLAL = "lakers logo.png";
        private string filePathNYK = "knicks logo.png";
        private string filePathMIN = "timberwolves logo.png";
        private string filePathCHO = "hornets logo.png";

        public frmTeamStats(string selectedTeam, int teamWins, int teamLosses)
        {
            InitializeComponent();
            teamName = selectedTeam;
            wins = teamWins;
            losses = teamLosses;

            // Update labels with team data
            lblTeamName.Text = teamName;
            lblWin.Text = $"Wins: {wins}";
            lblLoss.Text = $"Losses: {losses}";

            if (lblTeamName.Text == "BOS")
            {
                pictureBoxTeamLogo.BackgroundImage = Image.FromFile(filePathBOS);
            }
            else if (lblTeamName.Text == "LAL") 
            {
                pictureBoxTeamLogo.BackgroundImage = Image.FromFile(filePathLAL);
            }
            else if (lblTeamName.Text == "NYK")
            {
                pictureBoxTeamLogo.BackgroundImage = Image.FromFile(filePathNYK);
            }
            else if (lblTeamName.Text == "MIN")
            {
                pictureBoxTeamLogo.BackgroundImage = Image.FromFile(filePathMIN);
            }
            else if (lblTeamName.Text == "CHO")
            {
                pictureBoxTeamLogo.BackgroundImage = Image.FromFile(filePathCHO);
            }
        }
    }
}
