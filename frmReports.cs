using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UMS
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        // Get Downloads folder path
        private string GetDownloadsPath()
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            return downloadsPath;
        }

        // Show success message with file location
        private void ShowSuccessMessage(string fileName)
        {
            string fullPath = Path.Combine(GetDownloadsPath(), fileName);
            DialogResult result = MessageBox.Show(
                $"PDF Report Generated Successfully!\n\n📁 Location: {fullPath}\n\nDo you want to open the file?",
                "PDF Generated",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(fullPath);
            }
        }

        private void btnMeritList_Click(object sender, EventArgs e)
        {
            string fileName = $"Merit_List_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(GetDownloadsPath(), fileName);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Title
                Paragraph title = new Paragraph("UNIVERSITY MANAGEMENT SYSTEM", FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph subtitle = new Paragraph("MERIT LIST REPORT", FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Program: BSCS", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph(" "));

                // Merit Table
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 10f, 40f, 20f, 20f });

                // Headers
                string[] headers = { "Rank", "Student Name", "Merit Score", "Status" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD)));
                    cell.BackgroundColor = new BaseColor(0, 100, 128);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Data
                string[,] data = {
                    { "1", "Bilal Hassan", "92.5", "Eligible" },
                    { "2", "Fatima Ali", "88.3", "Eligible" },
                    { "3", "Ali Khan", "85.2", "Eligible" },
                    { "4", "Sara Ahmed", "78.6", "Eligible" },
                    { "5", "Usman Chaudhry", "76.4", "Not Eligible" }
                };

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(data[i, j], FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Total Eligible Students: 4", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph("Closing Merit: 70.0", FontFactory.GetFont(FontFactory.HELVETICA, 11)));

                doc.Close();
            }

            ShowSuccessMessage(fileName);
        }

        private void btnPendingFee_Click(object sender, EventArgs e)
        {
            string fileName = $"Pending_Fee_Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(GetDownloadsPath(), fileName);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Title
                Paragraph title = new Paragraph("UNIVERSITY MANAGEMENT SYSTEM", FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph subtitle = new Paragraph("PENDING FEE REPORT", FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph(" "));

                // Pending Fee Table
                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 8f, 20f, 15f, 15f, 15f, 12f });

                // Headers
                string[] headers = { "Sr#", "Student Name", "Roll No", "Amount (PKR)", "Due Date", "Days Late" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    cell.BackgroundColor = new BaseColor(220, 20, 60);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Data
                string[,] data = {
                    { "1", "Ali Khan", "2025-CS-01", "85,000", "10-May-2026", "25 days" },
                    { "2", "Sara Ahmed", "2025-CS-02", "85,000", "10-May-2026", "25 days" },
                    { "3", "Usman Chaudhry", "2025-CS-05", "85,000", "10-May-2026", "25 days" }
                };

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(data[i, j], FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Total Pending Amount: PKR 255,000", FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph("Total Defaulters: 3 students", FontFactory.GetFont(FontFactory.HELVETICA, 11)));

                doc.Close();
            }

            ShowSuccessMessage(fileName);
        }

        private void btnRefundReport_Click(object sender, EventArgs e)
        {
            string fileName = $"Refund_Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(GetDownloadsPath(), fileName);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Title
                Paragraph title = new Paragraph("UNIVERSITY MANAGEMENT SYSTEM", FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph subtitle = new Paragraph("REFUND REPORT", FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph(" "));

                // Refund Table
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 8f, 20f, 18f, 18f, 25f });

                // Headers
                string[] headers = { "Sr#", "Student Name", "Deposit Amount", "Refund Amount", "Reason" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    cell.BackgroundColor = new BaseColor(34, 139, 34);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Data
                string[,] data = {
                    { "1", "Ahmed Raza", "10,000", "8,000", "Left Hostel" },
                    { "2", "Zainab Ali", "10,000", "10,000", "Completed Degree" },
                    { "3", "Hamza Khan", "10,000", "5,000", "Shifted to Day Scholar" }
                };

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(data[i, j], FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Total Refunds Processed: PKR 23,000", FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD)));

                doc.Close();
            }

            ShowSuccessMessage(fileName);
        }

        private void btnOccupancyReport_Click(object sender, EventArgs e)
        {
            string fileName = $"Hostel_Occupancy_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(GetDownloadsPath(), fileName);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Title
                Paragraph title = new Paragraph("UNIVERSITY MANAGEMENT SYSTEM", FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph subtitle = new Paragraph("HOSTEL OCCUPANCY REPORT", FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph(" "));

                // Occupancy Table
                PdfPTable table = new PdfPTable(6);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 20f, 15f, 15f, 12f, 15f, 15f });

                // Headers
                string[] headers = { "Hostel Name", "Total Rooms", "Occupied", "Vacant", "Capacity", "Occupancy%" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD)));
                    cell.BackgroundColor = new BaseColor(184, 134, 11);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Data
                string[,] data = {
                    { "Boys Hostel A", "20", "15", "5", "2 per room", "75%" },
                    { "Boys Hostel B", "15", "12", "3", "2 per room", "80%" },
                    { "Girls Hostel A", "25", "22", "3", "2 per room", "88%" }
                };

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(data[i, j], FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Total Capacity: 60 rooms", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph("Total Occupied: 49 rooms", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph("Overall Occupancy: 81.7%", FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD)));

                doc.Close();
            }

            ShowSuccessMessage(fileName);
        }

        private void btnRevenueSummary_Click(object sender, EventArgs e)
        {
            string fileName = $"Revenue_Summary_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(GetDownloadsPath(), fileName);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Title
                Paragraph title = new Paragraph("UNIVERSITY MANAGEMENT SYSTEM", FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                Paragraph subtitle = new Paragraph("REVENUE SUMMARY REPORT", FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph(" "));

                // Revenue Table
                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 40f, 30f, 20f });

                // Headers
                string[] headers = { "Category", "Amount (PKR)", "Percentage" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD)));
                    cell.BackgroundColor = new BaseColor(128, 0, 128);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cell);
                }

                // Data
                string[,] data = {
                    { "Tuition Fees", "2,250,000", "65.2%" },
                    { "Hostel Fees", "450,000", "13.0%" },
                    { "Transport Fees", "120,000", "3.5%" },
                    { "Examination Fees", "250,000", "7.2%" },
                    { "Other Fees", "380,000", "11.1%" }
                };

                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(data[i, j], FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("TOTAL REVENUE: PKR 3,450,000", FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD)));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Hostel Students Revenue: PKR 1,200,000", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                doc.Add(new Paragraph("Day Scholar Revenue: PKR 2,250,000", FontFactory.GetFont(FontFactory.HELVETICA, 11)));

                doc.Close();
            }

            ShowSuccessMessage(fileName);
        }

        private void btnIndividualVoucher_Click(object sender, EventArgs e)
        {
            string rollNo = ShowInputDialog("Enter Student Roll No:", "Individual Voucher", "2025-CS-01");

            if (!string.IsNullOrEmpty(rollNo))
            {
                string fileName = $"Voucher_{rollNo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string filePath = Path.Combine(GetDownloadsPath(), fileName);

                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Title
                    Paragraph title = new Paragraph("UNIVERSITY MANAGEMENT SYSTEM", FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    Paragraph subtitle = new Paragraph("INDIVIDUAL FEE VOUCHER", FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD));
                    subtitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitle);

                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph("Student Information", FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD)));
                    doc.Add(new Paragraph("Student Name: Ali Khan", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                    doc.Add(new Paragraph("Roll No: " + rollNo, FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                    doc.Add(new Paragraph("Program: BSCS", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                    doc.Add(new Paragraph("Category: Hostel Student", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                    doc.Add(new Paragraph("Semester: Spring 2026", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                    doc.Add(new Paragraph(" "));

                    doc.Add(new Paragraph("Fee Breakdown", FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.BOLD)));

                    PdfPTable feeTable = new PdfPTable(2);
                    feeTable.WidthPercentage = 80;
                    feeTable.SetWidths(new float[] { 60f, 40f });

                    string[,] fees = {
                        { "Tuition Fee:", "PKR 45,000" },
                        { "Room Rent:", "PKR 8,000" },
                        { "Mess Charges:", "PKR 5,000" },
                        { "Utilities:", "PKR 2,000" },
                        { "Maintenance:", "PKR 1,500" },
                        { "Examination Fee:", "PKR 5,000" },
                        { "", "" },
                        { "TOTAL:", "PKR 66,500" }
                    };

                    for (int i = 0; i < fees.GetLength(0); i++)
                    {
                        iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                        iTextSharp.text.Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD);

                        PdfPCell cell1 = new PdfPCell(new Phrase(fees[i, 0], i == 7 ? boldFont : normalFont));
                        PdfPCell cell2 = new PdfPCell(new Phrase(fees[i, 1], i == 7 ? boldFont : normalFont));
                        cell2.HorizontalAlignment = Element.ALIGN_RIGHT;

                        feeTable.AddCell(cell1);
                        feeTable.AddCell(cell2);
                    }

                    doc.Add(feeTable);
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph("Due Date: 30-June-2026", FontFactory.GetFont(FontFactory.HELVETICA, 11)));
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph("Generated on: " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 10)));

                    doc.Close();
                }

                ShowSuccessMessage(fileName);
            }
        }

        // Custom InputBox method
        private string ShowInputDialog(string prompt, string title, string defaultValue = "")
        {
            Form inputForm = new Form();
            Label lblPrompt = new Label();
            TextBox txtInput = new TextBox();
            Button btnOK = new Button();
            Button btnCancel = new Button();

            inputForm.Text = title;
            inputForm.Size = new System.Drawing.Size(400, 180);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;

            lblPrompt.Text = prompt;
            lblPrompt.Location = new System.Drawing.Point(20, 20);
            lblPrompt.Size = new System.Drawing.Size(350, 25);

            txtInput.Text = defaultValue;
            txtInput.Location = new System.Drawing.Point(20, 50);
            txtInput.Size = new System.Drawing.Size(350, 23);

            btnOK.Text = "OK";
            btnOK.Location = new System.Drawing.Point(180, 90);
            btnOK.Size = new System.Drawing.Size(80, 30);
            btnOK.DialogResult = DialogResult.OK;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(270, 90);
            btnCancel.Size = new System.Drawing.Size(80, 30);
            btnCancel.DialogResult = DialogResult.Cancel;

            inputForm.Controls.Add(lblPrompt);
            inputForm.Controls.Add(txtInput);
            inputForm.Controls.Add(btnOK);
            inputForm.Controls.Add(btnCancel);

            inputForm.AcceptButton = btnOK;
            inputForm.CancelButton = btnCancel;

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                return txtInput.Text;
            }
            else
            {
                return "";
            }
        }
    }
}