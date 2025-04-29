using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlersGroupProject1
{
    public partial class frmPlayerStats : Form
    {
        public frmPlayerStats()
        {
            InitializeComponent();
        }
    }

    //so my idea for this is that the user will select if they want to view the player's overall stats or view stats by game. If they select overall, then the "please select a game" label and textbox will be set to invisible, as well as the team scores, opposing team, game date, vs., and win/loss labels
    //if the user selects view by game, then all the labels will be visible, and they must select a game from the combo box to see the stats
    //and the win/loss label will change to either green if it says win, or red if it's a loss
    //I also want for the picture box and the form background to populate based on which player is selected when the form opens- so the picture box will have a pic of the player, and hopefully we can have the background be like the team logo or something
}
