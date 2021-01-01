namespace Inventory
{
    partial class ModifyProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ModifyProduct_PartSearchBtn = new System.Windows.Forms.Button();
            this.ModifyProductTT = new System.Windows.Forms.ToolTip(this.components);
            this.ModifyProduct_PartsSearchTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProduct_PartDeleteBtn = new System.Windows.Forms.Button();
            this.ModifyProduct_PartAddBtn = new System.Windows.Forms.Button();
            this.ModifyProductDgvLbl = new System.Windows.Forms.Label();
            this.ModifyProduct_PartDgvLbl = new System.Windows.Forms.Label();
            this.ModifyAddProductCancelBtn = new System.Windows.Forms.Button();
            this.ModifyAddProductSaveBtn = new System.Windows.Forms.Button();
            this.ModifyProductDgv = new System.Windows.Forms.DataGridView();
            this.ModifyProduct_PartsDgv = new System.Windows.Forms.DataGridView();
            this.ModifyProductMaxTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductMaxLbl = new System.Windows.Forms.Label();
            this.ModifyProductMinTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductMinLbl = new System.Windows.Forms.Label();
            this.ModifyProductInventoryTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductInventoryLbl = new System.Windows.Forms.Label();
            this.ModifyProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductPriceLbl = new System.Windows.Forms.Label();
            this.ModifyProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductNameLbl = new System.Windows.Forms.Label();
            this.ModifyProductIdTxtBx = new System.Windows.Forms.TextBox();
            this.ModifyProductIDLbl = new System.Windows.Forms.Label();
            this.ModifyProductLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProductDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProduct_PartsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyProduct_PartSearchBtn
            // 
            this.ModifyProduct_PartSearchBtn.Location = new System.Drawing.Point(498, 23);
            this.ModifyProduct_PartSearchBtn.Name = "ModifyProduct_PartSearchBtn";
            this.ModifyProduct_PartSearchBtn.Size = new System.Drawing.Size(96, 32);
            this.ModifyProduct_PartSearchBtn.TabIndex = 66;
            this.ModifyProduct_PartSearchBtn.Text = "Search";
            this.ModifyProduct_PartSearchBtn.UseVisualStyleBackColor = true;
            this.ModifyProduct_PartSearchBtn.Click += new System.EventHandler(this.ModifyProduct_PartSearchBtn_Click);
            // 
            // ModifyProduct_PartsSearchTxtBx
            // 
            this.ModifyProduct_PartsSearchTxtBx.Location = new System.Drawing.Point(613, 35);
            this.ModifyProduct_PartsSearchTxtBx.Name = "ModifyProduct_PartsSearchTxtBx";
            this.ModifyProduct_PartsSearchTxtBx.Size = new System.Drawing.Size(171, 20);
            this.ModifyProduct_PartsSearchTxtBx.TabIndex = 67;
            this.ModifyProduct_PartsSearchTxtBx.TextChanged += new System.EventHandler(this.ModifyProduct_PartsSearchTxtBx_TextChanged);
            // 
            // ModifyProduct_PartDeleteBtn
            // 
            this.ModifyProduct_PartDeleteBtn.Location = new System.Drawing.Point(714, 469);
            this.ModifyProduct_PartDeleteBtn.Name = "ModifyProduct_PartDeleteBtn";
            this.ModifyProduct_PartDeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.ModifyProduct_PartDeleteBtn.TabIndex = 65;
            this.ModifyProduct_PartDeleteBtn.Text = "Delete";
            this.ModifyProduct_PartDeleteBtn.UseVisualStyleBackColor = true;
            this.ModifyProduct_PartDeleteBtn.Click += new System.EventHandler(this.ModifyProduct_PartDeleteBtn_Click);
            // 
            // ModifyProduct_PartAddBtn
            // 
            this.ModifyProduct_PartAddBtn.Location = new System.Drawing.Point(714, 243);
            this.ModifyProduct_PartAddBtn.Name = "ModifyProduct_PartAddBtn";
            this.ModifyProduct_PartAddBtn.Size = new System.Drawing.Size(70, 32);
            this.ModifyProduct_PartAddBtn.TabIndex = 64;
            this.ModifyProduct_PartAddBtn.Text = "Add";
            this.ModifyProduct_PartAddBtn.UseVisualStyleBackColor = true;
            this.ModifyProduct_PartAddBtn.Click += new System.EventHandler(this.ModifyProduct_PartAddBtn_Click);
            // 
            // ModifyProductDgvLbl
            // 
            this.ModifyProductDgvLbl.AutoSize = true;
            this.ModifyProductDgvLbl.Location = new System.Drawing.Point(310, 271);
            this.ModifyProductDgvLbl.Name = "ModifyProductDgvLbl";
            this.ModifyProductDgvLbl.Size = new System.Drawing.Size(165, 13);
            this.ModifyProductDgvLbl.TabIndex = 63;
            this.ModifyProductDgvLbl.Text = "Parts associated with this product";
            // 
            // ModifyProduct_PartDgvLbl
            // 
            this.ModifyProduct_PartDgvLbl.AutoSize = true;
            this.ModifyProduct_PartDgvLbl.Location = new System.Drawing.Point(310, 43);
            this.ModifyProduct_PartDgvLbl.Name = "ModifyProduct_PartDgvLbl";
            this.ModifyProduct_PartDgvLbl.Size = new System.Drawing.Size(95, 13);
            this.ModifyProduct_PartDgvLbl.TabIndex = 62;
            this.ModifyProduct_PartDgvLbl.Text = "All candidate Parts";
            // 
            // ModifyAddProductCancelBtn
            // 
            this.ModifyAddProductCancelBtn.Location = new System.Drawing.Point(202, 279);
            this.ModifyAddProductCancelBtn.Name = "ModifyAddProductCancelBtn";
            this.ModifyAddProductCancelBtn.Size = new System.Drawing.Size(70, 32);
            this.ModifyAddProductCancelBtn.TabIndex = 61;
            this.ModifyAddProductCancelBtn.Text = "Cancel";
            this.ModifyAddProductCancelBtn.UseVisualStyleBackColor = true;
            this.ModifyAddProductCancelBtn.Click += new System.EventHandler(this.ModifyProductCancelBtn_Click);
            // 
            // ModifyAddProductSaveBtn
            // 
            this.ModifyAddProductSaveBtn.Location = new System.Drawing.Point(112, 279);
            this.ModifyAddProductSaveBtn.Name = "ModifyAddProductSaveBtn";
            this.ModifyAddProductSaveBtn.Size = new System.Drawing.Size(70, 32);
            this.ModifyAddProductSaveBtn.TabIndex = 60;
            this.ModifyAddProductSaveBtn.Text = "Save";
            this.ModifyAddProductSaveBtn.UseVisualStyleBackColor = true;
            this.ModifyAddProductSaveBtn.Click += new System.EventHandler(this.ModifyAddProductSaveBtn_Click);
            // 
            // ModifyProductDgv
            // 
            this.ModifyProductDgv.AllowUserToAddRows = false;
            this.ModifyProductDgv.AllowUserToDeleteRows = false;
            this.ModifyProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModifyProductDgv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModifyProductDgv.Location = new System.Drawing.Point(310, 287);
            this.ModifyProductDgv.Name = "ModifyProductDgv";
            this.ModifyProductDgv.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ModifyProductDgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ModifyProductDgv.Size = new System.Drawing.Size(474, 176);
            this.ModifyProductDgv.TabIndex = 59;
            this.ModifyProductDgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifyProductDgv_CellMouseEnter);
            this.ModifyProductDgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifyProductDgv_CellMouseLeave);
            // 
            // ModifyProduct_PartsDgv
            // 
            this.ModifyProduct_PartsDgv.AllowUserToAddRows = false;
            this.ModifyProduct_PartsDgv.AllowUserToDeleteRows = false;
            this.ModifyProduct_PartsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModifyProduct_PartsDgv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModifyProduct_PartsDgv.Location = new System.Drawing.Point(310, 62);
            this.ModifyProduct_PartsDgv.Name = "ModifyProduct_PartsDgv";
            this.ModifyProduct_PartsDgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ModifyProduct_PartsDgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ModifyProduct_PartsDgv.Size = new System.Drawing.Size(474, 176);
            this.ModifyProduct_PartsDgv.TabIndex = 58;
            this.ModifyProduct_PartsDgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifyProduct_PartsDgv_CellMouseEnter_1);
            this.ModifyProduct_PartsDgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModifyProduct_PartsDgv_CellMouseLeave_1);
            // 
            // ModifyProductMaxTxtBx
            // 
            this.ModifyProductMaxTxtBx.Location = new System.Drawing.Point(194, 228);
            this.ModifyProductMaxTxtBx.Name = "ModifyProductMaxTxtBx";
            this.ModifyProductMaxTxtBx.Size = new System.Drawing.Size(78, 20);
            this.ModifyProductMaxTxtBx.TabIndex = 57;
            this.ModifyProductMaxTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductMaxTxtBx_KeyPress);
            this.ModifyProductMaxTxtBx.Leave += new System.EventHandler(this.ModifyProductMaxTxtBx_Leave_1);
            this.ModifyProductMaxTxtBx.MouseHover += new System.EventHandler(this.ModifyProductMaxTxtBx_MouseHover);
            // 
            // ModifyProductMaxLbl
            // 
            this.ModifyProductMaxLbl.AutoSize = true;
            this.ModifyProductMaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMaxLbl.Location = new System.Drawing.Point(153, 232);
            this.ModifyProductMaxLbl.Name = "ModifyProductMaxLbl";
            this.ModifyProductMaxLbl.Size = new System.Drawing.Size(33, 16);
            this.ModifyProductMaxLbl.TabIndex = 56;
            this.ModifyProductMaxLbl.Text = "Max";
            // 
            // ModifyProductMinTxtBx
            // 
            this.ModifyProductMinTxtBx.Location = new System.Drawing.Point(63, 228);
            this.ModifyProductMinTxtBx.Name = "ModifyProductMinTxtBx";
            this.ModifyProductMinTxtBx.Size = new System.Drawing.Size(80, 20);
            this.ModifyProductMinTxtBx.TabIndex = 55;
            this.ModifyProductMinTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductMinTxtBx_KeyPress);
            this.ModifyProductMinTxtBx.Leave += new System.EventHandler(this.ModifyProductMinTxtBx_Leave);
            this.ModifyProductMinTxtBx.MouseHover += new System.EventHandler(this.ModifyProductMinTxtBx_MouseHover);
            // 
            // ModifyProductMinLbl
            // 
            this.ModifyProductMinLbl.AutoSize = true;
            this.ModifyProductMinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMinLbl.Location = new System.Drawing.Point(22, 232);
            this.ModifyProductMinLbl.Name = "ModifyProductMinLbl";
            this.ModifyProductMinLbl.Size = new System.Drawing.Size(29, 16);
            this.ModifyProductMinLbl.TabIndex = 54;
            this.ModifyProductMinLbl.Text = "Min";
            // 
            // ModifyProductInventoryTxtBx
            // 
            this.ModifyProductInventoryTxtBx.Location = new System.Drawing.Point(97, 191);
            this.ModifyProductInventoryTxtBx.Name = "ModifyProductInventoryTxtBx";
            this.ModifyProductInventoryTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ModifyProductInventoryTxtBx.TabIndex = 53;
            this.ModifyProductInventoryTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductInventoryTxtBx_KeyPress);
            this.ModifyProductInventoryTxtBx.Leave += new System.EventHandler(this.ModifyProductInventoryTxtBx_Leave);
            this.ModifyProductInventoryTxtBx.MouseHover += new System.EventHandler(this.ModifyProductInventoryTxtBx_MouseHover);
            // 
            // ModifyProductInventoryLbl
            // 
            this.ModifyProductInventoryLbl.AutoSize = true;
            this.ModifyProductInventoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductInventoryLbl.Location = new System.Drawing.Point(19, 195);
            this.ModifyProductInventoryLbl.Name = "ModifyProductInventoryLbl";
            this.ModifyProductInventoryLbl.Size = new System.Drawing.Size(62, 16);
            this.ModifyProductInventoryLbl.TabIndex = 52;
            this.ModifyProductInventoryLbl.Text = "Inventory";
            // 
            // ModifyProductPriceTxtBx
            // 
            this.ModifyProductPriceTxtBx.Location = new System.Drawing.Point(97, 155);
            this.ModifyProductPriceTxtBx.Name = "ModifyProductPriceTxtBx";
            this.ModifyProductPriceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ModifyProductPriceTxtBx.TabIndex = 51;
            this.ModifyProductPriceTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductPriceTxtBx_KeyPress);
            this.ModifyProductPriceTxtBx.Leave += new System.EventHandler(this.ModifyProductPriceTxtBx_Leave);
            this.ModifyProductPriceTxtBx.MouseHover += new System.EventHandler(this.ModifyProductPriceTxtBx_MouseHover);
            // 
            // ModifyProductPriceLbl
            // 
            this.ModifyProductPriceLbl.AutoSize = true;
            this.ModifyProductPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductPriceLbl.Location = new System.Drawing.Point(42, 159);
            this.ModifyProductPriceLbl.Name = "ModifyProductPriceLbl";
            this.ModifyProductPriceLbl.Size = new System.Drawing.Size(39, 16);
            this.ModifyProductPriceLbl.TabIndex = 50;
            this.ModifyProductPriceLbl.Text = "Price";
            // 
            // ModifyProductNameTxtBx
            // 
            this.ModifyProductNameTxtBx.Location = new System.Drawing.Point(97, 120);
            this.ModifyProductNameTxtBx.Name = "ModifyProductNameTxtBx";
            this.ModifyProductNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ModifyProductNameTxtBx.TabIndex = 49;
            this.ModifyProductNameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifyProductNameTxtBx_KeyPress);
            this.ModifyProductNameTxtBx.Leave += new System.EventHandler(this.ModifyProductNameTxtBx_Leave);
            this.ModifyProductNameTxtBx.MouseHover += new System.EventHandler(this.ModifyProductNameTxtBx_MouseHover);
            // 
            // ModifyProductNameLbl
            // 
            this.ModifyProductNameLbl.AutoSize = true;
            this.ModifyProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductNameLbl.Location = new System.Drawing.Point(36, 124);
            this.ModifyProductNameLbl.Name = "ModifyProductNameLbl";
            this.ModifyProductNameLbl.Size = new System.Drawing.Size(45, 16);
            this.ModifyProductNameLbl.TabIndex = 48;
            this.ModifyProductNameLbl.Text = "Name";
            // 
            // ModifyProductIdTxtBx
            // 
            this.ModifyProductIdTxtBx.Enabled = false;
            this.ModifyProductIdTxtBx.Location = new System.Drawing.Point(97, 85);
            this.ModifyProductIdTxtBx.Name = "ModifyProductIdTxtBx";
            this.ModifyProductIdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ModifyProductIdTxtBx.TabIndex = 47;
            // 
            // ModifyProductIDLbl
            // 
            this.ModifyProductIDLbl.AutoSize = true;
            this.ModifyProductIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductIDLbl.Location = new System.Drawing.Point(60, 89);
            this.ModifyProductIDLbl.Name = "ModifyProductIDLbl";
            this.ModifyProductIDLbl.Size = new System.Drawing.Size(21, 16);
            this.ModifyProductIDLbl.TabIndex = 46;
            this.ModifyProductIDLbl.Text = "ID";
            // 
            // ModifyProductLbl
            // 
            this.ModifyProductLbl.AutoSize = true;
            this.ModifyProductLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLbl.Location = new System.Drawing.Point(16, 7);
            this.ModifyProductLbl.Name = "ModifyProductLbl";
            this.ModifyProductLbl.Size = new System.Drawing.Size(146, 21);
            this.ModifyProductLbl.TabIndex = 45;
            this.ModifyProductLbl.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.Controls.Add(this.ModifyProduct_PartSearchBtn);
            this.Controls.Add(this.ModifyProduct_PartsSearchTxtBx);
            this.Controls.Add(this.ModifyProduct_PartDeleteBtn);
            this.Controls.Add(this.ModifyProduct_PartAddBtn);
            this.Controls.Add(this.ModifyProductDgvLbl);
            this.Controls.Add(this.ModifyProduct_PartDgvLbl);
            this.Controls.Add(this.ModifyAddProductCancelBtn);
            this.Controls.Add(this.ModifyAddProductSaveBtn);
            this.Controls.Add(this.ModifyProductDgv);
            this.Controls.Add(this.ModifyProduct_PartsDgv);
            this.Controls.Add(this.ModifyProductMaxTxtBx);
            this.Controls.Add(this.ModifyProductMaxLbl);
            this.Controls.Add(this.ModifyProductMinTxtBx);
            this.Controls.Add(this.ModifyProductMinLbl);
            this.Controls.Add(this.ModifyProductInventoryTxtBx);
            this.Controls.Add(this.ModifyProductInventoryLbl);
            this.Controls.Add(this.ModifyProductPriceTxtBx);
            this.Controls.Add(this.ModifyProductPriceLbl);
            this.Controls.Add(this.ModifyProductNameTxtBx);
            this.Controls.Add(this.ModifyProductNameLbl);
            this.Controls.Add(this.ModifyProductIdTxtBx);
            this.Controls.Add(this.ModifyProductIDLbl);
            this.Controls.Add(this.ModifyProductLbl);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProductDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyProduct_PartsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyProduct_PartSearchBtn;
        private System.Windows.Forms.ToolTip ModifyProductTT;
        private System.Windows.Forms.TextBox ModifyProduct_PartsSearchTxtBx;
        private System.Windows.Forms.Button ModifyProduct_PartDeleteBtn;
        private System.Windows.Forms.Button ModifyProduct_PartAddBtn;
        private System.Windows.Forms.Label ModifyProductDgvLbl;
        private System.Windows.Forms.Label ModifyProduct_PartDgvLbl;
        private System.Windows.Forms.Button ModifyAddProductCancelBtn;
        private System.Windows.Forms.Button ModifyAddProductSaveBtn;
        public System.Windows.Forms.DataGridView ModifyProductDgv;
        public System.Windows.Forms.DataGridView ModifyProduct_PartsDgv;
        private System.Windows.Forms.Label ModifyProductMaxLbl;
        private System.Windows.Forms.Label ModifyProductMinLbl;
        private System.Windows.Forms.Label ModifyProductInventoryLbl;
        private System.Windows.Forms.Label ModifyProductPriceLbl;
        private System.Windows.Forms.Label ModifyProductNameLbl;
        private System.Windows.Forms.Label ModifyProductIDLbl;
        private System.Windows.Forms.Label ModifyProductLbl;
        public System.Windows.Forms.TextBox ModifyProductMaxTxtBx;
        public System.Windows.Forms.TextBox ModifyProductMinTxtBx;
        public System.Windows.Forms.TextBox ModifyProductInventoryTxtBx;
        public System.Windows.Forms.TextBox ModifyProductPriceTxtBx;
        public System.Windows.Forms.TextBox ModifyProductNameTxtBx;
        public System.Windows.Forms.TextBox ModifyProductIdTxtBx;
    }
}