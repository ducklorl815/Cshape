
namespace Homework
{
    partial class Homework_Guess
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
            this.labShow = new System.Windows.Forms.Label();
            this.btnNumber = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.labAns = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShow
            // 
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShow.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShow.Location = new System.Drawing.Point(28, 9);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(698, 143);
            this.labShow.TabIndex = 0;
            this.labShow.Text = "Please Select A Number Between 1 to 100";
            this.labShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNumber
            // 
            this.btnNumber.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber.Location = new System.Drawing.Point(474, 173);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(110, 64);
            this.btnNumber.TabIndex = 1;
            this.btnNumber.Text = "Guess";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnAns
            // 
            this.btnAns.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.Location = new System.Drawing.Point(602, 173);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(124, 64);
            this.btnAns.TabIndex = 2;
            this.btnAns.Text = "Show Answer";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // labAns
            // 
            this.labAns.BackColor = System.Drawing.Color.Transparent;
            this.labAns.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAns.ForeColor = System.Drawing.Color.Black;
            this.labAns.Location = new System.Drawing.Point(28, -5);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(698, 257);
            this.labAns.TabIndex = 3;
            this.labAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labAns.Visible = false;
            this.labAns.Click += new System.EventHandler(this.labAns_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.Enabled = false;
            this.btnAgain.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.Location = new System.Drawing.Point(462, 174);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnAgain.Size = new System.Drawing.Size(122, 63);
            this.btnAgain.TabIndex = 4;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(602, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(124, 64);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "E X I T";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Homework_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 261);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.labShow);
            this.Name = "Homework_Guess";
            this.Text = "Homework_Guess";
            this.Load += new System.EventHandler(this.Homework_Guess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnNumber;
        internal System.Windows.Forms.Label labShow;
        internal System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Label labAns;
        internal System.Windows.Forms.Button btnAgain;
        internal System.Windows.Forms.Button btnClose;
    }
}