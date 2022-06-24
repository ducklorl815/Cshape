
namespace Lab_Home_Loan
{
    partial class loanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loanForm));
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
            this.btnMonth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMonth.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonth.Location = new System.Drawing.Point(225, 427);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(118, 57);
            this.btnMonth.TabIndex = 0;
            this.btnMonth.Text = "月付";
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnAllPay
            // 
            this.btnAllPay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAllPay.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllPay.Location = new System.Drawing.Point(377, 427);
            this.btnAllPay.Name = "btnAllPay";
            this.btnAllPay.Size = new System.Drawing.Size(118, 57);
            this.btnAllPay.TabIndex = 1;
            this.btnAllPay.Text = "總付款";
            this.btnAllPay.UseVisualStyleBackColor = false;
            this.btnAllPay.Click += new System.EventHandler(this.btnAllPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(531, 427);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(127, 57);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labMoney
            // 
            this.labMoney.AutoSize = true;
            this.labMoney.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labMoney.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labMoney.Location = new System.Drawing.Point(22, 25);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(145, 40);
            this.labMoney.TabIndex = 3;
            this.labMoney.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labYear.Location = new System.Drawing.Point(32, 93);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(135, 40);
            this.labYear.TabIndex = 5;
            this.labYear.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labRate.Location = new System.Drawing.Point(35, 160);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(132, 40);
            this.labRate.TabIndex = 7;
            this.labRate.Text = "利率(%)";
            // 
            // labFirst
            // 
            this.labFirst.AutoSize = true;
            this.labFirst.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labFirst.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labFirst.Location = new System.Drawing.Point(51, 227);
            this.labFirst.Name = "labFirst";
            this.labFirst.Size = new System.Drawing.Size(113, 40);
            this.labFirst.TabIndex = 9;
            this.labFirst.Text = "頭期款";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.Wheat;
            this.txtMoney.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.Location = new System.Drawing.Point(191, 22);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(211, 50);
            this.txtMoney.TabIndex = 10;
            this.txtMoney.Text = "100000";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Wheat;
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(191, 90);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(211, 50);
            this.txtYear.TabIndex = 11;
            this.txtYear.Text = "2";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.Wheat;
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.Location = new System.Drawing.Point(191, 157);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(211, 50);
            this.txtRate.TabIndex = 12;
            this.txtRate.Text = "2.5";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.Wheat;
            this.txtFirst.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirst.Location = new System.Drawing.Point(191, 224);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(211, 50);
            this.txtFirst.TabIndex = 13;
            this.txtFirst.Text = "0";
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // loanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(936, 521);
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
            this.Name = "loanForm";
            this.Text = "貸款金額計算";
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

