
namespace Lab_M02_Form
{
    partial class Lab_M15_Form
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
            this.btnCTS = new System.Windows.Forms.Button();
            this.btnReferenceType = new System.Windows.Forms.Button();
            this.txtReferenceType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCTS
            // 
            this.btnCTS.Location = new System.Drawing.Point(129, 176);
            this.btnCTS.Name = "btnCTS";
            this.btnCTS.Size = new System.Drawing.Size(155, 98);
            this.btnCTS.TabIndex = 0;
            this.btnCTS.Text = "Value CTS";
            this.btnCTS.UseVisualStyleBackColor = true;
            this.btnCTS.Click += new System.EventHandler(this.btnCTS_Click);
            // 
            // btnReferenceType
            // 
            this.btnReferenceType.Location = new System.Drawing.Point(458, 176);
            this.btnReferenceType.Name = "btnReferenceType";
            this.btnReferenceType.Size = new System.Drawing.Size(155, 98);
            this.btnReferenceType.TabIndex = 1;
            this.btnReferenceType.Text = "Reference Type";
            this.btnReferenceType.UseVisualStyleBackColor = true;
            this.btnReferenceType.Click += new System.EventHandler(this.txrReferenceType_Click);
            // 
            // txtReferenceType
            // 
            this.txtReferenceType.Location = new System.Drawing.Point(458, 290);
            this.txtReferenceType.Name = "txtReferenceType";
            this.txtReferenceType.Size = new System.Drawing.Size(155, 22);
            this.txtReferenceType.TabIndex = 2;
            // 
            // Lab_M15_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReferenceType);
            this.Controls.Add(this.btnReferenceType);
            this.Controls.Add(this.btnCTS);
            this.Name = "Lab_M15_Form";
            this.Text = "Value CTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCTS;
        private System.Windows.Forms.Button btnReferenceType;
        private System.Windows.Forms.TextBox txtReferenceType;
    }
}