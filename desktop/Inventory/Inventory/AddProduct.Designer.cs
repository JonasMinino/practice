namespace Inventory
{
    partial class AddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductMaxTxtBx = new System.Windows.Forms.TextBox();
            this.ProductMaxLbl = new System.Windows.Forms.Label();
            this.ProductMinTxtBx = new System.Windows.Forms.TextBox();
            this.ProductMinLbl = new System.Windows.Forms.Label();
            this.ProductInventoryTxtBx = new System.Windows.Forms.TextBox();
            this.ProductInventoryLbl = new System.Windows.Forms.Label();
            this.ProductPriceTxtBx = new System.Windows.Forms.TextBox();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProductNameTxtBx = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductIdTxtBx = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.AddProductLbl = new System.Windows.Forms.Label();
            this.AddProduct_PartsDgv = new System.Windows.Forms.DataGridView();
            this.AddProductDgv = new System.Windows.Forms.DataGridView();
            this.AddProductCancelBtn = new System.Windows.Forms.Button();
            this.AddProductSaveBtn = new System.Windows.Forms.Button();
            this.AddProduct_PartDgvLbl = new System.Windows.Forms.Label();
            this.AddProductDgvLbl = new System.Windows.Forms.Label();
            this.AddProduct_PartAddBtn = new System.Windows.Forms.Button();
            this.AddProduct_PartDeleteBtn = new System.Windows.Forms.Button();
            this.ProductTT = new System.Windows.Forms.ToolTip(this.components);
            this.AddProduct_PartsSearchTxtBx = new System.Windows.Forms.TextBox();
            this.AddProduct_PartSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct_PartsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductMaxTxtBx
            // 
            this.ProductMaxTxtBx.Location = new System.Drawing.Point(183, 230);
            this.ProductMaxTxtBx.Name = "ProductMaxTxtBx";
            this.ProductMaxTxtBx.Size = new System.Drawing.Size(78, 20);
            this.ProductMaxTxtBx.TabIndex = 34;
            this.ProductMaxTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductMaxTxtBx_KeyPress);
            this.ProductMaxTxtBx.Leave += new System.EventHandler(this.ProductMaxTxtBx_Leave);
            this.ProductMaxTxtBx.MouseHover += new System.EventHandler(this.ProductMaxTxtBx_MouseHover);
            // 
            // ProductMaxLbl
            // 
            this.ProductMaxLbl.AutoSize = true;
            this.ProductMaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMaxLbl.Location = new System.Drawing.Point(142, 234);
            this.ProductMaxLbl.Name = "ProductMaxLbl";
            this.ProductMaxLbl.Size = new System.Drawing.Size(33, 16);
            this.ProductMaxLbl.TabIndex = 33;
            this.ProductMaxLbl.Text = "Max";
            // 
            // ProductMinTxtBx
            // 
            this.ProductMinTxtBx.Location = new System.Drawing.Point(52, 230);
            this.ProductMinTxtBx.Name = "ProductMinTxtBx";
            this.ProductMinTxtBx.Size = new System.Drawing.Size(80, 20);
            this.ProductMinTxtBx.TabIndex = 32;
            this.ProductMinTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductMinTxtBx_KeyPress);
            this.ProductMinTxtBx.MouseHover += new System.EventHandler(this.ProductMinTxtBx_MouseHover);
            // 
            // ProductMinLbl
            // 
            this.ProductMinLbl.AutoSize = true;
            this.ProductMinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMinLbl.Location = new System.Drawing.Point(11, 234);
            this.ProductMinLbl.Name = "ProductMinLbl";
            this.ProductMinLbl.Size = new System.Drawing.Size(29, 16);
            this.ProductMinLbl.TabIndex = 31;
            this.ProductMinLbl.Text = "Min";
            // 
            // ProductInventoryTxtBx
            // 
            this.ProductInventoryTxtBx.Location = new System.Drawing.Point(86, 193);
            this.ProductInventoryTxtBx.Name = "ProductInventoryTxtBx";
            this.ProductInventoryTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ProductInventoryTxtBx.TabIndex = 30;
            this.ProductInventoryTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductInventoryTxtBx_KeyPress);
            this.ProductInventoryTxtBx.MouseHover += new System.EventHandler(this.ProductInventoryTxtBx_MouseHover);
            // 
            // ProductInventoryLbl
            // 
            this.ProductInventoryLbl.AutoSize = true;
            this.ProductInventoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInventoryLbl.Location = new System.Drawing.Point(8, 197);
            this.ProductInventoryLbl.Name = "ProductInventoryLbl";
            this.ProductInventoryLbl.Size = new System.Drawing.Size(62, 16);
            this.ProductInventoryLbl.TabIndex = 29;
            this.ProductInventoryLbl.Text = "Inventory";
            // 
            // ProductPriceTxtBx
            // 
            this.ProductPriceTxtBx.Location = new System.Drawing.Point(86, 157);
            this.ProductPriceTxtBx.Name = "ProductPriceTxtBx";
            this.ProductPriceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ProductPriceTxtBx.TabIndex = 28;
            this.ProductPriceTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductPriceTxtBx_KeyPress);
            this.ProductPriceTxtBx.MouseHover += new System.EventHandler(this.ProductPriceTxtBx_MouseHover);
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLbl.Location = new System.Drawing.Point(31, 161);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(39, 16);
            this.ProductPriceLbl.TabIndex = 27;
            this.ProductPriceLbl.Text = "Price";
            // 
            // ProductNameTxtBx
            // 
            this.ProductNameTxtBx.Location = new System.Drawing.Point(86, 122);
            this.ProductNameTxtBx.Name = "ProductNameTxtBx";
            this.ProductNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTxtBx.TabIndex = 26;
            this.ProductNameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductNameTxtBx_KeyPress);
            this.ProductNameTxtBx.MouseHover += new System.EventHandler(this.ProductNameTxtBx_MouseHover);
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLbl.Location = new System.Drawing.Point(25, 126);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(45, 16);
            this.ProductNameLbl.TabIndex = 25;
            this.ProductNameLbl.Text = "Name";
            // 
            // ProductIdTxtBx
            // 
            this.ProductIdTxtBx.Enabled = false;
            this.ProductIdTxtBx.Location = new System.Drawing.Point(86, 87);
            this.ProductIdTxtBx.Name = "ProductIdTxtBx";
            this.ProductIdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.ProductIdTxtBx.TabIndex = 24;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLbl.Location = new System.Drawing.Point(49, 91);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(21, 16);
            this.ProductIDLbl.TabIndex = 23;
            this.ProductIDLbl.Text = "ID";
            // 
            // AddProductLbl
            // 
            this.AddProductLbl.AutoSize = true;
            this.AddProductLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLbl.Location = new System.Drawing.Point(5, 9);
            this.AddProductLbl.Name = "AddProductLbl";
            this.AddProductLbl.Size = new System.Drawing.Size(118, 21);
            this.AddProductLbl.TabIndex = 20;
            this.AddProductLbl.Text = "Add Product";
            // 
            // AddProduct_PartsDgv
            // 
            this.AddProduct_PartsDgv.AllowUserToAddRows = false;
            this.AddProduct_PartsDgv.AllowUserToDeleteRows = false;
            this.AddProduct_PartsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProduct_PartsDgv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddProduct_PartsDgv.Location = new System.Drawing.Point(299, 64);
            this.AddProduct_PartsDgv.Name = "AddProduct_PartsDgv";
            this.AddProduct_PartsDgv.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.AddProduct_PartsDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AddProduct_PartsDgv.Size = new System.Drawing.Size(474, 176);
            this.AddProduct_PartsDgv.TabIndex = 35;
            this.AddProduct_PartsDgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddProduct_PartsDgv_CellMouseEnter);
            this.AddProduct_PartsDgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddProduct_PartsDgv_CellMouseLeave);
            // 
            // AddProductDgv
            // 
            this.AddProductDgv.AllowUserToAddRows = false;
            this.AddProductDgv.AllowUserToDeleteRows = false;
            this.AddProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProductDgv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddProductDgv.Location = new System.Drawing.Point(299, 289);
            this.AddProductDgv.Name = "AddProductDgv";
            this.AddProductDgv.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.AddProductDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AddProductDgv.Size = new System.Drawing.Size(474, 176);
            this.AddProductDgv.TabIndex = 36;
            // 
            // AddProductCancelBtn
            // 
            this.AddProductCancelBtn.Location = new System.Drawing.Point(191, 281);
            this.AddProductCancelBtn.Name = "AddProductCancelBtn";
            this.AddProductCancelBtn.Size = new System.Drawing.Size(70, 32);
            this.AddProductCancelBtn.TabIndex = 38;
            this.AddProductCancelBtn.Text = "Cancel";
            this.AddProductCancelBtn.UseVisualStyleBackColor = true;
            this.AddProductCancelBtn.Click += new System.EventHandler(this.AddProductCancelBtn_Click);
            // 
            // AddProductSaveBtn
            // 
            this.AddProductSaveBtn.Location = new System.Drawing.Point(101, 281);
            this.AddProductSaveBtn.Name = "AddProductSaveBtn";
            this.AddProductSaveBtn.Size = new System.Drawing.Size(70, 32);
            this.AddProductSaveBtn.TabIndex = 37;
            this.AddProductSaveBtn.Text = "Save";
            this.AddProductSaveBtn.UseVisualStyleBackColor = true;
            this.AddProductSaveBtn.Click += new System.EventHandler(this.AddProductSaveBtn_Click);
            // 
            // AddProduct_PartDgvLbl
            // 
            this.AddProduct_PartDgvLbl.AutoSize = true;
            this.AddProduct_PartDgvLbl.Location = new System.Drawing.Point(299, 45);
            this.AddProduct_PartDgvLbl.Name = "AddProduct_PartDgvLbl";
            this.AddProduct_PartDgvLbl.Size = new System.Drawing.Size(95, 13);
            this.AddProduct_PartDgvLbl.TabIndex = 39;
            this.AddProduct_PartDgvLbl.Text = "All candidate Parts";
            // 
            // AddProductDgvLbl
            // 
            this.AddProductDgvLbl.AutoSize = true;
            this.AddProductDgvLbl.Location = new System.Drawing.Point(299, 273);
            this.AddProductDgvLbl.Name = "AddProductDgvLbl";
            this.AddProductDgvLbl.Size = new System.Drawing.Size(165, 13);
            this.AddProductDgvLbl.TabIndex = 40;
            this.AddProductDgvLbl.Text = "Parts associated with this product";
            // 
            // AddProduct_PartAddBtn
            // 
            this.AddProduct_PartAddBtn.Location = new System.Drawing.Point(703, 245);
            this.AddProduct_PartAddBtn.Name = "AddProduct_PartAddBtn";
            this.AddProduct_PartAddBtn.Size = new System.Drawing.Size(70, 32);
            this.AddProduct_PartAddBtn.TabIndex = 41;
            this.AddProduct_PartAddBtn.Text = "Add";
            this.AddProduct_PartAddBtn.UseVisualStyleBackColor = true;
            this.AddProduct_PartAddBtn.Click += new System.EventHandler(this.AddProduct_PartAddBtn_Click);
            // 
            // AddProduct_PartDeleteBtn
            // 
            this.AddProduct_PartDeleteBtn.Location = new System.Drawing.Point(703, 471);
            this.AddProduct_PartDeleteBtn.Name = "AddProduct_PartDeleteBtn";
            this.AddProduct_PartDeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.AddProduct_PartDeleteBtn.TabIndex = 42;
            this.AddProduct_PartDeleteBtn.Text = "Delete";
            this.AddProduct_PartDeleteBtn.UseVisualStyleBackColor = true;
            this.AddProduct_PartDeleteBtn.Click += new System.EventHandler(this.AddProduct_PartDeleteBtn_Click);
            // 
            // AddProduct_PartsSearchTxtBx
            // 
            this.AddProduct_PartsSearchTxtBx.Location = new System.Drawing.Point(602, 37);
            this.AddProduct_PartsSearchTxtBx.Name = "AddProduct_PartsSearchTxtBx";
            this.AddProduct_PartsSearchTxtBx.Size = new System.Drawing.Size(171, 20);
            this.AddProduct_PartsSearchTxtBx.TabIndex = 44;
            this.AddProduct_PartsSearchTxtBx.TextChanged += new System.EventHandler(this.AddProduct_PartsSearchTxtBx_TextChanged);
            // 
            // AddProduct_PartSearchBtn
            // 
            this.AddProduct_PartSearchBtn.Location = new System.Drawing.Point(487, 25);
            this.AddProduct_PartSearchBtn.Name = "AddProduct_PartSearchBtn";
            this.AddProduct_PartSearchBtn.Size = new System.Drawing.Size(96, 32);
            this.AddProduct_PartSearchBtn.TabIndex = 43;
            this.AddProduct_PartSearchBtn.Text = "Search";
            this.AddProduct_PartSearchBtn.UseVisualStyleBackColor = true;
            this.AddProduct_PartSearchBtn.Click += new System.EventHandler(this.AddProduct_PartSearchBtn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.Controls.Add(this.AddProduct_PartsSearchTxtBx);
            this.Controls.Add(this.AddProduct_PartSearchBtn);
            this.Controls.Add(this.AddProduct_PartDeleteBtn);
            this.Controls.Add(this.AddProduct_PartAddBtn);
            this.Controls.Add(this.AddProductDgvLbl);
            this.Controls.Add(this.AddProduct_PartDgvLbl);
            this.Controls.Add(this.AddProductCancelBtn);
            this.Controls.Add(this.AddProductSaveBtn);
            this.Controls.Add(this.AddProductDgv);
            this.Controls.Add(this.AddProduct_PartsDgv);
            this.Controls.Add(this.ProductMaxTxtBx);
            this.Controls.Add(this.ProductMaxLbl);
            this.Controls.Add(this.ProductMinTxtBx);
            this.Controls.Add(this.ProductMinLbl);
            this.Controls.Add(this.ProductInventoryTxtBx);
            this.Controls.Add(this.ProductInventoryLbl);
            this.Controls.Add(this.ProductPriceTxtBx);
            this.Controls.Add(this.ProductPriceLbl);
            this.Controls.Add(this.ProductNameTxtBx);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.ProductIdTxtBx);
            this.Controls.Add(this.ProductIDLbl);
            this.Controls.Add(this.AddProductLbl);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct_PartsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductMaxTxtBx;
        private System.Windows.Forms.Label ProductMaxLbl;
        private System.Windows.Forms.TextBox ProductMinTxtBx;
        private System.Windows.Forms.Label ProductMinLbl;
        private System.Windows.Forms.TextBox ProductInventoryTxtBx;
        private System.Windows.Forms.Label ProductInventoryLbl;
        private System.Windows.Forms.TextBox ProductPriceTxtBx;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.TextBox ProductNameTxtBx;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.TextBox ProductIdTxtBx;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.Label AddProductLbl;
        public System.Windows.Forms.DataGridView AddProduct_PartsDgv;
        public System.Windows.Forms.DataGridView AddProductDgv;
        private System.Windows.Forms.Button AddProductCancelBtn;
        private System.Windows.Forms.Button AddProductSaveBtn;
        private System.Windows.Forms.Label AddProduct_PartDgvLbl;
        private System.Windows.Forms.Label AddProductDgvLbl;
        private System.Windows.Forms.Button AddProduct_PartAddBtn;
        private System.Windows.Forms.Button AddProduct_PartDeleteBtn;
        private System.Windows.Forms.ToolTip ProductTT;
        private System.Windows.Forms.TextBox AddProduct_PartsSearchTxtBx;
        private System.Windows.Forms.Button AddProduct_PartSearchBtn;
    }
}