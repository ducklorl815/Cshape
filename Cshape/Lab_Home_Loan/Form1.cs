using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Home_Loan
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
         
            InitializeComponent();
        }
        private void btnMonth_Click(object sender, EventArgs e)
        {
            float MouthRate = float.Parse(txtRate.Text)/100; //0.025
            int Money = int.Parse(txtMoney.Text); //100000
            int Mouth = int.Parse(txtYear.Text)*12; //24
            int First = int.Parse(txtFirst.Text);
            double Cash =Money*(Math.Pow(1 + MouthRate, Mouth) * MouthRate) /
                        (Math.Pow(1 + MouthRate, Mouth)-1);
            
            MessageBox.Show("a"+ Math.Floor(Cash));
        }

        private void btnAllPay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
