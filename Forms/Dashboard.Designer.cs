namespace GymApplication.Forms
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportingDashboard = new System.Windows.Forms.Button();
            this.btnMenuOrderDashboard = new System.Windows.Forms.Button();
            this.btnMenuItemDashbrd = new System.Windows.Forms.Button();
            this.btnPaymentDashbrd = new System.Windows.Forms.Button();
            this.btnPackageDashbrd = new System.Windows.Forms.Button();
            this.btnCustomerDashbrd = new System.Windows.Forms.Button();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomersLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnReportingDashboard);
            this.panel1.Controls.Add(this.btnMenuOrderDashboard);
            this.panel1.Controls.Add(this.btnMenuItemDashbrd);
            this.panel1.Controls.Add(this.btnPaymentDashbrd);
            this.panel1.Controls.Add(this.btnPackageDashbrd);
            this.panel1.Controls.Add(this.btnCustomerDashbrd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 408);
            this.panel1.TabIndex = 0;
            // 
            // btnReportingDashboard
            // 
            this.btnReportingDashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnReportingDashboard.Location = new System.Drawing.Point(26, 347);
            this.btnReportingDashboard.Name = "btnReportingDashboard";
            this.btnReportingDashboard.Size = new System.Drawing.Size(75, 41);
            this.btnReportingDashboard.TabIndex = 5;
            this.btnReportingDashboard.Text = "Reporting";
            this.btnReportingDashboard.UseVisualStyleBackColor = false;
            this.btnReportingDashboard.Click += new System.EventHandler(this.BtnReportingDashboard_Click);
            // 
            // btnMenuOrderDashboard
            // 
            this.btnMenuOrderDashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMenuOrderDashboard.Location = new System.Drawing.Point(26, 281);
            this.btnMenuOrderDashboard.Name = "btnMenuOrderDashboard";
            this.btnMenuOrderDashboard.Size = new System.Drawing.Size(75, 39);
            this.btnMenuOrderDashboard.TabIndex = 4;
            this.btnMenuOrderDashboard.Text = "MenuOrder";
            this.btnMenuOrderDashboard.UseVisualStyleBackColor = false;
            this.btnMenuOrderDashboard.Click += new System.EventHandler(this.BtnMenuOrderDashboard_Click);
            // 
            // btnMenuItemDashbrd
            // 
            this.btnMenuItemDashbrd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnMenuItemDashbrd.Location = new System.Drawing.Point(26, 218);
            this.btnMenuItemDashbrd.Name = "btnMenuItemDashbrd";
            this.btnMenuItemDashbrd.Size = new System.Drawing.Size(75, 38);
            this.btnMenuItemDashbrd.TabIndex = 3;
            this.btnMenuItemDashbrd.Text = "MenuItem";
            this.btnMenuItemDashbrd.UseVisualStyleBackColor = false;
            this.btnMenuItemDashbrd.Click += new System.EventHandler(this.BtnMenuItemDashbrd_Click);
            // 
            // btnPaymentDashbrd
            // 
            this.btnPaymentDashbrd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPaymentDashbrd.Location = new System.Drawing.Point(26, 149);
            this.btnPaymentDashbrd.Name = "btnPaymentDashbrd";
            this.btnPaymentDashbrd.Size = new System.Drawing.Size(75, 36);
            this.btnPaymentDashbrd.TabIndex = 2;
            this.btnPaymentDashbrd.Text = "Payment";
            this.btnPaymentDashbrd.UseVisualStyleBackColor = false;
            this.btnPaymentDashbrd.Click += new System.EventHandler(this.BtnPaymentDashbrd_Click);
            // 
            // btnPackageDashbrd
            // 
            this.btnPackageDashbrd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPackageDashbrd.Location = new System.Drawing.Point(26, 85);
            this.btnPackageDashbrd.Name = "btnPackageDashbrd";
            this.btnPackageDashbrd.Size = new System.Drawing.Size(75, 37);
            this.btnPackageDashbrd.TabIndex = 1;
            this.btnPackageDashbrd.Text = "Package";
            this.btnPackageDashbrd.UseVisualStyleBackColor = false;
            this.btnPackageDashbrd.Click += new System.EventHandler(this.BtnPackageDashbrd_Click);
            // 
            // btnCustomerDashbrd
            // 
            this.btnCustomerDashbrd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCustomerDashbrd.Location = new System.Drawing.Point(26, 15);
            this.btnCustomerDashbrd.Name = "btnCustomerDashbrd";
            this.btnCustomerDashbrd.Size = new System.Drawing.Size(75, 36);
            this.btnCustomerDashbrd.TabIndex = 0;
            this.btnCustomerDashbrd.Text = "Customer";
            this.btnCustomerDashbrd.UseVisualStyleBackColor = false;
            this.btnCustomerDashbrd.Click += new System.EventHandler(this.BtnCustomerDashbrd_Click);
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AllowUserToDeleteRows = false;
            this.dgvDashboard.AllowUserToResizeColumns = false;
            this.dgvDashboard.AllowUserToResizeRows = false;
            this.dgvDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomersFirstName,
            this.CustomersLastname,
            this.Package,
            this.PackagePrice,
            this.EntryQuantity,
            this.PaymentEndDate});
            this.dgvDashboard.Location = new System.Drawing.Point(174, 27);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.Size = new System.Drawing.Size(586, 373);
            this.dgvDashboard.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CustomersFirstName
            // 
            this.CustomersFirstName.HeaderText = "FirstName";
            this.CustomersFirstName.Name = "CustomersFirstName";
            this.CustomersFirstName.ReadOnly = true;
            // 
            // CustomersLastname
            // 
            this.CustomersLastname.HeaderText = "Lastname";
            this.CustomersLastname.Name = "CustomersLastname";
            this.CustomersLastname.ReadOnly = true;
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "Price";
            this.PackagePrice.Name = "PackagePrice";
            this.PackagePrice.ReadOnly = true;
            // 
            // EntryQuantity
            // 
            this.EntryQuantity.HeaderText = "Entry Quantity";
            this.EntryQuantity.Name = "EntryQuantity";
            this.EntryQuantity.ReadOnly = true;
            // 
            // PaymentEndDate
            // 
            this.PaymentEndDate.HeaderText = "EndDate";
            this.PaymentEndDate.Name = "PaymentEndDate";
            this.PaymentEndDate.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuOrderDashboard;
        private System.Windows.Forms.Button btnMenuItemDashbrd;
        private System.Windows.Forms.Button btnPaymentDashbrd;
        private System.Windows.Forms.Button btnPackageDashbrd;
        private System.Windows.Forms.Button btnCustomerDashbrd;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Button btnReportingDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomersFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomersLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentEndDate;
    }
}