using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_M02_Form
{
    public partial class Lab_M32_Form : Form
    {
        public Lab_M32_Form()
        {
            InitializeComponent();
        }

        private void BtnString_Click(object sender, EventArgs e)
        {
            String A = "AAA";
            String B = A;
            B = "BBB";
            MessageBox.Show($"A = {A} ,B = {B}");
        }

        private void BtnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder A = new StringBuilder();
            A.Append("AAA");
            StringBuilder B = new StringBuilder();    
            A=B;
            B.Append("\nBBB");
            StringBuilder C = new StringBuilder();
            C = A;
            C.Append("\nCCC");
            //A=B=C =A+B+C
            MessageBox.Show($"A = \n{A}");
            MessageBox.Show($"B = \n{B}");
            MessageBox.Show($"C = \n{C}");

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\Student\Downloads\TaeYeon.jpg";
            
            string result = "";
            result += Path.GetDirectoryName(dir) + "\n" +Path.GetFileName(dir) + "\n"+ Path.GetFullPath(dir);

            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labPassword.Text= PasswordCorrect(txtPassword.Text) ? "密碼強度高" : "密碼強度低";
            labID.Text = IdCorrect(txtID.Text) ? "身份證字號正確" : "身份證字號錯誤";


        }

        bool PasswordCorrect(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }
        bool IdCorrect(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }
        bool Flag = true;
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (PasswordCorrect(txtPassword.Text))
            {
                labPassword.Text = "密碼強度高";
               // timerPassword.Enabled = ;
            }
            else
            {
                labPassword.Text = "密碼強度低";
                timerPassword.Enabled = true;
            }
        }

        private void timerPassword_Tick(object sender, EventArgs e)
        {
            if (Flag)
            {
                labPassword.BackColor = Color.White;
                labPassword.ForeColor = Color.Black;
            }
            else
            {
                labPassword.BackColor = Color.Black;
                labPassword.ForeColor = Color.White;

            }
            Flag = !Flag;

        }
    }
}
