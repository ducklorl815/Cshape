
namespace Lab_M02_Form
{
    partial class Lab_M29_泛用List
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.labShow = new System.Windows.Forms.Label();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "插入/清除";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(71, 75);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 22);
            this.txtInsert.TabIndex = 20;
            this.txtInsert.Text = "5";
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(320, 12);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(55, 14);
            this.labShow.TabIndex = 19;
            this.labShow.Text = "員工資料";
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(195, 104);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAt.TabIndex = 18;
            this.btnRemoveAt.Text = "清除某一筆";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(195, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(195, 44);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(71, 41);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 14;
            this.txtAge.Text = "25";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "鴨子";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "員工年齡";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "員工姓名";
            // 
            // Lab_M29_泛用List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab_M29_泛用List";
            this.Text = "Lab_M29_泛用List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}