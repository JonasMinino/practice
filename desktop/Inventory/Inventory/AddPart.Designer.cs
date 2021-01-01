namespace Inventory
{
    partial class AddPart
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
            this.AddPartLbl = new System.Windows.Forms.Label();
            this.InHouseRdBtn = new System.Windows.Forms.RadioButton();
            this.OutsourcedRdBtn = new System.Windows.Forms.RadioButton();
            this.PartIDLbl = new System.Windows.Forms.Label();
            this.PartIdTxtBx = new System.Windows.Forms.TextBox();
            this.PartNameTxtBx = new System.Windows.Forms.TextBox();
            this.PartNameLbl = new System.Windows.Forms.Label();
            this.PartPriceTxtBx = new System.Windows.Forms.TextBox();
            this.PartPriceLbl = new System.Windows.Forms.Label();
            this.PartInventoryTxtBx = new System.Windows.Forms.TextBox();
            this.InventoryLbl = new System.Windows.Forms.Label();
            this.PartMinTxtBx = new System.Windows.Forms.TextBox();
            this.PartMinLbl = new System.Windows.Forms.Label();
            this.PartMaxTxtBx = new System.Windows.Forms.TextBox();
            this.PartMaxLbl = new System.Windows.Forms.Label();
            this.MachineIDTxtBx = new System.Windows.Forms.TextBox();
            this.MachineIDLbl = new System.Windows.Forms.Label();
            this.AddPartCancelBtn = new System.Windows.Forms.Button();
            this.AddPartSaveBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddPartLbl
            // 
            this.AddPartLbl.AutoSize = true;
            this.AddPartLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLbl.Location = new System.Drawing.Point(3, 9);
            this.AddPartLbl.Name = "AddPartLbl";
            this.AddPartLbl.Size = new System.Drawing.Size(88, 21);
            this.AddPartLbl.TabIndex = 5;
            this.AddPartLbl.Text = "Add Part";
            // 
            // InHouseRdBtn
            // 
            this.InHouseRdBtn.AutoSize = true;
            this.InHouseRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRdBtn.Location = new System.Drawing.Point(132, 13);
            this.InHouseRdBtn.Name = "InHouseRdBtn";
            this.InHouseRdBtn.Size = new System.Drawing.Size(80, 20);
            this.InHouseRdBtn.TabIndex = 6;
            this.InHouseRdBtn.TabStop = true;
            this.InHouseRdBtn.Text = "In-House";
            this.InHouseRdBtn.UseVisualStyleBackColor = true;
            this.InHouseRdBtn.CheckedChanged += new System.EventHandler(this.InHouseRdBtn_CheckedChanged);
            // 
            // OutsourcedRdBtn
            // 
            this.OutsourcedRdBtn.AutoSize = true;
            this.OutsourcedRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedRdBtn.Location = new System.Drawing.Point(236, 13);
            this.OutsourcedRdBtn.Name = "OutsourcedRdBtn";
            this.OutsourcedRdBtn.Size = new System.Drawing.Size(95, 20);
            this.OutsourcedRdBtn.TabIndex = 7;
            this.OutsourcedRdBtn.TabStop = true;
            this.OutsourcedRdBtn.Text = "Outsourced";
            this.OutsourcedRdBtn.UseVisualStyleBackColor = true;
            this.OutsourcedRdBtn.CheckedChanged += new System.EventHandler(this.OutsourcedRdBtn_CheckedChanged);
            // 
            // PartIDLbl
            // 
            this.PartIDLbl.AutoSize = true;
            this.PartIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIDLbl.Location = new System.Drawing.Point(129, 58);
            this.PartIDLbl.Name = "PartIDLbl";
            this.PartIDLbl.Size = new System.Drawing.Size(21, 16);
            this.PartIDLbl.TabIndex = 8;
            this.PartIDLbl.Text = "ID";
            // 
            // PartIdTxtBx
            // 
            this.PartIdTxtBx.Enabled = false;
            this.PartIdTxtBx.Location = new System.Drawing.Point(166, 54);
            this.PartIdTxtBx.Name = "PartIdTxtBx";
            this.PartIdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.PartIdTxtBx.TabIndex = 9;
            // 
            // PartNameTxtBx
            // 
            this.PartNameTxtBx.Location = new System.Drawing.Point(166, 89);
            this.PartNameTxtBx.Name = "PartNameTxtBx";
            this.PartNameTxtBx.Size = new System.Drawing.Size(100, 20);
            this.PartNameTxtBx.TabIndex = 11;
            this.PartNameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartNameTxtBx_KeyPress);
            this.PartNameTxtBx.Leave += new System.EventHandler(this.PartNameTxtBx_Leave);
            this.PartNameTxtBx.MouseHover += new System.EventHandler(this.PartNameTxtBx_MouseHover);
            // 
            // PartNameLbl
            // 
            this.PartNameLbl.AutoSize = true;
            this.PartNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLbl.Location = new System.Drawing.Point(105, 93);
            this.PartNameLbl.Name = "PartNameLbl";
            this.PartNameLbl.Size = new System.Drawing.Size(45, 16);
            this.PartNameLbl.TabIndex = 10;
            this.PartNameLbl.Text = "Name";
            // 
            // PartPriceTxtBx
            // 
            this.PartPriceTxtBx.Location = new System.Drawing.Point(166, 124);
            this.PartPriceTxtBx.Name = "PartPriceTxtBx";
            this.PartPriceTxtBx.Size = new System.Drawing.Size(100, 20);
            this.PartPriceTxtBx.TabIndex = 13;
            this.PartPriceTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartPriceTxtBx_KeyPress);
            this.PartPriceTxtBx.Leave += new System.EventHandler(this.PartPriceTxtBx_Leave);
            this.PartPriceTxtBx.MouseHover += new System.EventHandler(this.PartPriceTxtBx_MouseHover);
            // 
            // PartPriceLbl
            // 
            this.PartPriceLbl.AutoSize = true;
            this.PartPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartPriceLbl.Location = new System.Drawing.Point(111, 128);
            this.PartPriceLbl.Name = "PartPriceLbl";
            this.PartPriceLbl.Size = new System.Drawing.Size(39, 16);
            this.PartPriceLbl.TabIndex = 12;
            this.PartPriceLbl.Text = "Price";
            // 
            // PartInventoryTxtBx
            // 
            this.PartInventoryTxtBx.Location = new System.Drawing.Point(166, 160);
            this.PartInventoryTxtBx.Name = "PartInventoryTxtBx";
            this.PartInventoryTxtBx.Size = new System.Drawing.Size(100, 20);
            this.PartInventoryTxtBx.TabIndex = 15;
            this.PartInventoryTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartInventoryTxtBx_KeyPress);
            this.PartInventoryTxtBx.Leave += new System.EventHandler(this.PartInventoryTxtBx_Leave);
            this.PartInventoryTxtBx.MouseHover += new System.EventHandler(this.PartInventoryTxtBx_MouseHover);
            // 
            // InventoryLbl
            // 
            this.InventoryLbl.AutoSize = true;
            this.InventoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLbl.Location = new System.Drawing.Point(88, 164);
            this.InventoryLbl.Name = "InventoryLbl";
            this.InventoryLbl.Size = new System.Drawing.Size(62, 16);
            this.InventoryLbl.TabIndex = 14;
            this.InventoryLbl.Text = "Inventory";
            // 
            // PartMinTxtBx
            // 
            this.PartMinTxtBx.Location = new System.Drawing.Point(132, 197);
            this.PartMinTxtBx.Name = "PartMinTxtBx";
            this.PartMinTxtBx.Size = new System.Drawing.Size(80, 20);
            this.PartMinTxtBx.TabIndex = 17;
            this.PartMinTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartMinTxtBx_KeyPress);
            this.PartMinTxtBx.Leave += new System.EventHandler(this.PartMinTxtBx_Leave);
            this.PartMinTxtBx.MouseHover += new System.EventHandler(this.PartMinTxtBx_MouseHover);
            // 
            // PartMinLbl
            // 
            this.PartMinLbl.AutoSize = true;
            this.PartMinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMinLbl.Location = new System.Drawing.Point(91, 201);
            this.PartMinLbl.Name = "PartMinLbl";
            this.PartMinLbl.Size = new System.Drawing.Size(29, 16);
            this.PartMinLbl.TabIndex = 16;
            this.PartMinLbl.Text = "Min";
            // 
            // PartMaxTxtBx
            // 
            this.PartMaxTxtBx.Location = new System.Drawing.Point(263, 197);
            this.PartMaxTxtBx.Name = "PartMaxTxtBx";
            this.PartMaxTxtBx.Size = new System.Drawing.Size(78, 20);
            this.PartMaxTxtBx.TabIndex = 19;
            this.PartMaxTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartMaxTxtBx_KeyPress);
            this.PartMaxTxtBx.Leave += new System.EventHandler(this.PartMaxTxtBx_Leave);
            this.PartMaxTxtBx.MouseHover += new System.EventHandler(this.PartMaxTxtBx_MouseHover);
            // 
            // PartMaxLbl
            // 
            this.PartMaxLbl.AutoSize = true;
            this.PartMaxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartMaxLbl.Location = new System.Drawing.Point(222, 201);
            this.PartMaxLbl.Name = "PartMaxLbl";
            this.PartMaxLbl.Size = new System.Drawing.Size(33, 16);
            this.PartMaxLbl.TabIndex = 18;
            this.PartMaxLbl.Text = "Max";
            // 
            // MachineIDTxtBx
            // 
            this.MachineIDTxtBx.Location = new System.Drawing.Point(166, 234);
            this.MachineIDTxtBx.Name = "MachineIDTxtBx";
            this.MachineIDTxtBx.Size = new System.Drawing.Size(100, 20);
            this.MachineIDTxtBx.TabIndex = 21;
            this.MachineIDTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MachineIDTxtBx_KeyPress);
            this.MachineIDTxtBx.Leave += new System.EventHandler(this.MachineIDTxtBx_Leave);
            this.MachineIDTxtBx.MouseHover += new System.EventHandler(this.MachineIDTxtBx_MouseHover);
            // 
            // MachineIDLbl
            // 
            this.MachineIDLbl.AutoSize = true;
            this.MachineIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineIDLbl.Location = new System.Drawing.Point(45, 238);
            this.MachineIDLbl.Name = "MachineIDLbl";
            this.MachineIDLbl.Size = new System.Drawing.Size(75, 16);
            this.MachineIDLbl.TabIndex = 20;
            this.MachineIDLbl.Text = "Machine ID";
            // 
            // AddPartCancelBtn
            // 
            this.AddPartCancelBtn.Location = new System.Drawing.Point(271, 287);
            this.AddPartCancelBtn.Name = "AddPartCancelBtn";
            this.AddPartCancelBtn.Size = new System.Drawing.Size(70, 32);
            this.AddPartCancelBtn.TabIndex = 23;
            this.AddPartCancelBtn.Text = "Cancel";
            this.AddPartCancelBtn.UseVisualStyleBackColor = true;
            this.AddPartCancelBtn.Click += new System.EventHandler(this.AddPartCancelBtn_Click);
            // 
            // AddPartSaveBtn
            // 
            this.AddPartSaveBtn.Location = new System.Drawing.Point(181, 287);
            this.AddPartSaveBtn.Name = "AddPartSaveBtn";
            this.AddPartSaveBtn.Size = new System.Drawing.Size(70, 32);
            this.AddPartSaveBtn.TabIndex = 22;
            this.AddPartSaveBtn.Text = "Save";
            this.AddPartSaveBtn.UseVisualStyleBackColor = true;
            this.AddPartSaveBtn.Click += new System.EventHandler(this.AddPartSaveBtn_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 338);
            this.Controls.Add(this.AddPartCancelBtn);
            this.Controls.Add(this.AddPartSaveBtn);
            this.Controls.Add(this.MachineIDTxtBx);
            this.Controls.Add(this.MachineIDLbl);
            this.Controls.Add(this.PartMaxTxtBx);
            this.Controls.Add(this.PartMaxLbl);
            this.Controls.Add(this.PartMinTxtBx);
            this.Controls.Add(this.PartMinLbl);
            this.Controls.Add(this.PartInventoryTxtBx);
            this.Controls.Add(this.InventoryLbl);
            this.Controls.Add(this.PartPriceTxtBx);
            this.Controls.Add(this.PartPriceLbl);
            this.Controls.Add(this.PartNameTxtBx);
            this.Controls.Add(this.PartNameLbl);
            this.Controls.Add(this.PartIdTxtBx);
            this.Controls.Add(this.PartIDLbl);
            this.Controls.Add(this.OutsourcedRdBtn);
            this.Controls.Add(this.InHouseRdBtn);
            this.Controls.Add(this.AddPartLbl);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLbl;
        private System.Windows.Forms.RadioButton InHouseRdBtn;
        private System.Windows.Forms.RadioButton OutsourcedRdBtn;
        private System.Windows.Forms.Label PartIDLbl;
        private System.Windows.Forms.TextBox PartIdTxtBx;
        private System.Windows.Forms.TextBox PartNameTxtBx;
        private System.Windows.Forms.Label PartNameLbl;
        private System.Windows.Forms.TextBox PartPriceTxtBx;
        private System.Windows.Forms.Label PartPriceLbl;
        private System.Windows.Forms.TextBox PartInventoryTxtBx;
        private System.Windows.Forms.Label InventoryLbl;
        private System.Windows.Forms.TextBox PartMinTxtBx;
        private System.Windows.Forms.Label PartMinLbl;
        private System.Windows.Forms.TextBox PartMaxTxtBx;
        private System.Windows.Forms.Label PartMaxLbl;
        private System.Windows.Forms.TextBox MachineIDTxtBx;
        private System.Windows.Forms.Label MachineIDLbl;
        private System.Windows.Forms.Button AddPartCancelBtn;
        private System.Windows.Forms.Button AddPartSaveBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}