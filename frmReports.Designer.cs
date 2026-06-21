namespace UMS
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnMeritList;
        private System.Windows.Forms.Button btnPendingFee;
        private System.Windows.Forms.Button btnRefundReport;
        private System.Windows.Forms.Button btnOccupancyReport;
        private System.Windows.Forms.Button btnRevenueSummary;
        private System.Windows.Forms.Button btnIndividualVoucher;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnMeritList = new System.Windows.Forms.Button();
            this.btnPendingFee = new System.Windows.Forms.Button();
            this.btnRefundReport = new System.Windows.Forms.Button();
            this.btnOccupancyReport = new System.Windows.Forms.Button();
            this.btnRevenueSummary = new System.Windows.Forms.Button();
            this.btnIndividualVoucher = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "REPORTS CENTER";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitle.Location = new System.Drawing.Point(320, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(260, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select a report type to generate PDF";
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.btnMeritList);
            this.panelButtons.Controls.Add(this.btnPendingFee);
            this.panelButtons.Controls.Add(this.btnRefundReport);
            this.panelButtons.Controls.Add(this.btnOccupancyReport);
            this.panelButtons.Controls.Add(this.btnRevenueSummary);
            this.panelButtons.Controls.Add(this.btnIndividualVoucher);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 100);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(900, 500);
            this.panelButtons.TabIndex = 1;
            // 
            // btnMeritList
            // 
            this.btnMeritList.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMeritList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeritList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMeritList.ForeColor = System.Drawing.Color.White;
            this.btnMeritList.Location = new System.Drawing.Point(80, 50);
            this.btnMeritList.Name = "btnMeritList";
            this.btnMeritList.Size = new System.Drawing.Size(220, 80);
            this.btnMeritList.TabIndex = 0;
            this.btnMeritList.Text = "🎯 MERIT LIST\r\n(Program-wise Merit)";
            this.btnMeritList.UseVisualStyleBackColor = false;
            this.btnMeritList.Click += new System.EventHandler(this.btnMeritList_Click);
            // 
            // btnPendingFee
            // 
            this.btnPendingFee.BackColor = System.Drawing.Color.Crimson;
            this.btnPendingFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendingFee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPendingFee.ForeColor = System.Drawing.Color.White;
            this.btnPendingFee.Location = new System.Drawing.Point(340, 50);
            this.btnPendingFee.Name = "btnPendingFee";
            this.btnPendingFee.Size = new System.Drawing.Size(220, 80);
            this.btnPendingFee.TabIndex = 1;
            this.btnPendingFee.Text = "⚠️ PENDING FEE\r\n(Unpaid Vouchers)";
            this.btnPendingFee.UseVisualStyleBackColor = false;
            this.btnPendingFee.Click += new System.EventHandler(this.btnPendingFee_Click);
            // 
            // btnRefundReport
            // 
            this.btnRefundReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRefundReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefundReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefundReport.ForeColor = System.Drawing.Color.White;
            this.btnRefundReport.Location = new System.Drawing.Point(600, 50);
            this.btnRefundReport.Name = "btnRefundReport";
            this.btnRefundReport.Size = new System.Drawing.Size(220, 80);
            this.btnRefundReport.TabIndex = 2;
            this.btnRefundReport.Text = "💰 REFUND REPORT\r\n(Security Deposits)";
            this.btnRefundReport.UseVisualStyleBackColor = false;
            this.btnRefundReport.Click += new System.EventHandler(this.btnRefundReport_Click);
            // 
            // btnOccupancyReport
            // 
            this.btnOccupancyReport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOccupancyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupancyReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOccupancyReport.ForeColor = System.Drawing.Color.White;
            this.btnOccupancyReport.Location = new System.Drawing.Point(80, 170);
            this.btnOccupancyReport.Name = "btnOccupancyReport";
            this.btnOccupancyReport.Size = new System.Drawing.Size(220, 80);
            this.btnOccupancyReport.TabIndex = 3;
            this.btnOccupancyReport.Text = "🏠 OCCUPANCY\r\n(Hostel Occupancy)";
            this.btnOccupancyReport.UseVisualStyleBackColor = false;
            this.btnOccupancyReport.Click += new System.EventHandler(this.btnOccupancyReport_Click);
            // 
            // btnRevenueSummary
            // 
            this.btnRevenueSummary.BackColor = System.Drawing.Color.Purple;
            this.btnRevenueSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRevenueSummary.ForeColor = System.Drawing.Color.White;
            this.btnRevenueSummary.Location = new System.Drawing.Point(340, 170);
            this.btnRevenueSummary.Name = "btnRevenueSummary";
            this.btnRevenueSummary.Size = new System.Drawing.Size(220, 80);
            this.btnRevenueSummary.TabIndex = 4;
            this.btnRevenueSummary.Text = "📊 REVENUE SUMMARY\r\n(Category-wise)";
            this.btnRevenueSummary.UseVisualStyleBackColor = false;
            this.btnRevenueSummary.Click += new System.EventHandler(this.btnRevenueSummary_Click);
            // 
            // btnIndividualVoucher
            // 
            this.btnIndividualVoucher.BackColor = System.Drawing.Color.Teal;
            this.btnIndividualVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividualVoucher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIndividualVoucher.ForeColor = System.Drawing.Color.White;
            this.btnIndividualVoucher.Location = new System.Drawing.Point(600, 170);
            this.btnIndividualVoucher.Name = "btnIndividualVoucher";
            this.btnIndividualVoucher.Size = new System.Drawing.Size(220, 80);
            this.btnIndividualVoucher.TabIndex = 5;
            this.btnIndividualVoucher.Text = "🧾 INDIVIDUAL VOUCHER\r\n(Student-wise)";
            this.btnIndividualVoucher.UseVisualStyleBackColor = false;
            this.btnIndividualVoucher.Click += new System.EventHandler(this.btnIndividualVoucher_Click);
            // 
            // frmReports
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS - Reports";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}