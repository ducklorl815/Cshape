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
    public partial class Lab_M02_Form : Form
    {
        public Lab_M02_Form()
        {
            InitializeComponent();
        }

        public void btnName_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            String Eng = txtName1.Text;
            string Sex = txtName2.Text;
            string Star = txtName3.Text;
            var result = MessageBox.Show(
                "你好~ 冒險者! " + "\n" + 
                Name + Eng + "\n" + 
                "性別為 " + Sex +"\n"+
                "...mm" + "\n" + 
                "是"+ Star + "阿!" + "\n" + "\n"  + 
                "您確定要進入?", "警告",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {

            }
            if (result == DialogResult.No)
            {
                Close();
            }



        }

        private void btnName_MouseMove(object sender, MouseEventArgs e)
        {
            // TODO 圖片淡化 while else 交換
            btnName.ForeColor = Color.White;
            labName.ForeColor = Color.Red;
            BackgroundImage = new Bitmap(@"C:\Users\Student\Desktop\MSIT143\Cshape\image\dst_button1.png");
            BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnName_MouseLeave(object sender, EventArgs e)
        {
            btnName.ForeColor = Color.Black;
            labName.ForeColor = Color.LightGray;
            BackgroundImage = new Bitmap(@"C:\Users\Student\Desktop\MSIT143\Cshape\image\dst_background2.jpg");
            BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Lab_M02_Form_Load(object sender, EventArgs e)
        {

        }
     
    }
}
