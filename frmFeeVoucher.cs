using System;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class frmFeeVoucher : Form
    {
        public frmFeeVoucher()
        {
            InitializeComponent();
        }

        private void btnGenerateVoucher_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a student!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentName = cmbStudent.Text;
            string category = (studentName.Contains("Ali") || studentName.Contains("Bilal")) ? "Hostel Student" : "Day Scholar Student";

            int totalAmount = CalculateTotalAmount(category);

            dgvVouchers.Rows.Add("V-100" + (dgvVouchers.Rows.Count + 1), studentName, category, totalAmount, DateTime.Now.AddDays(15).ToShortDateString(), "Unpaid");

            MessageBox.Show($"Fee Voucher Generated for {studentName}!\n\nCategory: {category}\nTotal Amount: PKR {totalAmount:N0}\nDue Date: {DateTime.Now.AddDays(15).ToShortDateString()}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int CalculateTotalAmount(string category)
        {
            int total = 45000; // Tuition Fee

            if (category == "Hostel Student")
            {
                total += 8000 + 5000 + 2000 + 1500; // Rent + Mess + Utilities + Maintenance
            }
            else
            {
                total += 4000 + 2000 + 1500; // Transport + Library + Sports
            }

            total += 5000; // Examination Fee

            return total;
        }

        private void btnRecordPayment_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a voucher to record payment!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string voucherNo = dgvVouchers.SelectedRows[0].Cells[0].Value.ToString();
            string amount = dgvVouchers.SelectedRows[0].Cells[3].Value.ToString();

            PaymentForm paymentForm = new PaymentForm(voucherNo, amount);
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                dgvVouchers.SelectedRows[0].Cells[5].Value = "Paid";
                MessageBox.Show($"Payment recorded successfully for Voucher {voucherNo}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintVoucher_Click(object sender, EventArgs e)
        {
            if (dgvVouchers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a voucher to print!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string voucherNo = dgvVouchers.SelectedRows[0].Cells[0].Value.ToString();
            string studentName = dgvVouchers.SelectedRows[0].Cells[1].Value.ToString();
            string category = dgvVouchers.SelectedRows[0].Cells[2].Value.ToString();
            string amount = dgvVouchers.SelectedRows[0].Cells[3].Value.ToString();
            string dueDate = dgvVouchers.SelectedRows[0].Cells[4].Value.ToString();

            MessageBox.Show($"PRINTING FEE VOUCHER\n\n" +
                $"═══════════════════════════════\n" +
                $"UNIVERSITY MANAGEMENT SYSTEM\n" +
                $"═══════════════════════════════\n\n" +
                $"Voucher No: {voucherNo}\n" +
                $"Student Name: {studentName}\n" +
                $"Category: {category}\n" +
                $"Total Amount: PKR {amount}\n" +
                $"Due Date: {dueDate}\n\n" +
                $"═══════════════════════════════\n" +
                $"PDF generation will be available in final version",
                "Print Preview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter student name or roll no to search!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Searching for: {searchText}\n\nResults will be displayed in the voucher list.\n(This feature will connect to database in final version)",
                "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Payment Dialog Form
    public class PaymentForm : Form
    {
        private Label lblVoucherNo;
        private Label lblAmount;
        private Label lblPaymentDate;
        private Label lblPaymentMethod;
        private TextBox txtVoucherNo;
        private TextBox txtAmount;
        private DateTimePicker dtpPaymentDate;
        private ComboBox cmbPaymentMethod;
        private Button btnConfirm;
        private Button btnCancel;

        public PaymentForm(string voucherNo, string amount)
        {
            InitializeComponent();
            txtVoucherNo.Text = voucherNo;
            txtAmount.Text = amount;
            dtpPaymentDate.Value = DateTime.Now;
        }

        private void InitializeComponent()
        {
            this.lblVoucherNo = new Label();
            this.lblAmount = new Label();
            this.lblPaymentDate = new Label();
            this.lblPaymentMethod = new Label();
            this.txtVoucherNo = new TextBox();
            this.txtAmount = new TextBox();
            this.dtpPaymentDate = new DateTimePicker();
            this.cmbPaymentMethod = new ComboBox();
            this.btnConfirm = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            this.Text = "Record Payment";
            this.Size = new System.Drawing.Size(400, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            lblVoucherNo.Text = "Voucher No:";
            lblVoucherNo.Location = new System.Drawing.Point(30, 30);
            lblVoucherNo.Size = new System.Drawing.Size(80, 25);

            txtVoucherNo.Location = new System.Drawing.Point(140, 30);
            txtVoucherNo.Size = new System.Drawing.Size(200, 23);
            txtVoucherNo.ReadOnly = true;

            lblAmount.Text = "Amount:";
            lblAmount.Location = new System.Drawing.Point(30, 70);
            lblAmount.Size = new System.Drawing.Size(80, 25);

            txtAmount.Location = new System.Drawing.Point(140, 70);
            txtAmount.Size = new System.Drawing.Size(200, 23);
            txtAmount.ReadOnly = true;

            lblPaymentDate.Text = "Payment Date:";
            lblPaymentDate.Location = new System.Drawing.Point(30, 110);
            lblPaymentDate.Size = new System.Drawing.Size(100, 25);

            dtpPaymentDate.Location = new System.Drawing.Point(140, 110);
            dtpPaymentDate.Size = new System.Drawing.Size(200, 23);

            lblPaymentMethod.Text = "Payment Method:";
            lblPaymentMethod.Location = new System.Drawing.Point(30, 150);
            lblPaymentMethod.Size = new System.Drawing.Size(100, 25);

            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Bank Transfer", "Credit Card", "Debit Card" });
            cmbPaymentMethod.Location = new System.Drawing.Point(140, 150);
            cmbPaymentMethod.Size = new System.Drawing.Size(200, 23);
            cmbPaymentMethod.SelectedIndex = 0;

            btnConfirm.Text = "CONFIRM PAYMENT";
            btnConfirm.BackColor = System.Drawing.Color.ForestGreen;
            btnConfirm.ForeColor = System.Drawing.Color.White;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Location = new System.Drawing.Point(80, 200);
            btnConfirm.Size = new System.Drawing.Size(110, 40);
            btnConfirm.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

            btnCancel.Text = "CANCEL";
            btnCancel.BackColor = System.Drawing.Color.Gray;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(210, 200);
            btnCancel.Size = new System.Drawing.Size(110, 40);
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.Add(lblVoucherNo);
            this.Controls.Add(txtVoucherNo);
            this.Controls.Add(lblAmount);
            this.Controls.Add(txtAmount);
            this.Controls.Add(lblPaymentDate);
            this.Controls.Add(dtpPaymentDate);
            this.Controls.Add(lblPaymentMethod);
            this.Controls.Add(cmbPaymentMethod);
            this.Controls.Add(btnConfirm);
            this.Controls.Add(btnCancel);

            this.ResumeLayout();
        }
    }
}