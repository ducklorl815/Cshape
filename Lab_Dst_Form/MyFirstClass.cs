using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_M02_Form
{
    partial class MyFirstClass
    {
        void Method01()  // 預設private 無法呼叫 等同於 private void
        {
            MessageBox.Show("Method01");
           
        }
        private void Method02() //預設private 無法呼叫
        {
            MessageBox.Show("private Method02");
        }
        public void Method03()
        {
            MessageBox.Show("public Method03");
        }
        internal void Method04()
        {
            MessageBox.Show("internal Method04");
        }
        public void Method05()
        {
            Method01();
            Method02();
        }
    }
}
