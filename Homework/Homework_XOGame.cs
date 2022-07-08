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
    public partial class Homework_XOGame : Form
    {
        public Homework_XOGame()
        {
            InitializeComponent();
        }
        int count = 0;
        bool flag = true;
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = flag ? "O" : "X";
            flag = !flag;

            b.Enabled = false;
            b.ForeColor = Color.BurlyWood;
            b.BackColor = Color.Azure;
            b.FlatStyle = FlatStyle.Standard;
            victory();
        }

        private void victory()
        {
            count++;
            bool Chick_to_Win = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && !A1.Enabled)
                Chick_to_Win = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !B1.Enabled)
                Chick_to_Win = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled)
                Chick_to_Win = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !A1.Enabled)
                Chick_to_Win = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !B2.Enabled)
                Chick_to_Win = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !C3.Enabled)
                Chick_to_Win = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !A1.Enabled)
                Chick_to_Win = true;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && !B2.Enabled)
                Chick_to_Win = true;

            else if (count == 9)
            {
                DialogResult result = MessageBox.Show("DRAW GAME~~  要繼續下一盤嗎?", "DRAW", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    count = 0;
                    flag = true;
                    try
                    {
                        foreach (Control c in Controls)
                        {
                            Button b = (Button)c;
                            b.Text = "";
                            b.BackColor = Color.CadetBlue;
                            b.FlatStyle = FlatStyle.Popup;
                            b.Enabled = true;
                        }
                    }
                    catch { }
                }
                else
                {
                    this.Close();
                }
            }

            if (Chick_to_Win == true)
            {
                DialogResult result = MessageBox.Show(flag ? "X Win   要繼續下一盤嗎?" : "O Win   要繼續下一盤嗎?", "Congratulations!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    count = 0;
                    flag = true;
                    try
                    {
                        foreach (Control c in Controls)
                        {
                            Button b = (Button)c;
                            b.Text = "";
                            b.BackColor = Color.CadetBlue;
                            b.FlatStyle = FlatStyle.Popup;
                            b.Enabled = true;
                        }
                    }
                    catch { }
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.CadetBlue;
                    b.FlatStyle = FlatStyle.Popup;
                }
            }
            catch { }
        }
    }
}
