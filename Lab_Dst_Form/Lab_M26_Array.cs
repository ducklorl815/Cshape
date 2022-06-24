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
    public partial class Lab_M26_Array : Form
    {
        public Lab_M26_Array()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] arr = new int[20];
            //int[] arr = { 1, 2, 3 };
            for (int i=0,j=0; i<20; i++,j+=2)
            {
                arr[i] = j+2;
                result += $"{arr[i]}   ";
            }
            MessageBox.Show(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            int[,] arr = new int[2, 2];
            arr[0, 0] = 0;
            arr[0, 1] = 0;
            arr[1, 0] = 0;
            arr[1, 1] = 1;

            for(int i=0; i <arr.GetLength(0);i++)
            {
              for(int j=0;j<arr.GetLength(1);j++)
                {
                    result += $"arr[{i},{j}] = {arr[i, j]} \n";
                }
            }
            MessageBox.Show(result);

        }
        string result = "";
        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = CreateArray(int.Parse(txtCallArray.Text));
            MessageBox.Show(result);
        }

        int[] CreateArray(int Length)
        {
      
            int[] arr = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                arr[i] = i + 1;
                result += $" arr[{i}] = {arr[i]}\n";
            }
            return arr ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Member[] member = new Member[2];

            Member[] member =
            {
               //new Member(){txtName.Text,int.Parse(txtAge.Text)},
               new Member(){ Name="7178",Age=29},
               new Member(){ Name="9527",Age=55},
               new Member(){ Name="9527",Age=55},
               new Member(){ Name="9527",Age=55},
               new Member(){ Name="9527",Age=55},
               new Member(){ Name="9527",Age=55},
               new Member(){ Name="9527",Age=55},
            };
            foreach(var item in member)
            {
                result += $"Name = {item.Name}    Age = {item.Age}\n";
            }

            //for(int i = 0; i< member.Length; i++)
            //{
            //    result += $"Name = {member[i].Name}    Age = {member[i].Age}\n";
            //}
            MessageBox.Show(result);

        }
    }
}
