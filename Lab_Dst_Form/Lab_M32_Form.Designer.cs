
namespace Lab_M02_Form
{
    partial class Lab_M32_Form
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
            this.components = new System.ComponentModel.Container();
            this.BtnString = new System.Windows.Forms.Button();
            this.BtnStringBuilder = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.timerPassword = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnString
            // 
            this.BtnString.Location = new System.Drawing.Point(69, 45);
            this.BtnString.Name = "BtnString";
            this.BtnString.Size = new System.Drawing.Size(96, 43);
            this.BtnString.TabIndex = 0;
            this.BtnString.Text = "String";
            this.BtnString.UseVisualStyleBackColor = true;
            this.BtnString.Click += new System.EventHandler(this.BtnString_Click);
            // 
            // BtnStringBuilder
            // 
            this.BtnStringBuilder.Location = new System.Drawing.Point(69, 110);
            this.BtnStringBuilder.Name = "BtnStringBuilder";
            this.BtnStringBuilder.Size = new System.Drawing.Size(96, 43);
            this.BtnStringBuilder.TabIndex = 1;
            this.BtnStringBuilder.Text = "StringBuilder";
            this.BtnStringBuilder.UseVisualStyleBackColor = true;
            this.BtnStringBuilder.Click += new System.EventHandler(this.BtnStringBuilder_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(69, 170);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(96, 43);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(274, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(274, 101);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 22);
            this.txtID.TabIndex = 5;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(413, 57);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 12);
            this.labPassword.TabIndex = 6;
            this.labPassword.Text = "密碼強度";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(413, 104);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(65, 12);
            this.labID.TabIndex = 7;
            this.labID.Text = "身分證字號";
            // 
            // timerPassword
            // 
            this.timerPassword.Tick += new System.EventHandler(this.timerPassword_Tick);
            // 
            // Lab_M32_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.BtnStringBuilder);
            this.Controls.Add(this.BtnString);
            this.Name = "Lab_M32_Form";
            this.Text = "Lab_M32_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnString;
        private System.Windows.Forms.Button BtnStringBuilder;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Timer timerPassword;
    }
}