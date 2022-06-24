
namespace Lab_M02_Form
{
    partial class Lab_M16_Form
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
            this.btnValueType = new System.Windows.Forms.Button();
            this.btnRefenceType = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.Myparams = new System.Windows.Forms.Button();
            this.btnEnum = new System.Windows.Forms.Button();
            this.btnEnumCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValueType
            // 
            this.btnValueType.Location = new System.Drawing.Point(17, 29);
            this.btnValueType.Name = "btnValueType";
            this.btnValueType.Size = new System.Drawing.Size(177, 95);
            this.btnValueType.TabIndex = 0;
            this.btnValueType.Text = "byValueType";
            this.btnValueType.UseVisualStyleBackColor = true;
            this.btnValueType.Click += new System.EventHandler(this.btnValueType_Click);
            // 
            // btnRefenceType
            // 
            this.btnRefenceType.Location = new System.Drawing.Point(218, 29);
            this.btnRefenceType.Name = "btnRefenceType";
            this.btnRefenceType.Size = new System.Drawing.Size(177, 95);
            this.btnRefenceType.TabIndex = 1;
            this.btnRefenceType.Text = "byRefenceType";
            this.btnRefenceType.UseVisualStyleBackColor = true;
            this.btnRefenceType.Click += new System.EventHandler(this.btnRerfenceType_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(413, 29);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(177, 95);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "byRef";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(611, 29);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(177, 95);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "byOut";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Myparams
            // 
            this.Myparams.Location = new System.Drawing.Point(17, 143);
            this.Myparams.Name = "Myparams";
            this.Myparams.Size = new System.Drawing.Size(177, 95);
            this.Myparams.TabIndex = 4;
            this.Myparams.Text = "Myparams";
            this.Myparams.UseVisualStyleBackColor = true;
            this.Myparams.Click += new System.EventHandler(this.Myparams_Click);
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(218, 143);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(177, 95);
            this.btnEnum.TabIndex = 5;
            this.btnEnum.Text = "Enum";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnEnumCheck
            // 
            this.btnEnumCheck.Enabled = false;
            this.btnEnumCheck.Location = new System.Drawing.Point(548, 240);
            this.btnEnumCheck.Name = "btnEnumCheck";
            this.btnEnumCheck.Size = new System.Drawing.Size(240, 198);
            this.btnEnumCheck.TabIndex = 6;
            this.btnEnumCheck.Text = "歡迎光臨 Admin";
            this.btnEnumCheck.UseVisualStyleBackColor = true;
            this.btnEnumCheck.Visible = false;
            // 
            // Lab_M16_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnumCheck);
            this.Controls.Add(this.btnEnum);
            this.Controls.Add(this.Myparams);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnRefenceType);
            this.Controls.Add(this.btnValueType);
            this.Name = "Lab_M16_Form";
            this.Text = "Lab_M16_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValueType;
        private System.Windows.Forms.Button btnRefenceType;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button Myparams;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Button btnEnumCheck;
    }
}