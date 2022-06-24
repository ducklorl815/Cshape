using System;
using System.Collections;
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
    public partial class Lab_M29_ArrayList : Form
    {
        public Lab_M29_ArrayList()
        {
            InitializeComponent();
        }
        ArrayList isEmp = new ArrayList();
        Employee emp;
        bool isNum;
        //using System.Collections;
        void ShowInformation()
        {
            labShow.Text = $"員工     年齡    編號\n";
            for (int i = 0; i < isEmp.Count; i++)
            {
                labShow.Text += $"{((Employee)isEmp[i]).Name}       {((Employee)isEmp[i]).Age}        {i + 1}\n";
                //資料開封
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            emp.Name = txtName.Text;
            isNum = int.TryParse((txtAge.Text), out int Age);
            //emp.Age = int.TryParse(int.Parse(txtAge.Text),out int Age);
            if(isNum)
            {
                emp.Age = Age;
                isEmp.Add(emp); //boxing emp
                                //emp的Name Age 用isEmp包起來
                                //Employee unboxing
                                //要把資料拿出來 要再用 Employee方法解開封包
                                //labShow.Text = $"員工     年齡    編號\n";

                //for (int i = 0; i < isEmp.Count; i++)
                //{
                //    labShow.Text += $"{((Employee)isEmp[i]).Name}       {((Employee)isEmp[i]).Age}        {i + 1}\n";
                //    //資料開封
                //}
                ShowInformation();
            }
            else
            {
                MessageBox.Show("請正確輸入年齡");
                txtAge.Clear();
            }


            //MessageBox.Show(""+isEmp.Count);




        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            emp.Name = txtName.Text;
            isNum = int.TryParse(txtAge.Text, out int Age) && int.TryParse(txtInsert.Text, out int insert) && (int.Parse(txtInsert.Text) < isEmp.Count);

            if (isNum)
            {
                emp.Age = Age;
                isEmp.Insert(int.Parse(txtInsert.Text), emp);
                ShowInformation();
            }
            else
            {
                MessageBox.Show("輸入資料有誤");
                txtInsert.Clear();
                txtAge.Clear();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isEmp.Clear();
            ShowInformation();
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            isNum = int.TryParse(txtInsert.Text, out int insert) && insert < isEmp.Count;
            if (insert != 0)
            {

                if (isNum)
                {
                    isEmp.RemoveAt(int.Parse(txtInsert.Text));
                    ShowInformation();
                }
                else
                {
                    MessageBox.Show("目前資料量沒有這麼多");
                    txtInsert.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }
        }
    }
}
