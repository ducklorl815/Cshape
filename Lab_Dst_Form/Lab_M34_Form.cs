using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_M02_Form
{
    public partial class Lab_M34_Form : Form
    {
        public Lab_M34_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(txtReadWrite.Text+".txt", Encoding.UTF8);
            txtRead.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void btnWrrite_Click(object sender, EventArgs e)
        {
            FileStream wr = new FileStream(txtReadWrite.Text + ".txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(wr, Encoding.UTF8);
            sw.Write(txtRead.Text);
            sw.Close();
            wr.Close();
        }
    }
}
