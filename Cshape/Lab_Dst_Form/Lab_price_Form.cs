using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_M02_Form;

namespace Lab_M02_Form
{
    public partial class priceForm : Form
    {
        public priceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.button1.Click += new System.EventHandler(this.button1_Click);
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+= OK");
        }

        private void priceForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Click -= Button2_Click;
        }
        delegate double prement (double price);
        private void btnPrice_Click(object sender, EventArgs e)
        {
            prement pay;
            if(listPrice.Text== "20%off")
            {
                pay = Discount20off;
            }
            else
            {
                pay = Discount50off; 
            }
            double price = double.Parse(txtPrice.Text);
            double result = pay(price);
            MessageBox.Show(result.ToString());

        }
           
        double Discount20off (double price)
        {
            return price * 0.8;
        }
        double Discount50off(double price)
        {
            return price * 0.5;
        }
    }
}
