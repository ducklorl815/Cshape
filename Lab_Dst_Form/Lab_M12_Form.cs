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
    public partial class Lab_M12_Form : Form
    {
        public Lab_M12_Form()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btnAddDec_Click(object sender, EventArgs e)
        {
            count += 1;
            labAddDec.Text = count.ToString();
            Lab_M12_Form.ActiveForm.Text = Lab_M12_Form.ActiveForm.Text + count;
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
           /* int a = 0;
            if(true)
            {
                a = 99;
                a = x;

            }*/
            //x=
        }
        UseStatic US = new UseStatic();
        private void btnInstanceStatic_Click(object sender, EventArgs e)
        {
            US.Instance++;
            labInstanceStatic.Text = US.Instance.ToString();


        }

        private void btnStaticCount_Click(object sender, EventArgs e)
        {
            UseStatic.Static++;
            labStaticCount.Text = UseStatic.Static.ToString();
        }
    }
}
