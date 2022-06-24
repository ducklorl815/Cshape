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
    public partial class Lab_M15_Form : Form
    {
        public Lab_M15_Form()
        {
            InitializeComponent();
        }

        private void btnCTS_Click(object sender, EventArgs e)
        {
            int a = 100;
            MessageBox.Show("a ="+ a);
            int b=a;
            MessageBox.Show("a = " + a + ", b = "+b);
            b = 200;
            MessageBox.Show("a = " + a + ", b = " + b);
        }

        private void txrReferenceType_Click(object sender, EventArgs e)
        {
            TextBox TB = txtReferenceType;
            TB.Text = "各位不用擔心 因為我來了";
            TB.BackColor = Color.Black;
            TB.ForeColor = Color.White;
            TB.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
