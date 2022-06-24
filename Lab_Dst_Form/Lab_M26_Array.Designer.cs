
namespace Lab_M02_Form
{
    partial class Lab_M26_Array
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
            this.txtCallArray = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "多維陣列";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "呼叫陣列";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCallArray
            // 
            this.txtCallArray.Location = new System.Drawing.Point(33, 197);
            this.txtCallArray.Name = "txtCallArray";
            this.txtCallArray.Size = new System.Drawing.Size(100, 22);
            this.txtCallArray.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 63);
            this.button4.TabIndex = 4;
            this.button4.Text = "初始化陣列";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 308);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "鴨子";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(164, 349);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 6;
            this.txtAge.Text = "34";
            // 
            // Lab_M26_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtCallArray);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Lab_M26_Array";
            this.Text = "Lab_M26_Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCallArray;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
    }
}