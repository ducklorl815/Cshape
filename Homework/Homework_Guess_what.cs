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
    public partial class Homework_Guess_what : Form
    {
        public Homework_Guess_what()
        {
            InitializeComponent();
        }
        int guess;
        int min = 1;
        int Max = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(textBox1.Text, out int num);
            if (isNum == false || num > Max || num < min)
            {
                textBox1.Clear();
            }
            else
            {
                Homework_Guess Guess = (Homework_Guess)this.Owner;
                Guess.labShow.Text = "";
                //Guess.rnd;
                guess = num;
                int A = Guess.AR;

                if (A == guess)
                {
                    this.Close();
                    Guess.labShow.Text = "WOOOOOW    ANSWER IS " + A + "!!!";
                    Guess.btnAgain.Visible = true;
                    Guess.btnAgain.Enabled = true;
                    Guess.btnClose.Enabled = true;
                    Guess.btnClose.Visible = true;
                }

                else if
                (guess > A)
                {
                    Guess.labShow.Text += "TOO LARGE!!!!\nPlease Select A Number Between " + min + " to " + guess;
                    Max = guess;
                }
                else if (guess < A)
                {
                    Guess.labShow.Text += "TOO SMALL!!!!\nPlease Select A Number Between " + guess + " to " + Max;
                    min = guess;
                }

                if (min + 2 == Max)
                {
                    this.Close();
                    Guess.labShow.Text = "OHOH... ANSWER IS " + A + "!!!";
                    Guess.btnAgain.Visible = true;
                    Guess.btnAgain.Enabled = true;
                    Guess.btnClose.Enabled = true;
                    Guess.btnClose.Visible = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Homework_Guess_what_Load(object sender, EventArgs e)
        {

        }
    }
}
