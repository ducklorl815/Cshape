using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Homework_Menu : Form
    {
        public Homework_Menu()
        {
            InitializeComponent();
        }
        private void btnHello_Click(object sender, EventArgs e)
        {

            splitContainer1.Panel2.Controls.Clear();
            Homework_Hello Form = new Homework_Hello();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_Loan Form = new Homework_Loan();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_POS Form = new Homework_POS();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_Student_StructForm Form = new Homework_Student_StructForm();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_StudentsGrade Form = new Homework_StudentsGrade();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_StudentsGrade_List Form = new Homework_StudentsGrade_List();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_Guess Form = new Homework_Guess();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Homework_Menu_Load(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(150, 120);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_MyClac Form = new Homework_MyClac();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_XOGame Form = new Homework_XOGame();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Homework_Notepad Form = new Homework_Notepad();
            Form.TopLevel = false;
            Form.Top = 20;
            Form.Left = 20;
            splitContainer1.Panel2.Controls.Add(Form);
            Form.FormBorderStyle = FormBorderStyle.None;

            Form.Show();
        }
    }
}
