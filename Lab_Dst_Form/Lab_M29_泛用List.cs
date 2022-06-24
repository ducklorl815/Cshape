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
    public partial class Lab_M29_泛用List : Form
    {
        public Lab_M29_泛用List()
        {
            InitializeComponent();
        }
        List<Employee> Isemp = new List<Employee>();
        Employee emp;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            emp.Name = txtName.Text;
            emp.Age = int.Parse(txtAge.Text);  //丟進去使用泛用list
            Isemp.Add(emp);
            labShow.Text = "姓名\n";
            for(int i = 0; i < Isemp.Count; i++)
            {
                labShow.Text += $"{Isemp[i].Name}{Isemp[i].Age}\n";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            emp.Name = txtName.Text;
            emp.Age = int.Parse(txtAge.Text);
            Isemp.Insert(int.Parse(txtInsert.Text), emp) ;
            LayoutList();
        }
        void LayoutList()
        {
            Isemp.Add(emp);
            labShow.Text = "姓名\n";
            for (int i = 0; i < Isemp.Count; i++)
            {
                labShow.Text += $"{Isemp[i].Name}{Isemp[i].Age}\n";
            }
        }
    }
}
