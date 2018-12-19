/*
 * Created by: John Ngundeng
 * Created on: September 25 2018
 * Created for: ICS3U Programming
 * Assignment #2 - Falling objects
 * This program calculates how high the object will 
 * be after being dropped for certain time
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

namespace FallingObjectsJohnN
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
            //hiding the answer labels 
            this.lblHeight.Hide();
            this.lblHeightAnswer.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declaring local variable
            double time, height;

            // convert the string in the text box into a double
            time = double.Parse(txtTime.Text);

            // calculate the height
            height = 100 - 0.5 * 9.81 * Math.Pow(time, 2);
            
            // Got this line of code online 
            height = Convert.ToDouble(String.Format("{0:0.00}", height));

            //insert circumference into label
            this.lblHeightAnswer.Text = Convert.ToString(height) + "M";

            // display the hidden labels
            this.lblHeight.Show();
            this.lblHeightAnswer.Show();


        }
    }
}
