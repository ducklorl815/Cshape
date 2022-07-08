using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Homework
{
    public partial class Homework_Notepad : Form
    {
        public Homework_Notepad()
        {
            InitializeComponent();
        }


        private void toolNew_Click(object sender, EventArgs e)
        {
            txtNote.Text= string.Empty;
        }
       
        private void toolOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var filepath = string.Empty;
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "開啟檔案";
                open.Filter = "txt|*.txt";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;
                    filepath = open.FileName;
                    string readfile = File.ReadAllText(filename);
                    txtNote.Text = readfile;
                }
                this.Text = Path.GetFileName(filepath);
            }
            catch
            { }

        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream wr = new FileStream(this.Text, FileMode.Create);
                StreamWriter sw = new StreamWriter(wr, Encoding.UTF8);
                sw.Write(txtNote.Text);
                sw.Close();
                wr.Close();
            }
            catch { }
 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtNote.Text,new Font("Arial",12,FontStyle.Regular),Brushes.Black,new Point(10,10));
        }

        private void toolPrint_Click(object sender, EventArgs e)
        {

            printDocument1.Print();
        }

        private void toolCut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtNote.SelectedText);
                txtNote.SelectedText = string.Empty;
            }
            catch
            { }
        }

        private void toolCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtNote.SelectedText);
            }
            catch { }
            
        }

        private void toolPaste_Click(object sender, EventArgs e)
        {
            string paste = Clipboard.GetText();
            txtNote.Text = txtNote.Text.Insert(txtNote.SelectionStart, paste);
            //to do  richtextbox
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Text = string.Empty;
        }

        private void 開啟OCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var filepath = string.Empty;
                OpenFileDialog open = new OpenFileDialog();
                open.Title = "開啟檔案";
                open.Filter = "txt|*.txt";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    string filename = open.FileName;
                    filepath = open.FileName;
                    string readfile = File.ReadAllText(filename);
                    txtNote.Text = readfile;
                }
                this.Text = Path.GetFileName(filepath);
            }
            catch { }

        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "儲存檔案";
            save.Filter = "txt|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                BinaryWriter wr = new BinaryWriter(File.Create(path));
                //FileStream wr = new FileStream(this.Text + ".txt", FileMode.Create);
                //StreamWriter sw = new StreamWriter(wr, Encoding.UTF8);
                //sw.Write(this.Text+ ".txt");
                wr.Write(txtNote.Text + ".txt");
                //sw.Close();
                wr.Close();
            }
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void 列印PCtrlPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
                txtNote.Undo();
        }

        private void 儲存SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream wr = new FileStream(this.Text, FileMode.Create);
                StreamWriter sw = new StreamWriter(wr, Encoding.UTF8);
                sw.Write(txtNote.Text);
                sw.Close();
                wr.Close();
            }
            catch { }
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是專屬給IU使用\n^~^!\n還在更新中~");
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtNote.SelectedText);
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string paste = Clipboard.GetText();
            txtNote.Text = txtNote.Text.Insert(txtNote.SelectionStart, paste);
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtNote.SelectedText);
                txtNote.SelectedText = string.Empty;
            }
            catch
            { }
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Select(0, txtNote.Text.Length);
        }

        private void 格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectedText= txtNote.SelectedText.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectedText = txtNote.SelectedText.ToLower();
        }

        private void 字形VToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
