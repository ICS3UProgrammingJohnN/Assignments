/*
 * Created by: John Ngundeng
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Assignment #3b - PizzaCost
 * This program Calculates the price of a pizza in different states
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostJohnN
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
            // hiding the the total price from the user
            grbReceipt.Hide();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            // declaring local variables and constants
            int numOfPizzas;
            const int MEDIUM = 1;
            const int LARGE = 2;
            const int EXTRALARGE = 3;
            double pizzaSize, subTotal, HST, numOfToppings, totalCost;

            

            // converting the text in the text boxes into ints
            numOfPizzas = int.Parse(txtNumberOfPizzas.Text);
            numOfToppings = double.Parse(txtToppings.Text);


            // assigning the pizza size to the variable 
            if (radMediumPizza.Checked = true)
            {
                pizzaSize = MEDIUM;
            }
            else if (radLargePizza.Checked = true)
            {
                pizzaSize = LARGE;
            }
            else if (radExtraLargePizza.Checked = true)
            {
                pizzaSize = EXTRALARGE;
            }
            else
                pizzaSize = 0;

            // setting the price of the pizza at different sizes 
            if (pizzaSize == MEDIUM)
            {
                pizzaSize = 6.99;
            }
            else if (pizzaSize == LARGE)
            {
                pizzaSize = 9.99;
            }
            else
            {
                pizzaSize = 12.99;
            }

            // setting the price of the toppinggs at different amounts  
            if (numOfToppings == 1)
            {
                numOfToppings = 0.75;
            }
            else if (numOfToppings == 2)
            {
                numOfToppings = 1.35;
            }
            else if (numOfToppings == 3)
            {
                numOfToppings = 2.15;
            }
            else if (numOfToppings == 4)
            {
                numOfToppings = 2.75;
            }
            else if (numOfToppings == 5)
            {
                numOfToppings = 3.25;
            }
            else
            {
                numOfToppings = 0;
            }
            // calculating the cost of the pizzas
            subTotal = (pizzaSize + numOfToppings) * numOfPizzas;
            HST = subTotal * 0.13;
            totalCost = subTotal + HST;

            // converting the doubles into strings 
            HST = Convert.ToDouble(String.Format("{0:0.00}", HST));
            subTotal = Convert.ToDouble(String.Format("{0:0.00}", subTotal));
            totalCost = Convert.ToDouble(String.Format("{0:0.00}", totalCost));

            // converting the doubles into strings 
            lblHSTAnswer.Text = "$ " + Convert.ToString(HST);
            lblSubTotalAnswer.Text ="$ " + Convert.ToString(subTotal);
            lblTotalCostAnswer.Text ="$ " + Convert.ToString(totalCost);

            // showing the recept to the customer 
            grbReceipt.Show();
        }
    }
}              
