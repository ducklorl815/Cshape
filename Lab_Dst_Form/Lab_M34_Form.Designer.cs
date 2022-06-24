
namespace Lab_M02_Form
{
    partial class Lab_M34_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtRead = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWrrite = new System.Windows.Forms.Button();
            this.txtReadWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRead
            // 
            this.txtRead.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRead.Location = new System.Drawing.Point(136, 12);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRead.Size = new System.Drawing.Size(652, 426);
            this.txtRead.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWrrite
            // 
            this.btnWrrite.Location = new System.Drawing.Point(12, 71);
            this.btnWrrite.Name = "btnWrrite";
            this.btnWrrite.Size = new System.Drawing.Size(88, 44);
            this.btnWrrite.TabIndex = 2;
            this.btnWrrite.Text = "Wrrite";
            this.btnWrrite.UseVisualStyleBackColor = true;
            this.btnWrrite.Click += new System.EventHandler(this.btnWrrite_Click);
            // 
            // txtReadWrite
            // 
            this.txtReadWrite.Location = new System.Drawing.Point(12, 121);
            this.txtReadWrite.Multiline = true;
            this.txtReadWrite.Name = "txtReadWrite";
            this.txtReadWrite.Size = new System.Drawing.Size(88, 23);
            this.txtReadWrite.TabIndex = 3;
            // 
            // Lab_M34_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReadWrite);
            this.Controls.Add(this.btnWrrite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRead);
            this.Name = "Lab_M34_Form";
            this.Text = "Lab_M34_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWrrite;
        private System.Windows.Forms.TextBox txtReadWrite;
    }
}