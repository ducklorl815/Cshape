
namespace Lab_M02_Form
{
    partial class Lab_M20_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_M20_Form));
            this.btnColor = new System.Windows.Forms.Button();
            this.btnRever = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.labClass = new System.Windows.Forms.Label();
            this.picLab = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.LightGray;
            this.btnColor.Location = new System.Drawing.Point(66, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(147, 108);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "button1";
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // btnRever
            // 
            this.btnRever.BackColor = System.Drawing.Color.LightGray;
            this.btnRever.Location = new System.Drawing.Point(66, 163);
            this.btnRever.Name = "btnRever";
            this.btnRever.Size = new System.Drawing.Size(147, 108);
            this.btnRever.TabIndex = 1;
            this.btnRever.Text = "button2";
            this.btnRever.UseVisualStyleBackColor = false;
            this.btnRever.Click += new System.EventHandler(this.btnRever_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(66, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(448, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 108);
            this.button2.TabIndex = 3;
            this.button2.Text = "輸入分數";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGrade.Location = new System.Drawing.Point(380, 238);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(215, 33);
            this.txtGrade.TabIndex = 4;
            // 
            // labClass
            // 
            this.labClass.AutoSize = true;
            this.labClass.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.labClass.Location = new System.Drawing.Point(646, 238);
            this.labClass.Name = "labClass";
            this.labClass.Size = new System.Drawing.Size(54, 21);
            this.labClass.TabIndex = 5;
            this.labClass.Text = "級分";
            this.labClass.Click += new System.EventHandler(this.labClass_Click);
            // 
            // picLab
            // 
            this.picLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLab.Image = ((System.Drawing.Image)(resources.GetObject("picLab.Image")));
            this.picLab.Location = new System.Drawing.Point(-17, -160);
            this.picLab.Name = "picLab";
            this.picLab.Size = new System.Drawing.Size(391, 485);
            this.picLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLab.TabIndex = 6;
            this.picLab.TabStop = false;
            this.picLab.Visible = false;
            this.picLab.Click += new System.EventHandler(this.picLab_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LightGray;
            this.btn3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(606, 330);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(147, 108);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "對不起";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.LightGray;
            this.btnSwitch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.Location = new System.Drawing.Point(295, 367);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(132, 71);
            this.btnSwitch.TabIndex = 8;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.LightGray;
            this.btnWhile.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnWhile.Location = new System.Drawing.Point(621, 12);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(132, 71);
            this.btnWhile.TabIndex = 9;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(463, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 71);
            this.button3.TabIndex = 10;
            this.button3.Text = "do";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(621, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 71);
            this.button4.TabIndex = 11;
            this.button4.Text = "for";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(463, 110);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(101, 61);
            this.btnForeach.TabIndex = 12;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Lab_M20_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.picLab);
            this.Controls.Add(this.labClass);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRever);
            this.Controls.Add(this.btnColor);
            this.Name = "Lab_M20_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnRever;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label labClass;
        private System.Windows.Forms.PictureBox picLab;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnForeach;
    }
}