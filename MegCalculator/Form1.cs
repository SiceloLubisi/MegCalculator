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
        public megCalculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1"; 
        }
    }
}
