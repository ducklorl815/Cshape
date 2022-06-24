
namespace Lab_M02_Form
{
    partial class Lab_M19_Struct
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.labItem = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtItem.Location = new System.Drawing.Point(160, 57);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(150, 35);
            this.txtItem.TabIndex = 0;
            this.txtItem.Text = "巴辣";
            // 
            // labItem
            // 
            this.labItem.AutoSize = true;
            this.labItem.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labItem.Location = new System.Drawing.Point(79, 60);
            this.labItem.Name = "labItem";
            this.labItem.Size = new System.Drawing.Size(59, 26);
            this.labItem.TabIndex = 1;
            this.labItem.Text = "產品:";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.Location = new System.Drawing.Point(79, 111);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(59, 26);
            this.labPrice.TabIndex = 3;
            this.labPrice.Text = "售價:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(160, 108);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 35);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "50";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(218, 184);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 44);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(6, 18);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(2, 23);
            this.labShow.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShow);
            this.groupBox1.Location = new System.Drawing.Point(367, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 259);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Lab_M19_Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labItem);
            this.Controls.Add(this.txtItem);
            this.Name = "Lab_M19_Struct";
            this.Text = "Lab_M19_Struct";
            this.Load += new System.EventHandler(this.Lab_M19_Struct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label labItem;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}