namespace GymApplication.Forms
{
    partial class ReportingForm
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
            this.lblCustomerReporting = new System.Windows.Forms.Label();
            this.cmbReporting = new System.Windows.Forms.ComboBox();
            this.tnSaveReporting = new System.Windows.Forms.Button();
            this.dgvReporting = new System.Windows.Forms.DataGridView();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporting)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerReporting
            // 
            this.lblCustomerReporting.AutoSize = true;
            this.lblCustomerReporting.Location = new System.Drawing.Point(29, 26);
            this.lblCustomerReporting.Name = "lblCustomerReporting";
            this.lblCustomerReporting.Size = new System.Drawing.Size(51, 13);
            this.lblCustomerReporting.TabIndex = 0;
            this.lblCustomerReporting.Text = "Customer";
            // 
            // cmbReporting
            // 
            this.cmbReporting.FormattingEnabled = true;
            this.cmbReporting.Location = new System.Drawing.Point(23, 61);
            this.cmbReporting.Name = "cmbReporting";
            this.cmbReporting.Size = new System.Drawing.Size(153, 21);
            this.cmbReporting.TabIndex = 1;
            // 
            // tnSaveReporting
            // 
            this.tnSaveReporting.Location = new System.Drawing.Point(32, 129);
            this.tnSaveReporting.Name = "tnSaveReporting";
            this.tnSaveReporting.Size = new System.Drawing.Size(144, 54);
            this.tnSaveReporting.TabIndex = 2;
            this.tnSaveReporting.Text = "Save";
            this.tnSaveReporting.UseVisualStyleBackColor = true;
            this.tnSaveReporting.Click += new System.EventHandler(this.TnSaveReporting_Click);
            // 
            // dgvReporting
            // 
            this.dgvReporting.AllowUserToAddRows = false;
            this.dgvReporting.AllowUserToDeleteRows = false;
            this.dgvReporting.AllowUserToResizeColumns = false;
            this.dgvReporting.AllowUserToResizeRows = false;
            this.dgvReporting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer,
            this.EntryQuantity,
            this.Deadline});
            this.dgvReporting.Location = new System.Drawing.Point(275, 12);
            this.dgvReporting.Name = "dgvReporting";
            this.dgvReporting.Size = new System.Drawing.Size(501, 264);
            this.dgvReporting.TabIndex = 3;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // EntryQuantity
            // 
            this.EntryQuantity.HeaderText = "EntryQuantity";
            this.EntryQuantity.Name = "EntryQuantity";
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            // 
            // ReportingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReporting);
            this.Controls.Add(this.tnSaveReporting);
            this.Controls.Add(this.cmbReporting);
            this.Controls.Add(this.lblCustomerReporting);
            this.Name = "ReportingForm";
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.ReportingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerReporting;
        private System.Windows.Forms.ComboBox cmbReporting;
        private System.Windows.Forms.Button tnSaveReporting;
        private System.Windows.Forms.DataGridView dgvReporting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
    }
}