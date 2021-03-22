using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "USD";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "MYR";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "YEN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.000069);
            }
            else if (radioButton2.Checked)
            {
                label5.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.00029);
            }
            else if (radioButton3.Checked)
            {
                label5.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * 0.0076);
            }
        }
    }
}
