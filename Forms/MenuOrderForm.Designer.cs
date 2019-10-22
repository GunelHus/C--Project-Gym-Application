namespace GymApplication.Forms
{
    partial class MenuOrderForm
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
            this.lblQuantityMenuOrder = new System.Windows.Forms.Label();
            this.lblCustomerIdMenuorder = new System.Windows.Forms.Label();
            this.lblMenuitemMenuorder = new System.Windows.Forms.Label();
            this.cmbxCustomerIdMenuorder = new System.Windows.Forms.ComboBox();
            this.cmbMenuitemMenuorder = new System.Windows.Forms.ComboBox();
            this.btnSaveMenuorder = new System.Windows.Forms.Button();
            this.btnUpdateMenuorder = new System.Windows.Forms.Button();
            this.btnDeleteMenuorder = new System.Windows.Forms.Button();
            this.dgvMenuOrder = new System.Windows.Forms.DataGridView();
            this.numUpQuantity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuTotal = new System.Windows.Forms.Label();
            this.MenuorderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIdMenuOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuIdMenuOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantityMenuOrder
            // 
            this.lblQuantityMenuOrder.AutoSize = true;
            this.lblQuantityMenuOrder.Location = new System.Drawing.Point(47, 197);
            this.lblQuantityMenuOrder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantityMenuOrder.Name = "lblQuantityMenuOrder";
            this.lblQuantityMenuOrder.Size = new System.Drawing.Size(59, 15);
            this.lblQuantityMenuOrder.TabIndex = 0;
            this.lblQuantityMenuOrder.Text = "Quantity";
            // 
            // lblCustomerIdMenuorder
            // 
            this.lblCustomerIdMenuorder.AutoSize = true;
            this.lblCustomerIdMenuorder.Location = new System.Drawing.Point(47, 41);
            this.lblCustomerIdMenuorder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerIdMenuorder.Name = "lblCustomerIdMenuorder";
            this.lblCustomerIdMenuorder.Size = new System.Drawing.Size(68, 15);
            this.lblCustomerIdMenuorder.TabIndex = 1;
            this.lblCustomerIdMenuorder.Text = "Customer";
            // 
            // lblMenuitemMenuorder
            // 
            this.lblMenuitemMenuorder.AutoSize = true;
            this.lblMenuitemMenuorder.Location = new System.Drawing.Point(47, 128);
            this.lblMenuitemMenuorder.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMenuitemMenuorder.Name = "lblMenuitemMenuorder";
            this.lblMenuitemMenuorder.Size = new System.Drawing.Size(43, 15);
            this.lblMenuitemMenuorder.TabIndex = 2;
            this.lblMenuitemMenuorder.Text = "Menu";
            // 
            // cmbxCustomerIdMenuorder
            // 
            this.cmbxCustomerIdMenuorder.FormattingEnabled = true;
            this.cmbxCustomerIdMenuorder.Location = new System.Drawing.Point(50, 68);
            this.cmbxCustomerIdMenuorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbxCustomerIdMenuorder.Name = "cmbxCustomerIdMenuorder";
            this.cmbxCustomerIdMenuorder.Size = new System.Drawing.Size(244, 23);
            this.cmbxCustomerIdMenuorder.TabIndex = 4;
            // 
            // cmbMenuitemMenuorder
            // 
            this.cmbMenuitemMenuorder.FormattingEnabled = true;
            this.cmbMenuitemMenuorder.Location = new System.Drawing.Point(50, 146);
            this.cmbMenuitemMenuorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbMenuitemMenuorder.Name = "cmbMenuitemMenuorder";
            this.cmbMenuitemMenuorder.Size = new System.Drawing.Size(244, 23);
            this.cmbMenuitemMenuorder.TabIndex = 5;
            // 
            // btnSaveMenuorder
            // 
            this.btnSaveMenuorder.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSaveMenuorder.Location = new System.Drawing.Point(47, 301);
            this.btnSaveMenuorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSaveMenuorder.Name = "btnSaveMenuorder";
            this.btnSaveMenuorder.Size = new System.Drawing.Size(101, 35);
            this.btnSaveMenuorder.TabIndex = 6;
            this.btnSaveMenuorder.Text = "Add";
            this.btnSaveMenuorder.UseVisualStyleBackColor = false;
            this.btnSaveMenuorder.Click += new System.EventHandler(this.BtnSaveMenuorder_Click);
            // 
            // btnUpdateMenuorder
            // 
            this.btnUpdateMenuorder.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdateMenuorder.Location = new System.Drawing.Point(185, 301);
            this.btnUpdateMenuorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnUpdateMenuorder.Name = "btnUpdateMenuorder";
            this.btnUpdateMenuorder.Size = new System.Drawing.Size(97, 35);
            this.btnUpdateMenuorder.TabIndex = 7;
            this.btnUpdateMenuorder.Text = "Update";
            this.btnUpdateMenuorder.UseVisualStyleBackColor = false;
            this.btnUpdateMenuorder.Click += new System.EventHandler(this.BtnUpdateMenuorder_Click);
            // 
            // btnDeleteMenuorder
            // 
            this.btnDeleteMenuorder.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteMenuorder.Location = new System.Drawing.Point(118, 354);
            this.btnDeleteMenuorder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDeleteMenuorder.Name = "btnDeleteMenuorder";
            this.btnDeleteMenuorder.Size = new System.Drawing.Size(83, 33);
            this.btnDeleteMenuorder.TabIndex = 8;
            this.btnDeleteMenuorder.Text = "Delete";
            this.btnDeleteMenuorder.UseVisualStyleBackColor = false;
            this.btnDeleteMenuorder.Click += new System.EventHandler(this.BtnDeleteMenuorder_Click);
            // 
            // dgvMenuOrder
            // 
            this.dgvMenuOrder.AllowUserToAddRows = false;
            this.dgvMenuOrder.AllowUserToDeleteRows = false;
            this.dgvMenuOrder.AllowUserToResizeColumns = false;
            this.dgvMenuOrder.AllowUserToResizeRows = false;
            this.dgvMenuOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMenuOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuorderId,
            this.MenuOrderQuantity,
            this.CustomerIdMenuOrder,
            this.MenuIdMenuOrder,
            this.Price});
            this.dgvMenuOrder.Location = new System.Drawing.Point(375, 82);
            this.dgvMenuOrder.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvMenuOrder.Name = "dgvMenuOrder";
            this.dgvMenuOrder.Size = new System.Drawing.Size(559, 360);
            this.dgvMenuOrder.TabIndex = 9;
            this.dgvMenuOrder.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMenuOrder_RowHeaderMouseDoubleClick);
            // 
            // numUpQuantity
            // 
            this.numUpQuantity.Location = new System.Drawing.Point(50, 231);
            this.numUpQuantity.Name = "numUpQuantity";
            this.numUpQuantity.Size = new System.Drawing.Size(120, 21);
            this.numUpQuantity.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.Location = new System.Drawing.Point(47, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "TotalPrice";
            // 
            // MenuTotal
            // 
            this.MenuTotal.AutoSize = true;
            this.MenuTotal.Location = new System.Drawing.Point(820, 31);
            this.MenuTotal.Name = "MenuTotal";
            this.MenuTotal.Size = new System.Drawing.Size(0, 15);
            this.MenuTotal.TabIndex = 13;
            // 
            // MenuorderId
            // 
            this.MenuorderId.HeaderText = "Id";
            this.MenuorderId.Name = "MenuorderId";
            this.MenuorderId.Visible = false;
            // 
            // MenuOrderQuantity
            // 
            this.MenuOrderQuantity.HeaderText = "Quantity";
            this.MenuOrderQuantity.Name = "MenuOrderQuantity";
            // 
            // CustomerIdMenuOrder
            // 
            this.CustomerIdMenuOrder.HeaderText = "Customer";
            this.CustomerIdMenuOrder.Name = "CustomerIdMenuOrder";
            // 
            // MenuIdMenuOrder
            // 
            this.MenuIdMenuOrder.HeaderText = "Menu";
            this.MenuIdMenuOrder.Name = "MenuIdMenuOrder";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // MenuOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.MenuTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numUpQuantity);
            this.Controls.Add(this.dgvMenuOrder);
            this.Controls.Add(this.btnDeleteMenuorder);
            this.Controls.Add(this.btnUpdateMenuorder);
            this.Controls.Add(this.btnSaveMenuorder);
            this.Controls.Add(this.cmbMenuitemMenuorder);
            this.Controls.Add(this.cmbxCustomerIdMenuorder);
            this.Controls.Add(this.lblMenuitemMenuorder);
            this.Controls.Add(this.lblCustomerIdMenuorder);
            this.Controls.Add(this.lblQuantityMenuOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "MenuOrderForm";
            this.Text = "MenuOrder";
            this.Load += new System.EventHandler(this.MenuOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantityMenuOrder;
        private System.Windows.Forms.Label lblCustomerIdMenuorder;
        private System.Windows.Forms.Label lblMenuitemMenuorder;
        private System.Windows.Forms.ComboBox cmbxCustomerIdMenuorder;
        private System.Windows.Forms.ComboBox cmbMenuitemMenuorder;
        private System.Windows.Forms.Button btnSaveMenuorder;
        private System.Windows.Forms.Button btnUpdateMenuorder;
        private System.Windows.Forms.Button btnDeleteMenuorder;
        private System.Windows.Forms.DataGridView dgvMenuOrder;
        private System.Windows.Forms.NumericUpDown numUpQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MenuTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuorderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuOrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdMenuOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuIdMenuOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}