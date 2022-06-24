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
        int count = 0;
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

        private void btnSetpro_Click(object sender, EventArgs e)
        {
            
            count++;
            priceForm.ActiveForm.Text = "改變+" + count;
        }

        private void btnMessagebox_Click(object sender, EventArgs e)
        {
           DialogResult result =  MessageBox.Show("今天星期二嗎","請問",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("對喔 是" + DateTime.Now.DayOfWeek);
                }
                else
                {
                    MessageBox.Show("不對喔");
                }
            }
            else
            {
                MessageBox.Show("不對喔 今天是"+ DateTime.Now.DayOfWeek);
            };

            /*   if (result == DialogResult.Yes )
               {
                   MessageBox.Show("不對喔 是"+ DateTime.Now.DayOfWeek);
               }*/

        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
           Lab_M02_Form m02_Form = new Lab_M02_Form();
            DialogResult result = m02_Form.ShowDialog();
            if(result==DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }
    }
}
