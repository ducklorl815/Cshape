
namespace Lab_Form
{
    partial class Lab_M02_form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab_M02_form));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtName.Location = new System.Drawing.Point(851, 533);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 36);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.BackColor = System.Drawing.Color.Transparent;
            this.txtLabel.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel.ForeColor = System.Drawing.Color.White;
            this.txtLabel.Location = new System.Drawing.Point(782, 432);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(324, 103);
            this.txtLabel.TabIndex = 2;
            this.txtLabel.Text = "My Lord , your Name";
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Gray;
            this.btnName.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnName.Location = new System.Drawing.Point(890, 575);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(105, 47);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Check";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            this.btnName.MouseLeave += new System.EventHandler(this.btnName_MouseLeave);
            this.btnName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnName_MouseMove);
            // 
            // Lab_M02_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1145, 647);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab_M02_form";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Button btnName;
    }
}

