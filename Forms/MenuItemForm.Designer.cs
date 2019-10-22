namespace GymApplication.Forms
{
    partial class MenuItemForm
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
            this.lblNameMenuItem = new System.Windows.Forms.Label();
            this.lblPriceMenuItem = new System.Windows.Forms.Label();
            this.txtNameMenuItem = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPriceMenuItem = new System.Windows.Forms.TextBox();
            this.btnSaveMenuitem = new System.Windows.Forms.Button();
            this.btnUpdateMenuItem = new System.Windows.Forms.Button();
            this.btnDeleteMenuitem = new System.Windows.Forms.Button();
            this.dgvMenuItem = new System.Windows.Forms.DataGridView();
            this.MenuItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameMenuItem
            // 
            this.lblNameMenuItem.AutoSize = true;
            this.lblNameMenuItem.Location = new System.Drawing.Point(36, 67);
            this.lblNameMenuItem.Name = "lblNameMenuItem";
            this.lblNameMenuItem.Size = new System.Drawing.Size(35, 13);
            this.lblNameMenuItem.TabIndex = 0;
            this.lblNameMenuItem.Text = "Name";
            // 
            // lblPriceMenuItem
            // 
            this.lblPriceMenuItem.AutoSize = true;
            this.lblPriceMenuItem.Location = new System.Drawing.Point(36, 149);
            this.lblPriceMenuItem.Name = "lblPriceMenuItem";
            this.lblPriceMenuItem.Size = new System.Drawing.Size(31, 13);
            this.lblPriceMenuItem.TabIndex = 1;
            this.lblPriceMenuItem.Text = "Price";
            // 
            // txtNameMenuItem
            // 
            this.txtNameMenuItem.Location = new System.Drawing.Point(39, 96);
            this.txtNameMenuItem.Name = "txtNameMenuItem";
            this.txtNameMenuItem.Size = new System.Drawing.Size(184, 20);
            this.txtNameMenuItem.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(358, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // txtPriceMenuItem
            // 
            this.txtPriceMenuItem.Location = new System.Drawing.Point(39, 179);
            this.txtPriceMenuItem.Name = "txtPriceMenuItem";
            this.txtPriceMenuItem.Size = new System.Drawing.Size(184, 20);
            this.txtPriceMenuItem.TabIndex = 5;
            // 
            // btnSaveMenuitem
            // 
            this.btnSaveMenuitem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSaveMenuitem.Location = new System.Drawing.Point(39, 223);
            this.btnSaveMenuitem.Name = "btnSaveMenuitem";
            this.btnSaveMenuitem.Size = new System.Drawing.Size(75, 38);
            this.btnSaveMenuitem.TabIndex = 6;
            this.btnSaveMenuitem.Text = "Save";
            this.btnSaveMenuitem.UseVisualStyleBackColor = false;
            this.btnSaveMenuitem.Click += new System.EventHandler(this.BtnSaveMenuitem_Click);
            // 
            // btnUpdateMenuItem
            // 
            this.btnUpdateMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUpdateMenuItem.Location = new System.Drawing.Point(148, 223);
            this.btnUpdateMenuItem.Name = "btnUpdateMenuItem";
            this.btnUpdateMenuItem.Size = new System.Drawing.Size(75, 38);
            this.btnUpdateMenuItem.TabIndex = 7;
            this.btnUpdateMenuItem.Text = "Update";
            this.btnUpdateMenuItem.UseVisualStyleBackColor = false;
            this.btnUpdateMenuItem.Click += new System.EventHandler(this.BtnUpdateMenuItem_Click);
            // 
            // btnDeleteMenuitem
            // 
            this.btnDeleteMenuitem.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteMenuitem.Location = new System.Drawing.Point(96, 276);
            this.btnDeleteMenuitem.Name = "btnDeleteMenuitem";
            this.btnDeleteMenuitem.Size = new System.Drawing.Size(78, 38);
            this.btnDeleteMenuitem.TabIndex = 8;
            this.btnDeleteMenuitem.Text = "Delete";
            this.btnDeleteMenuitem.UseVisualStyleBackColor = false;
            this.btnDeleteMenuitem.Click += new System.EventHandler(this.BtnDeleteMenuitem_Click);
            // 
            // dgvMenuItem
            // 
            this.dgvMenuItem.AllowUserToDeleteRows = false;
            this.dgvMenuItem.AllowUserToResizeColumns = false;
            this.dgvMenuItem.AllowUserToResizeRows = false;
            this.dgvMenuItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenuItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMenuItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MenuItemId,
            this.MenuItemName,
            this.MenuItemPrice});
            this.dgvMenuItem.Location = new System.Drawing.Point(313, 85);
            this.dgvMenuItem.Name = "dgvMenuItem";
            this.dgvMenuItem.Size = new System.Drawing.Size(465, 260);
            this.dgvMenuItem.TabIndex = 9;
            this.dgvMenuItem.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMenuItem_RowHeaderMouseClick);
            // 
            // MenuItemId
            // 
            this.MenuItemId.HeaderText = "Id";
            this.MenuItemId.Name = "MenuItemId";
            this.MenuItemId.Visible = false;
            // 
            // MenuItemName
            // 
            this.MenuItemName.HeaderText = "Name";
            this.MenuItemName.Name = "MenuItemName";
            // 
            // MenuItemPrice
            // 
            this.MenuItemPrice.HeaderText = "Price";
            this.MenuItemPrice.Name = "MenuItemPrice";
            // 
            // MenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMenuItem);
            this.Controls.Add(this.btnDeleteMenuitem);
            this.Controls.Add(this.btnUpdateMenuItem);
            this.Controls.Add(this.btnSaveMenuitem);
            this.Controls.Add(this.txtPriceMenuItem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNameMenuItem);
            this.Controls.Add(this.lblPriceMenuItem);
            this.Controls.Add(this.lblNameMenuItem);
            this.Name = "MenuItemForm";
            this.Text = "MenuItem";
            this.Load += new System.EventHandler(this.MenuItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameMenuItem;
        private System.Windows.Forms.Label lblPriceMenuItem;
        private System.Windows.Forms.TextBox txtNameMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPriceMenuItem;
        private System.Windows.Forms.Button btnSaveMenuitem;
        private System.Windows.Forms.Button btnUpdateMenuItem;
        private System.Windows.Forms.Button btnDeleteMenuitem;
        private System.Windows.Forms.DataGridView dgvMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuItemPrice;
    }
}