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
    public partial class Lan_M28_Swap : Form
    {
        public Lan_M28_Swap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 999;
            MessageBox.Show($"a = {a} , b = {b}");
            Swap(ref a, ref b);
            MessageBox.Show($"a = {a} , b = {b}");
        }
        void Swap(ref int a, ref int b)
        {
            int Temp;
            Temp = a;
            a = b;
            b = Temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "AAA";
            string b = "bbb";
            MessageBox.Show($"a = {a} , b = {b}");
            Swap(ref a, ref b);
            MessageBox.Show($"a = {a} , b = {b}");
        }
        void Swap(ref string a, ref string b)
        {
            string Temp;
            Temp = a;
            a = b;
            b = Temp;
        }
        void Generic<SR>(ref SR a, ref SR b)
        {
            SR Temp;
            Temp = a;
            a = b;
            b = Temp;
        }
        void TwoGeneric<AR, BR>(ref AR a, ref AR b, ref BR Sa, ref BR Sb)
        {
            AR Temp;
            Temp = a;
            a = b;
            b = Temp;
            BR STemp;
            STemp = Sa;
            Sa = Sb;
            Sb = STemp;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a = 500, b = 2;
            MessageBox.Show($"a = {a} , b = {b}");
            Generic<int>(ref a, ref b);
            MessageBox.Show($"a = {a} , b = {b}");
            string A = "AAA", B = "bbb";
            MessageBox.Show($"A = {A} , B = {B}");
            Generic<string>(ref A, ref B);
            MessageBox.Show($"A = {A} , B = {B}");
        }
    }
}
