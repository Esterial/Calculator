using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            textBoxResult.Text =
            (Convert.ToInt32(textBoxOperand1.Text.ToString()) +
            Convert.ToInt32(textBoxOperand2.Text.ToString())).ToString();

        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            textBoxResult.Text =
            (Convert.ToInt32(textBoxOperand1.Text.ToString()) -
            Convert.ToInt32(textBoxOperand2.Text.ToString())).ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            textBoxResult.Text =
            (Convert.ToInt32(textBoxOperand1.Text.ToString()) *
            Convert.ToInt32(textBoxOperand2.Text.ToString())).ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            textBoxResult.Text =
            (Convert.ToInt32(textBoxOperand1.Text.ToString()) /
            Convert.ToInt32(textBoxOperand2.Text.ToString())).ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
