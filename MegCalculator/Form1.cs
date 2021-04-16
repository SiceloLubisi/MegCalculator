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

        double value = 0;
        string operation = "";
        bool operationSelected = false;

        public megCalculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0")||(operationSelected))
                txtResult.Clear(); 
            
            //Created one handler that retrieves numbers from the labels
            Button b = (Button)sender; // Casting the object to different data type
            txtResult.Text = txtResult.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0"; 
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtResult.Text);
            operationSelected = true; 
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
            operationSelected = false; 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            value = 0; 
        }
    }
}
