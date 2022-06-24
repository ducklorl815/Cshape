using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_M02_Form
{
    public partial class Lab_M19_Struct : Form
    {
        public Lab_M19_Struct()
        {
            InitializeComponent();
        }
        string result= "產品       售價         總價       平均   數量";
        int a;
        int b;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Product pro;
            //pro.item = txtItem.Text;
            //pro.price = int.Parse(txtPrice.Text);
            //Product pro = new Product(txtItem.Text, int.Parse(txtPrice.Text));

            int price;
            bool isNum = int.TryParse(txtPrice.Text, out price);

            if(isNum==true)    // 可以直接 if(isNum
            {
                Product pro = new Product(txtItem.Text,price);
                a += price;
                b++;
                // result += "\n"+pro.item + pro.price+ a + a/b + b;
                result += $"\n{pro.item}        {price}            {a}        {a / b}       {b}";

                return;
            }
            else
            {
                txtPrice.Clear();
                txtPrice.Focus();
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            labShow.Text = result;
        }

        private void Lab_M19_Struct_Load(object sender, EventArgs e)
        {

        }
    }
}
