namespace GymApplication.Forms
{
    partial class CustomerForm
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
            this.lblCustomerFirstname = new System.Windows.Forms.Label();
            this.lblCustomeLastname = new System.Windows.Forms.Label();
            this.lblCustomerBirthday = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomersFirstname = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleetCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerFirstname
            // 
            this.lblCustomerFirstname.AutoSize = true;
            this.lblCustomerFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFirstname.Location = new System.Drawing.Point(12, 29);
            this.lblCustomerFirstname.Name = "lblCustomerFirstname";
            this.lblCustomerFirstname.Size = new System.Drawing.Size(74, 18);
            this.lblCustomerFirstname.TabIndex = 0;
            this.lblCustomerFirstname.Text = "Firstname";
            // 
            // lblCustomeLastname
            // 
            this.lblCustomeLastname.AutoSize = true;
            this.lblCustomeLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomeLastname.Location = new System.Drawing.Point(12, 90);
            this.lblCustomeLastname.Name = "lblCustomeLastname";
            this.lblCustomeLastname.Size = new System.Drawing.Size(73, 18);
            this.lblCustomeLastname.TabIndex = 1;
            this.lblCustomeLastname.Text = "Lastname";
            // 
            // lblCustomerBirthday
            // 
            this.lblCustomerBirthday.AutoSize = true;
            this.lblCustomerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBirthday.Location = new System.Drawing.Point(12, 154);
            this.lblCustomerBirthday.Name = "lblCustomerBirthday";
            this.lblCustomerBirthday.Size = new System.Drawing.Size(61, 18);
            this.lblCustomerBirthday.TabIndex = 2;
            this.lblCustomerBirthday.Text = "Birthday";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.Location = new System.Drawing.Point(12, 235);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(51, 18);
            this.lblCustomerPhone.TabIndex = 3;
            this.lblCustomerPhone.Text = "Phone";
            // 
            // txtCustomersFirstname
            // 
            this.txtCustomersFirstname.Location = new System.Drawing.Point(12, 50);
            this.txtCustomersFirstname.Name = "txtCustomersFirstname";
            this.txtCustomersFirstname.Size = new System.Drawing.Size(185, 20);
            this.txtCustomersFirstname.TabIndex = 5;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(12, 261);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerPhone.TabIndex = 7;
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(12, 111);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(185, 20);
            this.txtCustomerLastname.TabIndex = 9;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSaveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomer.Location = new System.Drawing.Point(15, 307);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(75, 42);
            this.btnSaveCustomer.TabIndex = 10;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.BtnSaveCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(122, 307);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 42);
            this.btnUpdateCustomer.TabIndex = 11;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // btnDeleetCustomer
            // 
            this.btnDeleetCustomer.BackColor = System.Drawing.Color.Brown;
            this.btnDeleetCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleetCustomer.Location = new System.Drawing.Point(56, 359);
            this.btnDeleetCustomer.Name = "btnDeleetCustomer";
            this.btnDeleetCustomer.Size = new System.Drawing.Size(86, 36);
            this.btnDeleetCustomer.TabIndex = 12;
            this.btnDeleetCustomer.Text = "Delete";
            this.btnDeleetCustomer.UseVisualStyleBackColor = false;
            this.btnDeleetCustomer.Click += new System.EventHandler(this.BtnDeleetCustomer_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerFirstname,
            this.CustomerLastname,
            this.CustomerBirthday,
            this.CustomerPhone});
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomer.Location = new System.Drawing.Point(288, 50);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(420, 308);
            this.dgvCustomer.TabIndex = 13;
            this.dgvCustomer.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomer_RowHeaderMouseDoubleClick);
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Id";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = false;
            // 
            // CustomerFirstname
            // 
            this.CustomerFirstname.HeaderText = "Firstname";
            this.CustomerFirstname.Name = "CustomerFirstname";
            // 
            // CustomerLastname
            // 
            this.CustomerLastname.HeaderText = "Lastname";
            this.CustomerLastname.Name = "CustomerLastname";
            // 
            // CustomerBirthday
            // 
            this.CustomerBirthday.HeaderText = "Birthday";
            this.CustomerBirthday.Name = "CustomerBirthday";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.HeaderText = "Phone";
            this.CustomerPhone.Name = "CustomerPhone";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(12, 184);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(185, 20);
            this.dtpBirthday.TabIndex = 14;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(755, 421);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnDeleetCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.txtCustomerLastname);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomersFirstname);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerBirthday);
            this.Controls.Add(this.lblCustomeLastname);
            this.Controls.Add(this.lblCustomerFirstname);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerFirstname;
        private System.Windows.Forms.Label lblCustomeLastname;
        private System.Windows.Forms.Label lblCustomerBirthday;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomersFirstname;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleetCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}