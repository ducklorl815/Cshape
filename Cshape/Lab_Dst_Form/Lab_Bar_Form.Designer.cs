
namespace Lab_M02_Form
{
    partial class Lab_Bar_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_Bar_Form));
            this.gboxMenu = new System.Windows.Forms.GroupBox();
            this.btnPic4 = new System.Windows.Forms.Button();
            this.btnPic3 = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.btnPic1 = new System.Windows.Forms.Button();
            this.gboxTotalPrice = new System.Windows.Forms.GroupBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.gboxPay = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCase = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gboxMenu.SuspendLayout();
            this.gboxTotalPrice.SuspendLayout();
            this.gboxPay.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMenu
            // 
            this.gboxMenu.Controls.Add(this.btnPic4);
            this.gboxMenu.Controls.Add(this.btnPic3);
            this.gboxMenu.Controls.Add(this.btnPic2);
            this.gboxMenu.Controls.Add(this.btnPic1);
            this.gboxMenu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gboxMenu.Location = new System.Drawing.Point(12, 12);
            this.gboxMenu.Name = "gboxMenu";
            this.gboxMenu.Size = new System.Drawing.Size(274, 390);
            this.gboxMenu.TabIndex = 0;
            this.gboxMenu.TabStop = false;
            this.gboxMenu.Text = "菜單 Menu";
            // 
            // btnPic4
            // 
            this.btnPic4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic4.BackgroundImage")));
            this.btnPic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPic4.Location = new System.Drawing.Point(138, 192);
            this.btnPic4.Name = "btnPic4";
            this.btnPic4.Size = new System.Drawing.Size(126, 152);
            this.btnPic4.TabIndex = 3;
            this.btnPic4.Text = "3000";
            this.btnPic4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPic4.UseVisualStyleBackColor = true;
            // 
            // btnPic3
            // 
            this.btnPic3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic3.BackgroundImage")));
            this.btnPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPic3.Location = new System.Drawing.Point(6, 192);
            this.btnPic3.Name = "btnPic3";
            this.btnPic3.Size = new System.Drawing.Size(126, 152);
            this.btnPic3.TabIndex = 2;
            this.btnPic3.Text = "2000";
            this.btnPic3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPic3.UseVisualStyleBackColor = true;
            // 
            // btnPic2
            // 
            this.btnPic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic2.BackgroundImage")));
            this.btnPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPic2.Location = new System.Drawing.Point(138, 34);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(126, 152);
            this.btnPic2.TabIndex = 1;
            this.btnPic2.Text = "1000";
            this.btnPic2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPic2.UseVisualStyleBackColor = true;
            // 
            // btnPic1
            // 
            this.btnPic1.BackColor = System.Drawing.Color.Transparent;
            this.btnPic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic1.BackgroundImage")));
            this.btnPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic1.Location = new System.Drawing.Point(6, 34);
            this.btnPic1.Name = "btnPic1";
            this.btnPic1.Size = new System.Drawing.Size(126, 152);
            this.btnPic1.TabIndex = 0;
            this.btnPic1.Text = "500";
            this.btnPic1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPic1.UseVisualStyleBackColor = false;
            this.btnPic1.Click += new System.EventHandler(this.btnPic1_Click);
            this.btnPic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPic1_MouseDown);
            // 
            // gboxTotalPrice
            // 
            this.gboxTotalPrice.Controls.Add(this.labPrice);
            this.gboxTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.gboxTotalPrice.Location = new System.Drawing.Point(303, 12);
            this.gboxTotalPrice.Name = "gboxTotalPrice";
            this.gboxTotalPrice.Size = new System.Drawing.Size(276, 96);
            this.gboxTotalPrice.TabIndex = 1;
            this.gboxTotalPrice.TabStop = false;
            this.gboxTotalPrice.Text = "總金額 Total Price";
            // 
            // labPrice
            // 
            this.labPrice.BackColor = System.Drawing.Color.Black;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.ForeColor = System.Drawing.Color.White;
            this.labPrice.Location = new System.Drawing.Point(31, 47);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(239, 37);
            this.labPrice.TabIndex = 0;
            this.labPrice.Text = "NT$2830";
            this.labPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gboxPay
            // 
            this.gboxPay.Controls.Add(this.label1);
            this.gboxPay.Controls.Add(this.btnCredit);
            this.gboxPay.Controls.Add(this.btnCase);
            this.gboxPay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.gboxPay.Location = new System.Drawing.Point(303, 158);
            this.gboxPay.Name = "gboxPay";
            this.gboxPay.Size = new System.Drawing.Size(276, 161);
            this.gboxPay.TabIndex = 2;
            this.gboxPay.TabStop = false;
            this.gboxPay.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(144, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "信用卡打9折!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(153, 50);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(108, 46);
            this.btnCredit.TabIndex = 2;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            // 
            // btnCase
            // 
            this.btnCase.Location = new System.Drawing.Point(20, 50);
            this.btnCase.Name = "btnCase";
            this.btnCase.Size = new System.Drawing.Size(106, 46);
            this.btnCase.TabIndex = 0;
            this.btnCase.Text = "現金";
            this.btnCase.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(590, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 413);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單 List";
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 27;
            this.listBox.Location = new System.Drawing.Point(6, 34);
            this.listBox.Name = "listBox";
            this.listBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox.Size = new System.Drawing.Size(264, 324);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12.75F);
            this.btnClear.Location = new System.Drawing.Point(162, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Lab_Bar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gboxPay);
            this.Controls.Add(this.gboxTotalPrice);
            this.Controls.Add(this.gboxMenu);
            this.Name = "Lab_Bar_Form";
            this.Text = "Happy Bar";
            this.gboxMenu.ResumeLayout(false);
            this.gboxTotalPrice.ResumeLayout(false);
            this.gboxPay.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMenu;
        private System.Windows.Forms.Button btnPic4;
        private System.Windows.Forms.Button btnPic3;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.Button btnPic1;
        private System.Windows.Forms.GroupBox gboxTotalPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.GroupBox gboxPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnClear;
    }
}