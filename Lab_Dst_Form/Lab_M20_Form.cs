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
    public partial class Lab_M20_Form : Form
    {
        public Lab_M20_Form()
        {
            InitializeComponent();
        }
        bool color;
        private void btnRever_Click(object sender, EventArgs e)
        {
            if(color)
            {
                btnRever.BackColor = Color.LightGray;
            }    
            else
            {
                btnRever.BackColor = Color.DarkKhaki;
            }
            color = !color;  //!=反轉
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // btnColor.BackColor color? Color.LightGray:Color.DarkKhaki;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //90 A
            //80 b
            //70 C
            //60 D
            //59~ E
            bool isNum = int.TryParse(txtGrade.Text, out int grade);
            if(isNum&& grade<=100)
            {
                if (grade >= 90 && 100 > grade)
                {
                    labClass.Text = "A";
                }
                else if (grade >= 80)
                {
                    labClass.Text = "B";
                }
                else if (grade >= 70)
                {
                    labClass.Text = "C";
                }
                else if (grade >= 60)
                {
                    labClass.Text = "D";
                }
                else
                {
                    labClass.Text = "E";
                }
            }
            else
            {
                picLab.Visible = true;
                btn3.Visible = true;
                labClass.Text = "級分";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            picLab.Visible = false;
            btn3.Visible = false;
            labClass.Text = "級分";
        }

        private void picLab_Click(object sender, EventArgs e)
        {
            picLab.Visible = false;
            btn3.Visible = false;
            labClass.Text = "級分";
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("今天有下雨嗎", "給問嗎~", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("那你有帶雨傘嗎?","我是暖爛人~",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                    break;
                case DialogResult.No:
                    MessageBox.Show("那要一起出去溜搭嗎?");
                    break;
                default:
                    MessageBox.Show("什麼都沒帶 搞屁阿~");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result="";
            while(i<10)
            {
                result += i+"\n";
                i++;
            }
            MessageBox.Show(result);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            do
            {
                result += i+"\n";
                i++;
            } while (i < 10);
            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = "";
            //for(int i=0; i<10; i++)
            //{
            //    result += i + "\n";
            //}
            for (int i = 0,j=5,k=10; i < 10; i++,j+=2,k--)
            {
                result += $" i =  {i}   j =  {j}   k = {k} \n";
            }
            MessageBox.Show(result);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach(Control btn in this.Controls)
            {
                if (btn.GetType() != typeof(Button))
                {
                    btn.Width += 5;
                    btn.Height += 5;
                    btn.Left += 5;
                    btn.Top += 5;
                    continue;
                }
                btn.Left -= 10;
                btn.Top -= 10;
            }
            }

        private void labClass_Click(object sender, EventArgs e)
        {
            this.btnColor.BackColor = System.Drawing.Color.LightGray;
            this.btnColor.Location = new System.Drawing.Point(66, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(147, 108);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "button1";
            this.btnColor.UseVisualStyleBackColor = false;
        }
    }
}
