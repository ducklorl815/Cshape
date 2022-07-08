using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_MyClac : Form
    {
        public Homework_MyClac()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out double num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out double num2);
            if (isNum1 == false || isNum2 == false)
            {
                labAns.Text = "";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else
            {
                labAns.Text = (num1 + num2).ToString();
            }
        
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out double num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out double num2);
            if (isNum1 == false || isNum2 == false)
            {
                labAns.Text = "";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else
            {
                labAns.Text = (num1 - num2).ToString();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out double num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out double num2);
            if (isNum1 == false || isNum2 == false)
            {
                labAns.Text = "";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else
            {
                labAns.Text = (num1 * num2).ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            bool isNum1 = double.TryParse(txtNum1.Text, out double num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out double num2);
            if (isNum1 == false || isNum2 == false)
            {
                labAns.Text = "";
                txtNum1.Clear();
                txtNum2.Clear();
            }
            else
            {
                labAns.Text = Math.Round(num1 / num2,3).ToString();
            }
        }
    }
}
