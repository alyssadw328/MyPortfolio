using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWalker_Lab3
{
    public partial class Details : Form
    {
        private State state;
        public Details(State state) //accept the state object
        {
            InitializeComponent();
            this.state = state; //store the state object
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //allows new items to be saved
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uS_StatesDataSet);

        }

        private void Details_Load(object sender, EventArgs e)
        {
            
            //make sure state is not null
            if (state != null)
            {
                //fill all the details text boxes with info for the selected state
                stateIDTextBox.Text = state.StateID.ToString();
                stateNameTextBox.Text = state.StateName;
                populationTextBox.Text = state.Population;
                stateFlagTextBox.Text = state.StateFlag;
                stateFlowerTextBox.Text = state.StateFlower;
                stateBirdTextBox.Text = state.StateBird;
                stateColorsTextBox.Text = state.StateColors;
                largestCitiesTextBox.Text = state.LargestCities;
                stateCapitolTextBox.Text = state.StateCapitol;
                medianIncomeTextBox.Text = state.MedianIncome;
                computerJobsTextBox.Text = state.ComputerJobs;

            }
            else 
            {
                //error message if no state selected
                MessageBox.Show("Make sure a state is selected.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //exit the form
            this.Close();
        }
    }
}
