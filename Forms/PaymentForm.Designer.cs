namespace GymApplication.Forms
{
    partial class PaymentForm
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
            this.lblPricePayment = new System.Windows.Forms.Label();
            this.lblPackageIdPayment = new System.Windows.Forms.Label();
            this.lblCustomerIdPayment = new System.Windows.Forms.Label();
            this.lblCreatedatPayment = new System.Windows.Forms.Label();
            this.txtPricePayment = new System.Windows.Forms.TextBox();
            this.txtCreatedAtPayment = new System.Windows.Forms.TextBox();
            this.cmbxCustPayment = new System.Windows.Forms.ComboBox();
            this.cmbxPackPayment = new System.Windows.Forms.ComboBox();
            this.dgvPaymentForm = new System.Windows.Forms.DataGridView();
            this.PaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPricePayment
            // 
            this.lblPricePayment.AutoSize = true;
            this.lblPricePayment.Location = new System.Drawing.Point(34, 20);
            this.lblPricePayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePayment.Name = "lblPricePayment";
            this.lblPricePayment.Size = new System.Drawing.Size(40, 15);
            this.lblPricePayment.TabIndex = 0;
            this.lblPricePayment.Text = "Price";
            // 
            // lblPackageIdPayment
            // 
            this.lblPackageIdPayment.AutoSize = true;
            this.lblPackageIdPayment.Location = new System.Drawing.Point(37, 240);
            this.lblPackageIdPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageIdPayment.Name = "lblPackageIdPayment";
            this.lblPackageIdPayment.Size = new System.Drawing.Size(62, 15);
            this.lblPackageIdPayment.TabIndex = 1;
            this.lblPackageIdPayment.Text = "Package";
            // 
            // lblCustomerIdPayment
            // 
            this.lblCustomerIdPayment.AutoSize = true;
            this.lblCustomerIdPayment.Location = new System.Drawing.Point(37, 163);
            this.lblCustomerIdPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerIdPayment.Name = "lblCustomerIdPayment";
            this.lblCustomerIdPayment.Size = new System.Drawing.Size(68, 15);
            this.lblCustomerIdPayment.TabIndex = 2;
            this.lblCustomerIdPayment.Text = "Customer";
            // 
            // lblCreatedatPayment
            // 
            this.lblCreatedatPayment.AutoSize = true;
            this.lblCreatedatPayment.Location = new System.Drawing.Point(34, 89);
            this.lblCreatedatPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedatPayment.Name = "lblCreatedatPayment";
            this.lblCreatedatPayment.Size = new System.Drawing.Size(69, 15);
            this.lblCreatedatPayment.TabIndex = 3;
            this.lblCreatedatPayment.Text = "CreatedAt";
            // 
            // txtPricePayment
            // 
            this.txtPricePayment.Location = new System.Drawing.Point(38, 55);
            this.txtPricePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPricePayment.Name = "txtPricePayment";
            this.txtPricePayment.Size = new System.Drawing.Size(217, 21);
            this.txtPricePayment.TabIndex = 4;
            // 
            // txtCreatedAtPayment
            // 
            this.txtCreatedAtPayment.Location = new System.Drawing.Point(38, 120);
            this.txtCreatedAtPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCreatedAtPayment.Name = "txtCreatedAtPayment";
            this.txtCreatedAtPayment.Size = new System.Drawing.Size(217, 21);
            this.txtCreatedAtPayment.TabIndex = 5;
            // 
            // cmbxCustPayment
            // 
            this.cmbxCustPayment.FormattingEnabled = true;
            this.cmbxCustPayment.Location = new System.Drawing.Point(40, 193);
            this.cmbxCustPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbxCustPayment.Name = "cmbxCustPayment";
            this.cmbxCustPayment.Size = new System.Drawing.Size(217, 23);
            this.cmbxCustPayment.TabIndex = 6;
            // 
            // cmbxPackPayment
            // 
            this.cmbxPackPayment.FormattingEnabled = true;
            this.cmbxPackPayment.Location = new System.Drawing.Point(39, 272);
            this.cmbxPackPayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbxPackPayment.Name = "cmbxPackPayment";
            this.cmbxPackPayment.Size = new System.Drawing.Size(217, 23);
            this.cmbxPackPayment.TabIndex = 7;
            // 
            // dgvPaymentForm
            // 
            this.dgvPaymentForm.AllowUserToAddRows = false;
            this.dgvPaymentForm.AllowUserToDeleteRows = false;
            this.dgvPaymentForm.AllowUserToResizeColumns = false;
            this.dgvPaymentForm.AllowUserToResizeRows = false;
            this.dgvPaymentForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentForm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPaymentForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentId,
            this.PaymentPrice,
            this.CreatedAt,
            this.CustomerId,
            this.PackageID,
            this.PackageEntry});
            this.dgvPaymentForm.Location = new System.Drawing.Point(359, 20);
            this.dgvPaymentForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPaymentForm.Name = "dgvPaymentForm";
            this.dgvPaymentForm.Size = new System.Drawing.Size(422, 424);
            this.dgvPaymentForm.TabIndex = 8;
            this.dgvPaymentForm.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPaymentForm_RowHeaderMouseDoubleClick);
            // 
            // PaymentId
            // 
            this.PaymentId.HeaderText = "Id";
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.Visible = false;
            // 
            // PaymentPrice
            // 
            this.PaymentPrice.HeaderText = "Price";
            this.PaymentPrice.Name = "PaymentPrice";
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "CreatedAt";
            this.CreatedAt.Name = "CreatedAt";
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Customer";
            this.CustomerId.Name = "CustomerId";
            // 
            // PackageID
            // 
            this.PackageID.HeaderText = "Package";
            this.PackageID.Name = "PackageID";
            // 
            // PackageEntry
            // 
            this.PackageEntry.HeaderText = "Entry Quantity";
            this.PackageEntry.Name = "PackageEntry";
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSavePayment.Location = new System.Drawing.Point(34, 386);
            this.btnSavePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(100, 38);
            this.btnSavePayment.TabIndex = 9;
            this.btnSavePayment.Text = "Save";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.BtnSavePayment_Click);
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdatePayment.Location = new System.Drawing.Point(155, 386);
            this.btnUpdatePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(100, 38);
            this.btnUpdatePayment.TabIndex = 10;
            this.btnUpdatePayment.Text = "Update";
            this.btnUpdatePayment.UseVisualStyleBackColor = false;
            this.btnUpdatePayment.Click += new System.EventHandler(this.BtnUpdatePayment_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.BackColor = System.Drawing.Color.Brown;
            this.btnDeletePayment.Location = new System.Drawing.Point(67, 440);
            this.btnDeletePayment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(159, 35);
            this.btnDeletePayment.TabIndex = 11;
            this.btnDeletePayment.Text = "Delete";
            this.btnDeletePayment.UseVisualStyleBackColor = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.BtnDeletePayment_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(39, 329);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 21);
            this.quantity.TabIndex = 12;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(826, 519);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnSavePayment);
            this.Controls.Add(this.dgvPaymentForm);
            this.Controls.Add(this.cmbxPackPayment);
            this.Controls.Add(this.cmbxCustPayment);
            this.Controls.Add(this.txtCreatedAtPayment);
            this.Controls.Add(this.txtPricePayment);
            this.Controls.Add(this.lblCreatedatPayment);
            this.Controls.Add(this.lblCustomerIdPayment);
            this.Controls.Add(this.lblPackageIdPayment);
            this.Controls.Add(this.lblPricePayment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaymentForm_FormClosing);
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPricePayment;
        private System.Windows.Forms.Label lblPackageIdPayment;
        private System.Windows.Forms.Label lblCustomerIdPayment;
        private System.Windows.Forms.Label lblCreatedatPayment;
        private System.Windows.Forms.TextBox txtPricePayment;
        private System.Windows.Forms.TextBox txtCreatedAtPayment;
        private System.Windows.Forms.ComboBox cmbxCustPayment;
        private System.Windows.Forms.ComboBox cmbxPackPayment;
        private System.Windows.Forms.DataGridView dgvPaymentForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageEntry;
        private System.Windows.Forms.NumericUpDown quantity;
    }
}