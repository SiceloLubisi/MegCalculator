using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegCalculator
{
    public partial class megCalculator : Form
    {

        Double value = 0;
        String operation = "";
        bool operationSelected = false;

        public megCalculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operationSelected))
                txtResult.Clear();

            operationSelected = false; 
            Button b = (Button)sender; // Casting the object to different data type
            if (b.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + b.Text;
            }
            else;
            txtResult.Text = txtResult.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0"; 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }
        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                button18.PerformClick();
                operation = b.Text;
                labelCurrentOperation.Text = value + " " + operation;
                operationSelected = true;
            }
            else
            {
       
                operation = b.Text;
                value = Double.Parse(txtResult.Text);
                labelCurrentOperation.Text = value + " " + operation; 
                operationSelected = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break; 
            }//End switch
            // operationSelected = false;
            value = Double.Parse(txtResult.Text);
            labelCurrentOperation.Text = ""; 
        }

        
    }
}
