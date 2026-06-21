namespace UniversityManagementSystem
{
    partial class frmHostelSetup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHostels;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.DataGridView dgvHostels;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblHostelName;
        private System.Windows.Forms.TextBox txtHostelName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblWarden;
        private System.Windows.Forms.TextBox txtWarden;
        private System.Windows.Forms.Button btnAddHostel;
        private System.Windows.Forms.Label lblHostel;
        private System.Windows.Forms.ComboBox cmbHostel;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnViewOccupancy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHostels = new System.Windows.Forms.TabPage();
            this.btnAddHostel = new System.Windows.Forms.Button();
            this.txtWarden = new System.Windows.Forms.TextBox();
            this.lblWarden = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtHostelName = new System.Windows.Forms.TextBox();
            this.lblHostelName = new System.Windows.Forms.Label();
            this.dgvHostels = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.btnViewOccupancy = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblRent = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.cmbHostel = new System.Windows.Forms.ComboBox();
            this.lblHostel = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHostels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostels)).BeginInit();
            this.tabRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1244, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(330, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOSTEL SETUP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHostels);
            this.tabControl1.Controls.Add(this.tabRooms);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 540);
            this.tabControl1.TabIndex = 1;
            // 
            // tabHostels
            // 
            this.tabHostels.BackColor = System.Drawing.Color.White;
            this.tabHostels.Controls.Add(this.btnAddHostel);
            this.tabHostels.Controls.Add(this.txtWarden);
            this.tabHostels.Controls.Add(this.lblWarden);
            this.tabHostels.Controls.Add(this.txtAddress);
            this.tabHostels.Controls.Add(this.lblAddress);
            this.tabHostels.Controls.Add(this.txtHostelName);
            this.tabHostels.Controls.Add(this.lblHostelName);
            this.tabHostels.Controls.Add(this.dgvHostels);
            this.tabHostels.Location = new System.Drawing.Point(8, 51);
            this.tabHostels.Name = "tabHostels";
            this.tabHostels.Padding = new System.Windows.Forms.Padding(3);
            this.tabHostels.Size = new System.Drawing.Size(1228, 481);
            this.tabHostels.TabIndex = 0;
            this.tabHostels.Text = "Manage Hostels";
            // 
            // btnAddHostel
            // 
            this.btnAddHostel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddHostel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHostel.ForeColor = System.Drawing.Color.White;
            this.btnAddHostel.Location = new System.Drawing.Point(140, 136);
            this.btnAddHostel.Name = "btnAddHostel";
            this.btnAddHostel.Size = new System.Drawing.Size(120, 44);
            this.btnAddHostel.TabIndex = 7;
            this.btnAddHostel.Text = "ADD HOSTEL";
            this.btnAddHostel.UseVisualStyleBackColor = false;
            this.btnAddHostel.Click += new System.EventHandler(this.btnAddHostel_Click);
            // 
            // txtWarden
            // 
            this.txtWarden.Location = new System.Drawing.Point(130, 87);
            this.txtWarden.Name = "txtWarden";
            this.txtWarden.Size = new System.Drawing.Size(200, 43);
            this.txtWarden.TabIndex = 6;
            // 
            // lblWarden
            // 
            this.lblWarden.AutoSize = true;
            this.lblWarden.Location = new System.Drawing.Point(20, 90);
            this.lblWarden.Name = "lblWarden";
            this.lblWarden.Size = new System.Drawing.Size(115, 37);
            this.lblWarden.TabIndex = 5;
            this.lblWarden.Text = "Warden:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 52);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 43);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(117, 37);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // txtHostelName
            // 
            this.txtHostelName.Location = new System.Drawing.Point(130, 17);
            this.txtHostelName.Name = "txtHostelName";
            this.txtHostelName.Size = new System.Drawing.Size(200, 43);
            this.txtHostelName.TabIndex = 2;
            // 
            // lblHostelName
            // 
            this.lblHostelName.AutoSize = true;
            this.lblHostelName.Location = new System.Drawing.Point(20, 20);
            this.lblHostelName.Name = "lblHostelName";
            this.lblHostelName.Size = new System.Drawing.Size(177, 37);
            this.lblHostelName.TabIndex = 1;
            this.lblHostelName.Text = "Hostel Name:";
            // 
            // dgvHostels
            // 
            this.dgvHostels.AllowUserToAddRows = false;
            this.dgvHostels.BackgroundColor = System.Drawing.Color.White;
            this.dgvHostels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHostels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvHostels.Location = new System.Drawing.Point(18, 189);
            this.dgvHostels.Name = "dgvHostels";
            this.dgvHostels.RowHeadersWidth = 82;
            this.dgvHostels.Size = new System.Drawing.Size(850, 300);
            this.dgvHostels.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Hostel Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Warden";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Rooms";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // tabRooms
            // 
            this.tabRooms.BackColor = System.Drawing.Color.White;
            this.tabRooms.Controls.Add(this.btnViewOccupancy);
            this.tabRooms.Controls.Add(this.btnAddRoom);
            this.tabRooms.Controls.Add(this.txtRent);
            this.tabRooms.Controls.Add(this.lblRent);
            this.tabRooms.Controls.Add(this.txtCapacity);
            this.tabRooms.Controls.Add(this.lblCapacity);
            this.tabRooms.Controls.Add(this.txtRoomNumber);
            this.tabRooms.Controls.Add(this.lblRoomNumber);
            this.tabRooms.Controls.Add(this.cmbHostel);
            this.tabRooms.Controls.Add(this.lblHostel);
            this.tabRooms.Controls.Add(this.dgvRooms);
            this.tabRooms.Location = new System.Drawing.Point(8, 51);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(884, 481);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "Manage Rooms";
            // 
            // btnViewOccupancy
            // 
            this.btnViewOccupancy.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnViewOccupancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOccupancy.ForeColor = System.Drawing.Color.White;
            this.btnViewOccupancy.Location = new System.Drawing.Point(230, 65);
            this.btnViewOccupancy.Name = "btnViewOccupancy";
            this.btnViewOccupancy.Size = new System.Drawing.Size(150, 35);
            this.btnViewOccupancy.TabIndex = 10;
            this.btnViewOccupancy.Text = "VIEW OCCUPANCY";
            this.btnViewOccupancy.UseVisualStyleBackColor = false;
            this.btnViewOccupancy.Click += new System.EventHandler(this.btnViewOccupancy_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(230, 17);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 35);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "ADD ROOM";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(100, 122);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(100, 43);
            this.txtRent.TabIndex = 8;
            this.txtRent.Text = "8000";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(20, 125);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(76, 37);
            this.lblRent.TabIndex = 7;
            this.lblRent.Text = "Rent:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(100, 87);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(100, 43);
            this.txtCapacity.TabIndex = 6;
            this.txtCapacity.Text = "2";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(20, 90);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(125, 37);
            this.lblCapacity.TabIndex = 5;
            this.lblCapacity.Text = "Capacity:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(100, 52);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 43);
            this.txtRoomNumber.TabIndex = 4;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 55);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(93, 37);
            this.lblRoomNumber.TabIndex = 3;
            this.lblRoomNumber.Text = "Room:";
            // 
            // cmbHostel
            // 
            this.cmbHostel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHostel.Items.AddRange(new object[] {
            "Select Hostel",
            "Boys Hostel A",
            "Boys Hostel B",
            "Girls Hostel A"});
            this.cmbHostel.Location = new System.Drawing.Point(100, 17);
            this.cmbHostel.Name = "cmbHostel";
            this.cmbHostel.Size = new System.Drawing.Size(200, 45);
            this.cmbHostel.TabIndex = 2;
            // 
            // lblHostel
            // 
            this.lblHostel.AutoSize = true;
            this.lblHostel.Location = new System.Drawing.Point(20, 20);
            this.lblHostel.Name = "lblHostel";
            this.lblHostel.Size = new System.Drawing.Size(99, 37);
            this.lblHostel.TabIndex = 1;
            this.lblHostel.Text = "Hostel:";
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvRooms.Location = new System.Drawing.Point(20, 180);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RowHeadersWidth = 82;
            this.dgvRooms.Size = new System.Drawing.Size(850, 300);
            this.dgvRooms.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hostel";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Room No";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Rent (PKR)";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Status";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // frmHostelSetup
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHostelSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS - Hostel Setup";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHostels.ResumeLayout(false);
            this.tabHostels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostels)).EndInit();
            this.tabRooms.ResumeLayout(false);
            this.tabRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}