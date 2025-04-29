using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Alyssa Walker
//CPT 185-A80H
//Final Project- Calculator

namespace A_Walker_CPT_185_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //allow the form to accept keystrokes as input
            this.KeyPreview = true;
            this.KeyDown += Key;
        }

        //initialize variables and create list to hold numbers
        string outputValue = "0";
        char numOperator = ' ';
        List<decimal> numbers = new List<decimal>();
        bool alreadyCalculated = false;

        //create method for additon
        public void Add()
        {
            //add the number entered (output variable) to the numbers list
            numbers.Add(decimal.Parse(outputValue));
            //then reset the output variable
            outputValue = "0";
            //assign plus sign to operator variable
            numOperator = '+';
            //clear the output label for next number to be entered
            lblOutput.Text = string.Empty;
        }

        //create method for subtraction
        public void Subtract()
        {
            //add output variable to numbers list
            numbers.Add(decimal.Parse(outputValue));
            //reset output variable
            outputValue = "0";
            //assign minus sign to operator variable
            numOperator = '-';
            //clear output label
            lblOutput.Text = string.Empty;
        }

        //create method for multiplication
        public void Multiply()
        {
            //add output variable to numbers list
            numbers.Add(decimal.Parse(outputValue));
            //reset output variable
            outputValue = "0";
            //assign multiplication sign to operator variable
            numOperator = '*';
            //clear output label
            lblOutput.Text = string.Empty;
        }

        //create method for division
        public void Divide()
        {
            //add output variable to numbers list
            numbers.Add(decimal.Parse(outputValue));
            //reset output variable
            outputValue = "0";
            //assign divsion sign to operator variable
            numOperator = '/';
            //clear output label
            lblOutput.Text = string.Empty;
        }

        //alternately allowing the user to use key clicks to multiply and divide
        public void Key(object sender, KeyEventArgs e)
        {
            //if * key is pressed
            if (e.KeyCode == Keys.D8 && e.Shift)
            {
                //call multiply method
                Multiply();
            }
            //if / key is pressed (same button as the ? button)
            if (e.KeyCode == Keys.OemQuestion) 
            { 
                //call divide method
                Divide();
            }
            //puts focus on the = button so it will calculate the total if the enter key is pressed
            btnEquals.Focus();
        }

        //create method for squaring
        public void Square() 
        {
            //add output variable to numbers list
            numbers.Add(decimal.Parse(outputValue));
            //reset output variable
            outputValue = "0";
            //assign divsion sign to operator variable
            numOperator = '2';
            //clear output label
            lblOutput.Text = string.Empty;
        }

        //create method for percent
        public void Percent() 
        {
            //add the output variable to the numbers list
            numbers.Add(decimal.Parse(outputValue));
            //then reset the output variable
            outputValue = "0";
            //assign percent sign to operator variable
            numOperator = '%';
            //clear the output label for next number to be entered
            lblOutput.Text = string.Empty;
        }

        //create method for square root
        public void Sqrt() 
        {
            //add the output variable to the numbers list
            numbers.Add(decimal.Parse(outputValue));
            //then reset the output variable
            outputValue = "0";
            //assign sqrt sign to operator variable
            numOperator = '√';
            //clear the output label for next number to be entered
            lblOutput.Text = string.Empty;
        }

        //create method for exponents
        public void Exp() 
        {
            //add the output variable to the numbers list
            numbers.Add(decimal.Parse(outputValue));
            //then reset the output variable
            outputValue = "0";
            //assign power symbol to operator variable
            numOperator = '^';
            //clear the output label for next number to be entered
            lblOutput.Text = string.Empty;
        }

        //create method for reciprocal
        public void Reciprocal() 
        {
            //add the output variable to the numbers list
            numbers.Add(decimal.Parse(outputValue));
            //then reset the output variable
            outputValue = "0";
            //assign percent sign to operator variable
            numOperator = 'r';
            //clear the output label for next number to be entered
            lblOutput.Text = string.Empty;
        }

        //set output variable equal to number of button clicked
        //if output variable already contains a number, concatenate it with the number of the button clicked to form a new number
        //display the output variable in the output label
        private void btn7_Click(object sender, EventArgs e)
        {
            if (outputValue == "0") 
            {
                outputValue = "7";
            }
            else 
            { 
                outputValue = outputValue + "7";
            }

            lblOutput.Text = outputValue;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "8";
            }
            else
            {
                outputValue = outputValue + "8";
            }

            lblOutput.Text = outputValue;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "9";
            }
            else
            {
                outputValue = outputValue + "9";
            }

            lblOutput.Text = outputValue;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "4";
            }
            else
            {
                outputValue = outputValue + "4";
            }

            lblOutput.Text = outputValue;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "5";
            }
            else
            {
                outputValue = outputValue + "5";
            }

            lblOutput.Text = outputValue;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "6";
            }
            else
            {
                outputValue = outputValue + "6";
            }

            lblOutput.Text = outputValue;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "1";
            }
            else
            {
                outputValue = outputValue + "1";
            }

            lblOutput.Text = outputValue;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "2";
            }
            else
            {
                outputValue = outputValue + "2";
            }

            lblOutput.Text = outputValue;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                outputValue = "3";
            }
            else
            {
                outputValue = outputValue + "3";
            }

            lblOutput.Text = outputValue;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (outputValue == "0")
            {
                //no change- output is already 0
            }
            else
            {
                outputValue = outputValue + "0";
            }

            lblOutput.Text = outputValue;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //Error message if more than 1 decimal clicked in the same number
            if (outputValue.Contains(".")) 
            {
                MessageBox.Show("Number cannot contain multiple decimals.");
            }
            else 
            { 
                //put a decimal in the number if nome already present
                outputValue = outputValue + ".";  
            }
            //display the output value
            lblOutput.Text = outputValue;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //set output equal to pi
            outputValue = Math.PI.ToString();
            //display output
            lblOutput.Text = outputValue;
            //create and open the pi joke form (just for fun)
            Pi piJoke = new Pi();
            piJoke.Show();
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            //parse the output value into a decimal and change the sign of the number
            outputValue = (-decimal.Parse(outputValue)).ToString();
            //display the output value
            lblOutput.Text = outputValue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the output variable and the label displaying it
            outputValue = "0";
            lblOutput.Text = outputValue;
            //clear the numbers list
            numbers.Clear();
            //reset the already calculated variable
            alreadyCalculated = false;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {//Addition
            //call add method
            Add();
        }
        private void btnSubtraction_Click(object sender, EventArgs e)
        {//Subtraction
            //call subtract method
            Subtract();
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {//Multiplication
            //call mutliply method
            Multiply();
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {//Division
            //call divide method
            Divide();
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {//Squaring
            //call square method
            Square();
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {//Percentage
            //call percent method
            Percent();
        }
        private void btnSqrRoot_Click(object sender, EventArgs e)
        {//Square root
            //call sqrt method
            Sqrt();
        }
        private void btnExponent_Click(object sender, EventArgs e)
        {//Exponent
            //call exp method
            Exp();
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {//Reciprocal
            //call reciprocal method
            Reciprocal();
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {//Calculate total
            //add output variable to numbers list
            numbers.Add(decimal.Parse(outputValue));
            
            //calculate for addition
            if (numOperator == '+') 
            {
                //sum the numbers in the list and convert to string
                outputValue = numbers.Sum().ToString();
            }
           
            //calculate for subtraction
            else if (numOperator == '-') 
            {
                //create a total variable and set it equal to the first number entered
                decimal total = numbers[0];
                //loop through each of the remaining numbers
                for (int i = 1; i < numbers.Count; i++) 
                {
                    //set the total equal to the first number minus each of the remaining numbers in the list
                    total -= numbers[i];
                }
                //convert total to string and set it equal to the output variable
                outputValue = total.ToString();
            }
            
            //calculate for multiplication
            else if (numOperator == '*') 
            {
                //create a total variable and set it equal to 1 (to multiply everything by 1)
                decimal total = 1;
                //loop through each of the numbers
                for (int i = 0; i < numbers.Count; i++) 
                { 
                    //set the total equal to the initial total (1) times each of the other numbers
                    total *= numbers[i];
                }
                //convert total to string and set it equal to the output variable
                outputValue = total.ToString();
            }
            
            //calculate for division
            else if (numOperator == '/') 
            {
                //create a total variable and set it equal to the first number entered
                decimal total = numbers[0];
                //loop through each of the remaining numbers
                for (int i = 1;i < numbers.Count; i++) 
                { 
                    //only divide if number is not equal to zero
                    if (numbers[i] != 0) 
                    { 
                        //set total equal to first number divided by each of the remaining numbers
                        total /= numbers[i];  
                    }
                    else 
                    {
                        //Display error message if user tries to divide by zero
                        MessageBox.Show("Error: cannot divide by zero.");
                    }
                }
                //convert total to string and set it equal to the output variable
                outputValue= total.ToString();
            }
            
            //calculate for square
            else if (numOperator == '2') 
            {
                //create total variable and square the number entered
                decimal total = numbers[0] * numbers[0];
                //set total equal to output value
                outputValue = total.ToString();
            }
            
            //calculate for percentage
            else if (numOperator == '%')
            {
                //create a constant for percent
                const decimal percent = .01M;
                //create total variable and multiply the input number by percent variable
                decimal total = numbers[0] * percent;
                //set total as output value
                outputValue = total.ToString();
            }
            
            //calculate for square root
            else if (numOperator == '√') 
            {
                //create total variable and set it equal to sqare root of the number
                decimal total = (decimal)Math.Sqrt(double.Parse(numbers[0].ToString()));
                //set total as the output value
                outputValue = total.ToString();
            }
            
            //calculate for exponents
            else if (numOperator == '^') 
            {
                //only allow the equal button to be clicked once for this function
                if (alreadyCalculated == false) 
                { 
                    //create total variable and raise first number to the power of the second
                    double total = Math.Pow((double)numbers[0], (double)numbers[1]);
                    //show that the calculation has been done - cannot perform it again
                    alreadyCalculated = true;
                    //set total as the output value
                    outputValue= total.ToString();
                }
                else //do nothing if calculation is complete
                { return; }
                
            }
            
            //calculate for reciprocal
            else if (numOperator ==  'r') 
            {
                //create total variable and make it the reciprocal of the number entered
                decimal total = (1 / numbers[0]);
                //set the total as the output value
                outputValue = total.ToString();
                
            }

            //display output variable in the output label
            lblOutput.Text = outputValue;
            //clear the numbers list for use in any other calculatiosn
            numbers.Clear();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
