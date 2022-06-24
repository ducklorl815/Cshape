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
        public void Method06()
        {
            MessageBox.Show("partial class Method06");
        }
    }
    public class UseStatic
    {
        public int Instance;

        public static int Static;
    }

    public class Member
    {
        public String Name;
        public int Age;
    }

    public enum Role
    {
        Admin =0,User=2,
    }

    public struct Employee
    {
        public string Name;
        public int Age;
    }
    struct Product 
    {
        public string item { get; set; }
        public int price { get; set; }

        public Product(string stuff,int cash) //結構有方法跟屬性就必須實作
        {
            item  = stuff;
            price = cash;
        }
   
    }
        

}
