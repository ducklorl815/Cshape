
namespace Lab_Home_Loan
{
    partial class Form1
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
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnAllPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.labMoney = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labFirst = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMonth
            // 
            this.btnMonth.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonth.Location = new System.Drawing.Point(230, 400);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(118, 57);
            this.btnMonth.TabIndex = 0;
            this.btnMonth.Text = "月付";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnAllPay
            // 
            this.btnAllPay.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllPay.Location = new System.Drawing.Point(383, 400);
            this.btnAllPay.Name = "btnAllPay";
            this.btnAllPay.Size = new System.Drawing.Size(118, 57);
            this.btnAllPay.TabIndex = 1;
            this.btnAllPay.Text = "總付款";
            this.btnAllPay.UseVisualStyleBackColor = true;
            this.btnAllPay.Click += new System.EventHandler(this.btnAllPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(549, 400);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(118, 57);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMoney.Location = new System.Drawing.Point(178, 105);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(145, 40);
            this.labMoney.TabIndex = 3;
            this.labMoney.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(188, 173);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(135, 40);
            this.labYear.TabIndex = 5;
            this.labYear.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(191, 240);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(132, 40);
            this.labRate.TabIndex = 7;
            this.labRate.Text = "利率(%)";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirst.Location = new System.Drawing.Point(207, 307);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(113, 40);
            this.labFirst.TabIndex = 9;
            this.labFirst.Text = "頭期款";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.Location = new System.Drawing.Point(347, 102);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(211, 50);
            this.txtMoney.TabIndex = 10;
            this.txtMoney.Text = "100000";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(347, 170);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(211, 50);
            this.txtYear.TabIndex = 11;
            this.txtYear.Text = "2";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(347, 237);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(211, 50);
            this.txtRate.TabIndex = 12;
            this.txtRate.Text = "2.5";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirst.Location = new System.Drawing.Point(347, 304);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(211, 50);
            this.txtFirst.TabIndex = 13;
            this.txtFirst.Text = "0";
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 535);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.labFirst);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labMoney);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAllPay);
            this.Controls.Add(this.btnMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnAllPay;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labFirst;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtFirst;
    }
}

