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
    
    public partial class loanForm : Form
    {
        
        public loanForm()
        {
         
            InitializeComponent();
        }
        public void btnMonth_Click(object sender, EventArgs e)
        {
            double MouthRate = 1+double.Parse(txtRate.Text)/12/100; //年利率轉成月利率 1+年利率/12/100
            int Money = int.Parse(txtMoney.Text); //本金
            int Mouth = int.Parse(txtYear.Text) * 12; //期數12
            int First = int.Parse(txtFirst.Text); //頭期款

            double rpn = Math.Pow(MouthRate, Mouth); //rpn = Math.Pow(r, n);
            double PMT = (Money - First) * rpn * (MouthRate - 1) / (rpn - 1);
            
            MessageBox.Show("每月應付 "+ Math.Floor(PMT) + " 金額");
        }
        // 等額本息月還款 = [貸款本金×月利率×（1+月利率）^還款月數]÷[（1+月利率）^還款月數－1]
        //PMT = x * rpn * (r - 1) / (rpn - 1);
        public void btnAllPay_Click(object sender, EventArgs e)
        {
            double MouthRate = 1 + double.Parse(txtRate.Text) / 12 / 100; //年利率轉成月利率 1+年利率/12/100
            int Money = int.Parse(txtMoney.Text); //本金
            int Mouth = int.Parse(txtYear.Text) * 12; //期數12
            int First = int.Parse(txtFirst.Text); //頭期款

            double rpn = Math.Pow(MouthRate, Mouth); //rpn = Math.Pow(r, n);
            double YPMT = (Money - First) * rpn * (MouthRate - 1) / (rpn - 1)*24;

            MessageBox.Show("總共為 " + Math.Floor(YPMT) + " 金額");
        }

        public void btnReport_Click(object sender, EventArgs e)
        {
           reportForm report = new reportForm();
           report.Show();
        }
        public void Method01()
        {
            int Money = int.Parse(txtMoney.Text);
        }
    }
}
 