using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Lab_M02_form : Form
    {
        public Lab_M02_form()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            MessageBox.Show("Oh!"+ Name );
        }

        private void btnName_MouseMove(object sender, MouseEventArgs e)
        {
            btnName.BackColor = Color.Red;
            btnName.ForeColor = Color.White;
        }

        private void btnName_MouseLeave(object sender, EventArgs e)
        {
            btnName.BackColor = Color.Black;
            btnName.ForeColor = Color.BlueViolet;
        }
    }
}
