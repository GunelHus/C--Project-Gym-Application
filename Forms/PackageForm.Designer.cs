namespace GymApplication.Forms
{
    partial class PackageForm
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
            this.lblPNamePackage = new System.Windows.Forms.Label();
            this.lblPricePackage = new System.Windows.Forms.Label();
            this.lblEntryPackage = new System.Windows.Forms.Label();
            this.txtNamePackage = new System.Windows.Forms.TextBox();
            this.txtEntryPackage = new System.Windows.Forms.TextBox();
            this.txtPricePackage = new System.Windows.Forms.TextBox();
            this.btnSavePackage = new System.Windows.Forms.Button();
            this.btnUpdatePackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.dgvPackage = new System.Windows.Forms.DataGridView();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbxPackage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPNamePackage
            // 
            this.lblPNamePackage.AutoSize = true;
            this.lblPNamePackage.Location = new System.Drawing.Point(21, 54);
            this.lblPNamePackage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPNamePackage.Name = "lblPNamePackage";
            this.lblPNamePackage.Size = new System.Drawing.Size(44, 17);
            this.lblPNamePackage.TabIndex = 0;
            this.lblPNamePackage.Text = "Name";
            // 
            // lblPricePackage
            // 
            this.lblPricePackage.AutoSize = true;
            this.lblPricePackage.Location = new System.Drawing.Point(16, 135);
            this.lblPricePackage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPricePackage.Name = "lblPricePackage";
            this.lblPricePackage.Size = new System.Drawing.Size(38, 17);
            this.lblPricePackage.TabIndex = 1;
            this.lblPricePackage.Text = "Price";
            // 
            // lblEntryPackage
            // 
            this.lblEntryPackage.AutoSize = true;
            this.lblEntryPackage.Location = new System.Drawing.Point(16, 208);
            this.lblEntryPackage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEntryPackage.Name = "lblEntryPackage";
            this.lblEntryPackage.Size = new System.Drawing.Size(94, 17);
            this.lblEntryPackage.TabIndex = 2;
            this.lblEntryPackage.Text = "EntryQuantity";
            // 
            // txtNamePackage
            // 
            this.txtNamePackage.Location = new System.Drawing.Point(19, 84);
            this.txtNamePackage.Margin = new System.Windows.Forms.Padding(5);
            this.txtNamePackage.Name = "txtNamePackage";
            this.txtNamePackage.Size = new System.Drawing.Size(211, 23);
            this.txtNamePackage.TabIndex = 3;
            // 
            // txtEntryPackage
            // 
            this.txtEntryPackage.Location = new System.Drawing.Point(14, 230);
            this.txtEntryPackage.Margin = new System.Windows.Forms.Padding(5);
            this.txtEntryPackage.Name = "txtEntryPackage";
            this.txtEntryPackage.Size = new System.Drawing.Size(211, 23);
            this.txtEntryPackage.TabIndex = 4;
            // 
            // txtPricePackage
            // 
            this.txtPricePackage.Location = new System.Drawing.Point(15, 157);
            this.txtPricePackage.Margin = new System.Windows.Forms.Padding(5);
            this.txtPricePackage.Name = "txtPricePackage";
            this.txtPricePackage.Size = new System.Drawing.Size(211, 23);
            this.txtPricePackage.TabIndex = 5;
            // 
            // btnSavePackage
            // 
            this.btnSavePackage.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSavePackage.Location = new System.Drawing.Point(19, 347);
            this.btnSavePackage.Margin = new System.Windows.Forms.Padding(5);
            this.btnSavePackage.Name = "btnSavePackage";
            this.btnSavePackage.Size = new System.Drawing.Size(85, 45);
            this.btnSavePackage.TabIndex = 6;
            this.btnSavePackage.Text = "Save";
            this.btnSavePackage.UseVisualStyleBackColor = false;
            this.btnSavePackage.Click += new System.EventHandler(this.BtnSavePackage_Click);
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdatePackage.Location = new System.Drawing.Point(140, 347);
            this.btnUpdatePackage.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Size = new System.Drawing.Size(85, 45);
            this.btnUpdatePackage.TabIndex = 7;
            this.btnUpdatePackage.Text = "Update";
            this.btnUpdatePackage.UseVisualStyleBackColor = false;
            this.btnUpdatePackage.Click += new System.EventHandler(this.BtnUpdatePackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.BackColor = System.Drawing.Color.Brown;
            this.btnDeletePackage.Location = new System.Drawing.Point(72, 402);
            this.btnDeletePackage.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(89, 38);
            this.btnDeletePackage.TabIndex = 8;
            this.btnDeletePackage.Text = "Delete";
            this.btnDeletePackage.UseVisualStyleBackColor = false;
            this.btnDeletePackage.Click += new System.EventHandler(this.BtnDeletePackage_Click);
            // 
            // dgvPackage
            // 
            this.dgvPackage.AllowUserToAddRows = false;
            this.dgvPackage.AllowUserToDeleteRows = false;
            this.dgvPackage.AllowUserToResizeColumns = false;
            this.dgvPackage.AllowUserToResizeRows = false;
            this.dgvPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackage.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageID,
            this.PackageName,
            this.PackagePrice,
            this.EntryQuantity});
            this.dgvPackage.Location = new System.Drawing.Point(321, 77);
            this.dgvPackage.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPackage.Name = "dgvPackage";
            this.dgvPackage.Size = new System.Drawing.Size(481, 363);
            this.dgvPackage.TabIndex = 9;
            this.dgvPackage.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPackage_RowHeaderMouseDoubleClick);
            // 
            // PackageID
            // 
            this.PackageID.HeaderText = "Id";
            this.PackageID.Name = "PackageID";
            this.PackageID.Visible = false;
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Name";
            this.PackageName.Name = "PackageName";
            // 
            // PackagePrice
            // 
            this.PackagePrice.HeaderText = "Price";
            this.PackagePrice.Name = "PackagePrice";
            // 
            // EntryQuantity
            // 
            this.EntryQuantity.HeaderText = "EntryQuantity";
            this.EntryQuantity.Name = "EntryQuantity";
            // 
            // chbxPackage
            // 
            this.chbxPackage.AutoSize = true;
            this.chbxPackage.Checked = true;
            this.chbxPackage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxPackage.Location = new System.Drawing.Point(15, 286);
            this.chbxPackage.Name = "chbxPackage";
            this.chbxPackage.Size = new System.Drawing.Size(65, 21);
            this.chbxPackage.TabIndex = 10;
            this.chbxPackage.Text = "Active";
            this.chbxPackage.UseVisualStyleBackColor = true;
            // 
            // PackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(872, 490);
            this.Controls.Add(this.chbxPackage);
            this.Controls.Add(this.dgvPackage);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnUpdatePackage);
            this.Controls.Add(this.btnSavePackage);
            this.Controls.Add(this.txtPricePackage);
            this.Controls.Add(this.txtEntryPackage);
            this.Controls.Add(this.txtNamePackage);
            this.Controls.Add(this.lblEntryPackage);
            this.Controls.Add(this.lblPricePackage);
            this.Controls.Add(this.lblPNamePackage);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PackageForm";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.PackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPNamePackage;
        private System.Windows.Forms.Label lblPricePackage;
        private System.Windows.Forms.Label lblEntryPackage;
        private System.Windows.Forms.TextBox txtNamePackage;
        private System.Windows.Forms.TextBox txtEntryPackage;
        private System.Windows.Forms.TextBox txtPricePackage;
        private System.Windows.Forms.Button btnSavePackage;
        private System.Windows.Forms.Button btnUpdatePackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.DataGridView dgvPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryQuantity;
        private System.Windows.Forms.CheckBox chbxPackage;
    }
}