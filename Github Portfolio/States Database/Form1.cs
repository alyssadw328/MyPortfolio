using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;

namespace AWalker_Lab3
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView;
            
        public Form1()
        {
            InitializeComponent();
        }

        private void statesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Only allow new state entries that are not already included
            string newStateName = this.uS_StatesDataSet.States.Rows.Cast<DataRow>()
                                    .Where(row => row.RowState != DataRowState.Deleted)
                                    .Select(row => row["State Name"].ToString())
                                    .FirstOrDefault(name => name.Equals(comboBoxState.Text));

            if (!string.IsNullOrEmpty(newStateName))
            {
                //if a state with that name is found, display error message
                MessageBox.Show("This state already exists, please enter a different state.");
                return; 
            }

            //also make sure the user enters values for all columns before trying to save data for a new state
            bool entryAllowed = true;

            // Loop through every row in the table to check if any column is null or empty
            foreach (DataRow state in uS_StatesDataSet.States.Rows)
            {
                if (state["StateID"] == DBNull.Value ||
                    string.IsNullOrEmpty(state["State Name"].ToString()) ||
                    string.IsNullOrEmpty(state["Population (millions)"].ToString()) ||
                    string.IsNullOrEmpty(state["State Flag"].ToString()) ||
                    string.IsNullOrEmpty(state["State Flower"].ToString()) ||
                    string.IsNullOrEmpty(state["State Bird"].ToString()) ||
                    string.IsNullOrEmpty(state["State Colors"].ToString()) ||
                    string.IsNullOrEmpty(state["Largest Cities"].ToString()) ||
                    string.IsNullOrEmpty(state["State Capitol"].ToString()) ||
                    string.IsNullOrEmpty(state["Median Income"].ToString()))
                {
                    entryAllowed = false;
                    //set the bool to false if anything is null or empty
                    break;
                }
            }

            if (!entryAllowed)
            {
                // Display an error message if any column is left blank
                MessageBox.Show("All columns must contain a value to save a new state entry and must not already exist in the state list.");
            }
            else
            {
                // Only allow saving if all columns are filled and state is not already present
                this.Validate();
                this.statesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uS_StatesDataSet);
                MessageBox.Show("New state successfully added.");
            }
        }
 

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView = new DataGridView();
            this.Controls.Add(dataGridView);

            //load the data
            this.statesTableAdapter.Fill(this.uS_StatesDataSet.States);

            //connect the datagridview and combobox to the same binding source
            //this makes me want to cry because it won't work right
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.uS_StatesDataSet.States;
            dataGridView.DataSource = bindingSource;
            comboBoxState.DataSource = bindingSource;

            //display the state names in the combo box
            comboBoxState.DisplayMember = "State Name";
            
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //I had so many issues trying a bunch of different ways to pass the selected state in the combo box to the details form. But this one finally seems to work so fingers crossed it doesn't break everything again
            DataRowView selectedState = comboBoxState.SelectedItem as DataRowView;

            if (selectedState != null) //make sure a state is selected
            {
                //create a state object based on the selected state
                int stateID = (int)selectedState["StateID"];
                string stateName = selectedState["State Name"].ToString();
                string population = selectedState["Population (millions)"].ToString();
                string stateFlag = selectedState["State Flag"].ToString();
                string stateFlower = selectedState["State Flower"].ToString();
                string stateBird = selectedState["State Bird"].ToString();
                string stateColors = selectedState["State Colors"].ToString();
                string largestCities = selectedState["Largest Cities"].ToString();
                string stateCapitol = selectedState["State Capitol"].ToString();
                string medianIncome = selectedState["Median Income"].ToString();
                string computerJobs = selectedState["% of Computer-Related Jobs"].ToString();

                State state = new State(stateID, stateName, population, stateFlag, stateFlower, stateBird, stateColors, largestCities, stateCapitol, medianIncome, computerJobs);

                //create a details form and pass it the state object
                Details details = new Details(state);
                details.ShowDialog(); //open the form

            }
            else
            {
                //display error message if no state selected
                MessageBox.Show("Please choose a state to view.");
            }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //set the state search variable equal to the text entered into the text box
            string stateSearch = txtBoxSearch.Text;
            
            //make sure text is entered in order to search
            if (string.IsNullOrEmpty(stateSearch))
            {
                //display error message if no text entered
                MessageBox.Show("Please enter a state to search.");
                return;
            }
            else 
            {
                //Match the search to the state in the combo box
                var search = comboBoxState.Items.Cast<DataRowView>()
                                   .FirstOrDefault(item => item["State Name"].ToString().Equals(stateSearch));

                if (search != null)
                {
                    //set combo box equal to the search if there is a match
                    comboBoxState.SelectedItem = search;
                }
                else
                {
                    //if there is no match, display error message
                    MessageBox.Show("State not found.");
                }
            }
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To add a new state to the table, enter the state's information for all columns into a new row at the end of the table data grid. Press the enter key and then click the save icon to update the states table with your new information.");
        }
    }
}
