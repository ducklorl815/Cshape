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
    public partial class Lab_M04_Form : Form
    {
        public Lab_M04_Form()
        {
            InitializeComponent();
        }

        private void OpenHelloForm_Click(object sender, EventArgs e)
        {
            Lab_M02_Form M02_Form = new Lab_M02_Form();
            M02_Form.Show();
        }

        void MyfirstMethod()
        {
            MessageBox.Show("My First Method");
        }
        private void btnMyFirstMethod_Click(object sender, EventArgs e)
        {
            MyfirstMethod();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            MyFirstClass mfc = new MyFirstClass();
            //mfc.Method01();  預設private 無法呼叫
            //mfc.Method02();  預設private 無法呼叫
            mfc.Method03();  // public void
            mfc.Method04();  // internal void
        }

        private void Lab_M04_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int age = (int)txtNum.Value;
            string birth = BirthYear(age);
            MessageBox.Show(birth);
        }
        string BirthYear(int age)
        {
            int birthyear = DateTime.Now.Year - age;
            string result = "出生年為 " + birthyear;
            return result; //return 值 丟回 BirthYear
        }

        private void btnEnca_Click(object sender, EventArgs e)
        {
           MyFirstClass mfc  = new MyFirstClass();
            mfc.Method05();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPartialClass_Click(object sender, EventArgs e)
        {
            MyFirstClass mfc = new MyFirstClass();
            mfc.Method06();
        }
    }
}
