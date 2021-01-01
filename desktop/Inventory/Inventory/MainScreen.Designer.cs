namespace Inventory
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainsScreenTitle = new System.Windows.Forms.Label();
            this.PartsSearchBtn = new System.Windows.Forms.Button();
            this.PartsSearchTxtBx = new System.Windows.Forms.TextBox();
            this.PartsLbl = new System.Windows.Forms.Label();
            this.PartsAddBtn = new System.Windows.Forms.Button();
            this.PartsModifyBtn = new System.Windows.Forms.Button();
            this.PartsDeleteBtn = new System.Windows.Forms.Button();
            this.ProductDeleteBtn = new System.Windows.Forms.Button();
            this.ProductModifyBtn = new System.Windows.Forms.Button();
            this.ProductAddBtn = new System.Windows.Forms.Button();
            this.ProductDgv = new System.Windows.Forms.DataGridView();
            this.ProductLbl = new System.Windows.Forms.Label();
            this.ProductSearchTxtBx = new System.Windows.Forms.TextBox();
            this.ProductSearchBtn = new System.Windows.Forms.Button();
            this.MainScreenExitBtn = new System.Windows.Forms.Button();
            this.PartsDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainsScreenTitle
            // 
            this.MainsScreenTitle.AutoSize = true;
            this.MainsScreenTitle.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainsScreenTitle.Location = new System.Drawing.Point(4, 3);
            this.MainsScreenTitle.Name = "MainsScreenTitle";
            this.MainsScreenTitle.Size = new System.Drawing.Size(274, 21);
            this.MainsScreenTitle.TabIndex = 0;
            this.MainsScreenTitle.Text = "Inventory Management System";
            // 
            // PartsSearchBtn
            // 
            this.PartsSearchBtn.Location = new System.Drawing.Point(277, 34);
            this.PartsSearchBtn.Name = "PartsSearchBtn";
            this.PartsSearchBtn.Size = new System.Drawing.Size(96, 32);
            this.PartsSearchBtn.TabIndex = 1;
            this.PartsSearchBtn.Text = "Search";
            this.PartsSearchBtn.UseVisualStyleBackColor = true;
            this.PartsSearchBtn.Click += new System.EventHandler(this.PartsSearchBtn_Click);
            // 
            // PartsSearchTxtBx
            // 
            this.PartsSearchTxtBx.Location = new System.Drawing.Point(392, 46);
            this.PartsSearchTxtBx.Name = "PartsSearchTxtBx";
            this.PartsSearchTxtBx.Size = new System.Drawing.Size(171, 20);
            this.PartsSearchTxtBx.TabIndex = 2;
            this.PartsSearchTxtBx.TextChanged += new System.EventHandler(this.PartsSearchTxtBx_TextChanged);
            // 
            // PartsLbl
            // 
            this.PartsLbl.AutoSize = true;
            this.PartsLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLbl.Location = new System.Drawing.Point(37, 46);
            this.PartsLbl.Name = "PartsLbl";
            this.PartsLbl.Size = new System.Drawing.Size(56, 21);
            this.PartsLbl.TabIndex = 4;
            this.PartsLbl.Text = "Parts";
            // 
            // PartsAddBtn
            // 
            this.PartsAddBtn.Location = new System.Drawing.Point(315, 326);
            this.PartsAddBtn.Name = "PartsAddBtn";
            this.PartsAddBtn.Size = new System.Drawing.Size(70, 32);
            this.PartsAddBtn.TabIndex = 6;
            this.PartsAddBtn.Text = "Add";
            this.PartsAddBtn.UseVisualStyleBackColor = true;
            this.PartsAddBtn.Click += new System.EventHandler(this.PartsAddBtn_Click);
            // 
            // PartsModifyBtn
            // 
            this.PartsModifyBtn.Location = new System.Drawing.Point(405, 326);
            this.PartsModifyBtn.Name = "PartsModifyBtn";
            this.PartsModifyBtn.Size = new System.Drawing.Size(70, 32);
            this.PartsModifyBtn.TabIndex = 7;
            this.PartsModifyBtn.Text = "Modify";
            this.PartsModifyBtn.UseVisualStyleBackColor = true;
            this.PartsModifyBtn.Click += new System.EventHandler(this.PartsModifyBtn_Click);
            // 
            // PartsDeleteBtn
            // 
            this.PartsDeleteBtn.Location = new System.Drawing.Point(493, 326);
            this.PartsDeleteBtn.Name = "PartsDeleteBtn";
            this.PartsDeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.PartsDeleteBtn.TabIndex = 8;
            this.PartsDeleteBtn.Text = "Delete";
            this.PartsDeleteBtn.UseVisualStyleBackColor = true;
            this.PartsDeleteBtn.Click += new System.EventHandler(this.PartsDeleteBtn_Click);
            // 
            // ProductDeleteBtn
            // 
            this.ProductDeleteBtn.Location = new System.Drawing.Point(1060, 326);
            this.ProductDeleteBtn.Name = "ProductDeleteBtn";
            this.ProductDeleteBtn.Size = new System.Drawing.Size(70, 32);
            this.ProductDeleteBtn.TabIndex = 15;
            this.ProductDeleteBtn.Text = "Delete";
            this.ProductDeleteBtn.UseVisualStyleBackColor = true;
            this.ProductDeleteBtn.Click += new System.EventHandler(this.ProductDeleteBtn_Click);
            // 
            // ProductModifyBtn
            // 
            this.ProductModifyBtn.Location = new System.Drawing.Point(972, 326);
            this.ProductModifyBtn.Name = "ProductModifyBtn";
            this.ProductModifyBtn.Size = new System.Drawing.Size(70, 32);
            this.ProductModifyBtn.TabIndex = 14;
            this.ProductModifyBtn.Text = "Modify";
            this.ProductModifyBtn.UseVisualStyleBackColor = true;
            this.ProductModifyBtn.Click += new System.EventHandler(this.ProductModifyBtn_Click);
            // 
            // ProductAddBtn
            // 
            this.ProductAddBtn.Location = new System.Drawing.Point(882, 326);
            this.ProductAddBtn.Name = "ProductAddBtn";
            this.ProductAddBtn.Size = new System.Drawing.Size(70, 32);
            this.ProductAddBtn.TabIndex = 13;
            this.ProductAddBtn.Text = "Add";
            this.ProductAddBtn.UseVisualStyleBackColor = true;
            this.ProductAddBtn.Click += new System.EventHandler(this.ProductAddBtn_Click);
            // 
            // ProductDgv
            // 
            this.ProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDgv.DefaultCellStyle = dataGridViewCellStyle13;
            this.ProductDgv.Location = new System.Drawing.Point(603, 79);
            this.ProductDgv.Name = "ProductDgv";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ProductDgv.Size = new System.Drawing.Size(527, 241);
            this.ProductDgv.TabIndex = 12;
            this.ProductDgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDgv_CellMouseEnter);
            this.ProductDgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDgv_CellMouseLeave);
            // 
            // ProductLbl
            // 
            this.ProductLbl.AutoSize = true;
            this.ProductLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLbl.Location = new System.Drawing.Point(604, 46);
            this.ProductLbl.Name = "ProductLbl";
            this.ProductLbl.Size = new System.Drawing.Size(86, 21);
            this.ProductLbl.TabIndex = 11;
            this.ProductLbl.Text = "Products";
            // 
            // ProductSearchTxtBx
            // 
            this.ProductSearchTxtBx.Location = new System.Drawing.Point(959, 46);
            this.ProductSearchTxtBx.Name = "ProductSearchTxtBx";
            this.ProductSearchTxtBx.Size = new System.Drawing.Size(171, 20);
            this.ProductSearchTxtBx.TabIndex = 10;
            this.ProductSearchTxtBx.TextChanged += new System.EventHandler(this.ProductSearchTxtBx_TextChanged);
            // 
            // ProductSearchBtn
            // 
            this.ProductSearchBtn.Location = new System.Drawing.Point(844, 34);
            this.ProductSearchBtn.Name = "ProductSearchBtn";
            this.ProductSearchBtn.Size = new System.Drawing.Size(96, 32);
            this.ProductSearchBtn.TabIndex = 9;
            this.ProductSearchBtn.Text = "Search";
            this.ProductSearchBtn.UseVisualStyleBackColor = true;
            this.ProductSearchBtn.Click += new System.EventHandler(this.ProductSearchBtn_Click);
            // 
            // MainScreenExitBtn
            // 
            this.MainScreenExitBtn.Location = new System.Drawing.Point(1060, 364);
            this.MainScreenExitBtn.Name = "MainScreenExitBtn";
            this.MainScreenExitBtn.Size = new System.Drawing.Size(70, 32);
            this.MainScreenExitBtn.TabIndex = 16;
            this.MainScreenExitBtn.Text = "Exit";
            this.MainScreenExitBtn.UseVisualStyleBackColor = true;
            this.MainScreenExitBtn.Click += new System.EventHandler(this.MainScreenExitBtn_Click);
            // 
            // PartsDgv
            // 
            this.PartsDgv.AllowUserToAddRows = false;
            this.PartsDgv.AllowUserToDeleteRows = false;
            this.PartsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDgv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PartsDgv.Location = new System.Drawing.Point(41, 79);
            this.PartsDgv.Name = "PartsDgv";
            this.PartsDgv.ReadOnly = true;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.PartsDgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.PartsDgv.Size = new System.Drawing.Size(522, 241);
            this.PartsDgv.TabIndex = 17;
            this.PartsDgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDgv_CellMouseEnter);
            this.PartsDgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDgv_CellMouseLeave);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1158, 408);
            this.Controls.Add(this.PartsDgv);
            this.Controls.Add(this.MainScreenExitBtn);
            this.Controls.Add(this.ProductDeleteBtn);
            this.Controls.Add(this.ProductModifyBtn);
            this.Controls.Add(this.ProductAddBtn);
            this.Controls.Add(this.ProductDgv);
            this.Controls.Add(this.ProductLbl);
            this.Controls.Add(this.ProductSearchTxtBx);
            this.Controls.Add(this.ProductSearchBtn);
            this.Controls.Add(this.PartsDeleteBtn);
            this.Controls.Add(this.PartsModifyBtn);
            this.Controls.Add(this.PartsAddBtn);
            this.Controls.Add(this.PartsLbl);
            this.Controls.Add(this.PartsSearchTxtBx);
            this.Controls.Add(this.PartsSearchBtn);
            this.Controls.Add(this.MainsScreenTitle);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainsScreenTitle;
        private System.Windows.Forms.Button PartsSearchBtn;
        private System.Windows.Forms.TextBox PartsSearchTxtBx;
        private System.Windows.Forms.Label PartsLbl;
        private System.Windows.Forms.Button PartsAddBtn;
        private System.Windows.Forms.Button PartsModifyBtn;
        private System.Windows.Forms.Button PartsDeleteBtn;
        private System.Windows.Forms.Button ProductDeleteBtn;
        private System.Windows.Forms.Button ProductModifyBtn;
        private System.Windows.Forms.Button ProductAddBtn;
        private System.Windows.Forms.Label ProductLbl;
        private System.Windows.Forms.TextBox ProductSearchTxtBx;
        private System.Windows.Forms.Button ProductSearchBtn;
        private System.Windows.Forms.Button MainScreenExitBtn;
        public System.Windows.Forms.DataGridView PartsDgv;
        public System.Windows.Forms.DataGridView ProductDgv;
    }
}

