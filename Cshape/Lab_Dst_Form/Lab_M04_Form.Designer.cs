
namespace Lab_M02_Form
{
    partial class Lab_M04_Form
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
            this.OpenHelloForm = new System.Windows.Forms.Button();
            this.btnMyFirstMethod = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEnca = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.btnPartialClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenHelloForm
            // 
            this.OpenHelloForm.Location = new System.Drawing.Point(581, 36);
            this.OpenHelloForm.Name = "OpenHelloForm";
            this.OpenHelloForm.Size = new System.Drawing.Size(122, 56);
            this.OpenHelloForm.TabIndex = 0;
            this.OpenHelloForm.Text = "Open Hello Form";
            this.OpenHelloForm.UseVisualStyleBackColor = true;
            this.OpenHelloForm.Click += new System.EventHandler(this.OpenHelloForm_Click);
            // 
            // btnMyFirstMethod
            // 
            this.btnMyFirstMethod.Location = new System.Drawing.Point(581, 98);
            this.btnMyFirstMethod.Name = "btnMyFirstMethod";
            this.btnMyFirstMethod.Size = new System.Drawing.Size(122, 56);
            this.btnMyFirstMethod.TabIndex = 1;
            this.btnMyFirstMethod.Text = "My First Method";
            this.btnMyFirstMethod.UseVisualStyleBackColor = true;
            this.btnMyFirstMethod.Click += new System.EventHandler(this.btnMyFirstMethod_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(581, 160);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(122, 52);
            this.btnMethod.TabIndex = 2;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(581, 218);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 53);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Method Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEnca
            // 
            this.btnEnca.Location = new System.Drawing.Point(581, 277);
            this.btnEnca.Name = "btnEnca";
            this.btnEnca.Size = new System.Drawing.Size(122, 53);
            this.btnEnca.TabIndex = 4;
            this.btnEnca.Text = "封裝";
            this.btnEnca.UseVisualStyleBackColor = true;
            this.btnEnca.Click += new System.EventHandler(this.btnEnca_Click);
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(445, 229);
            this.txtNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(120, 33);
            this.txtNum.TabIndex = 5;
            this.txtNum.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.txtNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnPartialClass
            // 
            this.btnPartialClass.Location = new System.Drawing.Point(581, 336);
            this.btnPartialClass.Name = "btnPartialClass";
            this.btnPartialClass.Size = new System.Drawing.Size(122, 53);
            this.btnPartialClass.TabIndex = 6;
            this.btnPartialClass.Text = "Partial Class";
            this.btnPartialClass.UseVisualStyleBackColor = true;
            this.btnPartialClass.Click += new System.EventHandler(this.btnPartialClass_Click);
            // 
            // Lab_M04_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPartialClass);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnEnca);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnMyFirstMethod);
            this.Controls.Add(this.OpenHelloForm);
            this.Name = "Lab_M04_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lab_M04_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenHelloForm;
        private System.Windows.Forms.Button btnMyFirstMethod;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEnca;
        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.Button btnPartialClass;
    }
}