using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SubmitAll_Click(object sender, EventArgs e)
        {
            double MyCashConvert; // declares local var
            MyCashConvert = Convert.ToDouble(InputMyCash.Text); //converts string to value

            double GasExpenseConvert; //declares local var
            GasExpenseConvert = Convert.ToDouble(InputGasExpense.Text);// Converts string to value
            double MaxGasExpenseConvert;//declares local var
            MaxGasExpenseConvert = Convert.ToDouble(MaxGasExpense.Text);// Converts string to value
            double CurrentGasAddition;// declares local var
            CurrentGasAddition = Convert.ToDouble(CurrentGasFill.Text);// Converts string to value

            double FoodExpenseConvert; //declares local var 
            FoodExpenseConvert = Convert.ToDouble(InputFoodExpense.Text);// Converts string to value
            double MaxFoodExpenseConvert;// declares local var
            MaxFoodExpenseConvert = Convert.ToDouble(MaxFoodExpense.Text);// Converts string to value
            double CurrentFoodAddition;// declares local var
            CurrentFoodAddition = Convert.ToDouble(CurrentFoodFill.Text);// Converts string to value

            double RentExpenseConvert;//declares local var 
            RentExpenseConvert = Convert.ToDouble(InputRentExpense.Text);// Converts string to value
            double MaxRentExpenseConvert;//declares local var 
            MaxRentExpenseConvert = Convert.ToDouble(MaxRentExpense.Text);// Converts string to value
            double CurrentRentAddition;//declares local var 
            CurrentRentAddition = Convert.ToDouble(CurrentRentFill.Text);// Converts string to value

            double OtherExpenseConvert;//declares local var 
            OtherExpenseConvert = Convert.ToDouble(InputOtherExpense.Text);// Converts string to value
            double MaxOtherExpenseConvert;//declares local var 
            MaxOtherExpenseConvert = Convert.ToDouble(MaxOtherExpense.Text);// Converts string to value
            double CurrentOtherAddition;//declares local var 
            CurrentOtherAddition = Convert.ToDouble(CurrentOtherFill.Text);// Converts string to value


            if (CurrentGasAddition + GasExpenseConvert <= MaxGasExpenseConvert)// As long as the current expenses is less than the max allocation but greater than zero, then true
                {
               
                    CurrentGasFill.Text = Convert.ToString(GasExpenseConvert + CurrentGasAddition);// Displays current gas expenses amounted
                }

            if (CurrentFoodAddition + FoodExpenseConvert <= MaxFoodExpenseConvert )// As long as the current expenses is less than the max allocation but greater than zero, then true
                {
                    CurrentFoodFill.Text = Convert.ToString(FoodExpenseConvert + CurrentFoodAddition); // Displays current food expenses amounted
                }

            if(CurrentRentAddition + RentExpenseConvert <= MaxRentExpenseConvert )// As long as the current expenses is less than the max allocation but greater than zero, then true
            {
                    CurrentRentFill.Text = Convert.ToString(RentExpenseConvert + CurrentRentAddition);// Displays current rent expenses amounted
                }

            if (CurrentOtherAddition + OtherExpenseConvert <= MaxOtherExpenseConvert )// As long as the current expenses is less than the max allocation but greater than zero, then true
            {
                CurrentOtherFill.Text = Convert.ToString(OtherExpenseConvert + CurrentOtherAddition); //Displays current rent expense amounted
            }

            if (CurrentGasAddition + GasExpenseConvert <= MaxGasExpenseConvert || CurrentFoodAddition + FoodExpenseConvert <= MaxFoodExpenseConvert || CurrentRentAddition + RentExpenseConvert <= MaxRentExpenseConvert || CurrentOtherAddition + OtherExpenseConvert <= MaxOtherExpenseConvert) //once budget reaches max it becomes false, and when all budget reaches the max then it won't run.
            {
                if (CurrentGasAddition + GasExpenseConvert > MaxGasExpenseConvert) //once it caps make the gas expense 0 so that it wont be added when new calculations occur
                    {
                        GasExpenseConvert = 0;
                    }
                if(CurrentFoodAddition + FoodExpenseConvert > MaxFoodExpenseConvert)//once it caps make the food expense 0 so that it wont be added when new calculations occur
                {
                        FoodExpenseConvert = 0;
                    }
                if(CurrentRentAddition + RentExpenseConvert > MaxRentExpenseConvert)//once it caps make the rent expense 0 so that it wont be added when new calculations occur
                {
                        RentExpenseConvert = 0;
                    }
                if(CurrentOtherAddition + OtherExpenseConvert > MaxOtherExpenseConvert)//once it caps make the other expense 0 so that it wont be added when new calculations occur
                {
                        OtherExpenseConvert = 0;
                    }
                InputMyCash.Text = Convert.ToString(MyCashConvert - GasExpenseConvert - FoodExpenseConvert - RentExpenseConvert - OtherExpenseConvert); // totalcash = currentcash - budgetexpenses
              
            }
           
        }
        private void InputMyCash_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputFoodExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void MaxFoodExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void CurrentFoodFill_Click(object sender, EventArgs e)
        {

        }

        private void InputGasExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void MaxGasExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void CurrentGasFill_Click(object sender, EventArgs e)
        {

        }

        private void InputRentExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void MaxRentExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void CurrentRentFill_Click(object sender, EventArgs e)
        {

        }

        private void InputOtherExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void MaxOtherExpense_TextChanged(object sender, EventArgs e)
        {

        }
        private void CurrentOtherFill_Click(object sender, EventArgs e)
        {

        }




















        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void divider_Click(object sender, EventArgs e)
        {

        }

       
    }
}
