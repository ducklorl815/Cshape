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
    public partial class Homework_Guess : Form
    {
        public Homework_Guess()
        {
            InitializeComponent();
        }

        internal int AR;
        Random rnd = new Random();
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Homework_Guess_what GuessWhat = new Homework_Guess_what();
            GuessWhat.StartPosition = FormStartPosition.Manual;
            GuessWhat.Location = new Point(850, 320);
            GuessWhat.Owner = this;
            GuessWhat.Show();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {

            labAns.Visible = true;
            labAns.Text = "ANSWER IS " + AR + " !!!";
            labShow.Text = "Game Start!!!\nPlease Select A Number Between 1 to 100";
            int num = rnd.Next(1, 100);
            AR = num;
        }
        public void Homework_Guess_Load(object sender, EventArgs e)
        {
            int num = rnd.Next(1, 100);
            AR = num;
        }

        private void labAns_Click(object sender, EventArgs e)
        {
            labAns.Visible = false;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            labAns.Text = "";
            labShow.Text = "";
            int num = rnd.Next(1, 100);
            AR = num;
            btnAgain.Visible = false;
            btnAgain.Enabled = false;
            btnClose.Visible = false;
            btnClose.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
