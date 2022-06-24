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
    public partial class Lab_M16_Form : Form
    {
        public Lab_M16_Form()
        {
            InitializeComponent();
        }

        private void btnValueType_Click(object sender, EventArgs e)
        {
            decimal dec = 10;
            MessageBox.Show("dec = " + dec);
            ByValueType(dec);
            MessageBox.Show("ByValueType(dec)  dec = " + dec);
            //只是把d=dec 代過去 跟dec原本的值無影響 而d的值有沒有改變也無所謂
            //因為變數經過方法之後就週期結束
        }
        void ByValueType(decimal d)
        {
            d = 10000000000;
        }
        void ByRefenceType(Member member)
        {
            member.Age = 30;
        }
        private void btnRerfenceType_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "Jessica";
            mem1.Age = 27;
            MessageBox.Show(mem1.Name+ mem1.Age);

            ByRefenceType(mem1); // 去抓ByRefenceType(mem1)位址 抓到member.Age = 30 複製過去

            MessageBox.Show(mem1.Name + mem1.Age);
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            decimal dec = 10;
            MessageBox.Show("dec = " + dec);
            byRef(ref dec); //強迫把 傳值直接轉成傳址 變成記憶體位址抓取
            MessageBox.Show("dec = " + dec);  
        }
        void byRef (ref decimal d)
        {
            d = 10000000000;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            double A;
            ByOut(out A, 10, 20);
            MessageBox.Show(A.ToString());
        }
        void ByOut(out double Price, double Y, double X)
        {
            Price = X+Y;
            // double PMT = M * RPN * (R - 1) / (RPN - 1);
        }

        private void Myparams_Click(object sender, EventArgs e)
        {
            string TotalC = myparams("國文", 78, 59, 56, 97, 85, 56, 98);
            MessageBox.Show(TotalC);
        }
         static string myparams(string Course,params int[] Score)
        {
            int total = 0;
            for(int i=0;i<Score.LongLength;i++)
            {
                total = total + Score[i];
            }
            return Course + "總成績為 "+ total;
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            Role User = Role.Admin;
            //if (User == Role.Admin)
            //{
            //    btnEnumCheck.Enabled = true;
            //    btnEnumCheck.Visible = true;
            //}
            //else
            //{
            //    btnEnumCheck.Enabled = false;
            //    btnEnumCheck.Visible = false;
            //}
            switch (User)
            {
                case Role.Admin:
                    btnEnumCheck.Enabled = true;
                    btnEnumCheck.Visible = true;
                    break;
                case Role.User:
                    btnEnumCheck.Enabled = false;
                    btnEnumCheck.Visible = false;
                    btnValueType.Visible = false;
                    btnRefenceType.Visible = false;
                    btnRef.Visible = false;
                    btnOut.Visible = false;
                    Myparams.Visible = false;
                    break;
            }
        
        }
    }
}
