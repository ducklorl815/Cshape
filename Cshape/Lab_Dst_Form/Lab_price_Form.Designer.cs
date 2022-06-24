
namespace Lab_M02_Form
{
    partial class priceForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listPrice = new System.Windows.Forms.ComboBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "+=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "result";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "-=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(428, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // listPrice
            // 
            this.listPrice.FormattingEnabled = true;
            this.listPrice.Items.AddRange(new object[] {
            "20%off",
            "50%off"});
            this.listPrice.Location = new System.Drawing.Point(428, 269);
            this.listPrice.Name = "listPrice";
            this.listPrice.Size = new System.Drawing.Size(121, 20);
            this.listPrice.TabIndex = 4;
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(428, 329);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPrice.TabIndex = 5;
            this.btnPrice.Text = "計算金錢";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // priceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.listPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "priceForm";
            this.Text = "priceForm";
            this.Load += new System.EventHandler(this.priceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox listPrice;
        private System.Windows.Forms.Button btnPrice;
    }
}