
namespace Lab_M02_Form
{
    partial class Lab_M12_Form
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
            this.btnAddDec = new System.Windows.Forms.Button();
            this.labAddDec = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnStaticCount = new System.Windows.Forms.Button();
            this.btnInstanceStatic = new System.Windows.Forms.Button();
            this.labInstanceStatic = new System.Windows.Forms.Label();
            this.labStaticCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDec
            // 
            this.btnAddDec.Location = new System.Drawing.Point(39, 167);
            this.btnAddDec.Name = "btnAddDec";
            this.btnAddDec.Size = new System.Drawing.Size(129, 74);
            this.btnAddDec.TabIndex = 0;
            this.btnAddDec.Text = "+= , -=";
            this.btnAddDec.UseVisualStyleBackColor = true;
            this.btnAddDec.Click += new System.EventHandler(this.btnAddDec_Click);
            // 
            // labAddDec
            // 
            this.labAddDec.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAddDec.Location = new System.Drawing.Point(22, 29);
            this.labAddDec.Name = "labAddDec";
            this.labAddDec.Size = new System.Drawing.Size(212, 103);
            this.labAddDec.TabIndex = 1;
            this.labAddDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnVar);
            this.groupBox1.Location = new System.Drawing.Point(240, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(70, 46);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(105, 49);
            this.btnVar.TabIndex = 0;
            this.btnVar.Text = "Var.";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Local Var.";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.btnStaticCount);
            this.gb.Controls.Add(this.btnInstanceStatic);
            this.gb.Location = new System.Drawing.Point(499, 38);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(235, 223);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            this.gb.Text = "groupBox2";
            // 
            // btnStaticCount
            // 
            this.btnStaticCount.Location = new System.Drawing.Point(70, 142);
            this.btnStaticCount.Name = "btnStaticCount";
            this.btnStaticCount.Size = new System.Drawing.Size(105, 49);
            this.btnStaticCount.TabIndex = 1;
            this.btnStaticCount.Text = "StaticCount";
            this.btnStaticCount.UseVisualStyleBackColor = true;
            this.btnStaticCount.Click += new System.EventHandler(this.btnStaticCount_Click);
            // 
            // btnInstanceStatic
            // 
            this.btnInstanceStatic.Location = new System.Drawing.Point(70, 46);
            this.btnInstanceStatic.Name = "btnInstanceStatic";
            this.btnInstanceStatic.Size = new System.Drawing.Size(105, 49);
            this.btnInstanceStatic.TabIndex = 0;
            this.btnInstanceStatic.Text = "InstanceStatic";
            this.btnInstanceStatic.UseVisualStyleBackColor = true;
            this.btnInstanceStatic.Click += new System.EventHandler(this.btnInstanceStatic_Click);
            // 
            // labInstanceStatic
            // 
            this.labInstanceStatic.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstanceStatic.Location = new System.Drawing.Point(692, 84);
            this.labInstanceStatic.Name = "labInstanceStatic";
            this.labInstanceStatic.Size = new System.Drawing.Size(96, 33);
            this.labInstanceStatic.TabIndex = 4;
            this.labInstanceStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labStaticCount
            // 
            this.labStaticCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStaticCount.Location = new System.Drawing.Point(692, 180);
            this.labStaticCount.Name = "labStaticCount";
            this.labStaticCount.Size = new System.Drawing.Size(96, 32);
            this.labStaticCount.TabIndex = 5;
            this.labStaticCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_M12_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labStaticCount);
            this.Controls.Add(this.labInstanceStatic);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labAddDec);
            this.Controls.Add(this.btnAddDec);
            this.Name = "Lab_M12_Form";
            this.Text = "Lab_M12_Form";
            this.groupBox1.ResumeLayout(false);
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDec;
        private System.Windows.Forms.Label labAddDec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVar;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btnStaticCount;
        private System.Windows.Forms.Button btnInstanceStatic;
        private System.Windows.Forms.Label labInstanceStatic;
        private System.Windows.Forms.Label labStaticCount;
    }
}