using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();

            //
            //ModifyProduct_Parts DGV DataSource//
            //
            BindingSource bs = new BindingSource()
            {
                DataSource = Inventory.parts
            };
            ModifyProduct_PartsDgv.DataSource = bs;

            foreach (DataGridViewColumn col in ModifyProduct_PartsDgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            ModifyProduct_PartsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //
            //ModifyProduct DGV Data Source//
            //
            BindingSource ba = new BindingSource()
            {
                DataSource = Inventory.asPart
            };
            
            ModifyProductDgv.DataSource = ba;

            foreach (DataGridViewColumn col in ModifyProductDgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            ModifyProductDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
            
        //
        // Modify Product Name key press accepts: letters, backspace, delete, and spacebar//
        //
        private void ModifyProductNameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 || c == '\0')
            {
                ModifyProductNameTxtBx.Focus();
                ModifyProductNameTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyProductNameTxtBx.Focus();
                ModifyProductNameTxtBx.BackColor = Color.White;
            }
        }
        //
        // Modify Product Price key press accepts: numbers, backspace, and delete//
        //
        private void ModifyProductPriceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 8 && c != 46 || c == '\0')
            {
                ModifyProductPriceTxtBx.Focus();
                ModifyProductPriceTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyProductPriceTxtBx.Focus();
                ModifyProductPriceTxtBx.BackColor = Color.White;
            }
        }
        //
        //Modify Product Inventory key press accepts: numbers, backspace, and delete//
        //
        private void ModifyProductInventoryTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ModifyProductInventoryTxtBx.Focus();
                ModifyProductInventoryTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyProductInventoryTxtBx.Focus();
                ModifyProductInventoryTxtBx.BackColor = Color.White;
            }
        }
        //
        // Modify Product Min key press accepts: numbers, backspace, and delete//
        //
        private void ModifyProductMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ModifyProductMinTxtBx.Focus();
                ModifyProductMinTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyProductMinTxtBx.Focus();
                ModifyProductMinTxtBx.BackColor = Color.White;
            }
        }
        //
        //Modify Product Max key press accepts: numbers, backspace, and delete//
        //
        private void ModifyProductMaxTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ModifyProductMaxTxtBx.Focus();
                ModifyProductMaxTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyProductMaxTxtBx.Focus();
                ModifyProductMaxTxtBx.BackColor = Color.White;
            }
        }
        //
        // Warming, Max must be higher than Min//
        //Warning, there must be a minimum value//
        //Warming, there must be a maximum value//
        //If Max textbox is empty back color changes to light salmon//
        //
        private void ModifyProductMaxTxtBx_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ModifyProductMinTxtBx.Text) > Convert.ToInt32(ModifyProductMaxTxtBx.Text))
                {
                    MessageBox.Show("The Maximum value must be higher than the Minimum value", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (!string.IsNullOrEmpty(ModifyProductMinTxtBx.Text) && string.IsNullOrEmpty(ModifyProductMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Maxium number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (string.IsNullOrEmpty(ModifyProductMinTxtBx.Text) && !string.IsNullOrEmpty(ModifyProductMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Minimum number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (string.IsNullOrEmpty(ModifyProductMaxTxtBx.Text))
            {
                ModifyProductMaxTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Name textbox is empty backcolor returns to light salmon//
        //
        private void ModifyProductNameTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductNameTxtBx.Text))
            {
                ModifyProductNameTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Price textbox is empty backcolor returns to light salmon//
        //
        private void ModifyProductPriceTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductPriceTxtBx.Text))
            {
                ModifyProductPriceTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Inventory textbox is empty backcolor returns to light salmon//
        //
        private void ModifyProductInventoryTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductInventoryTxtBx.Text))
            {
                ModifyProductInventoryTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Min textbox is empty backcolor returns to light salmon//
        //
        private void ModifyProductMinTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductMinTxtBx.Text))
            {
                ModifyProductMinTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //Modify Product Max Textbox Color Change to Light Salmon
        //Warning Max must be higher than Min//
        //Warning, there must be a minimum value//
        //Warning, there must be a maximum value//
        //
        private void ModifyProductMaxTxtBx_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductMaxTxtBx.Text))
            {
                ModifyProductMaxTxtBx.BackColor = Color.LightSalmon;
            }

            try
            {
                if (Convert.ToInt32(ModifyProductMinTxtBx.Text) > Convert.ToInt32(ModifyProductMaxTxtBx.Text))
                {
                    MessageBox.Show("The Maximum must be higher than the Minimum", "Min/Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                if (string.IsNullOrEmpty(ModifyProductMinTxtBx.Text) && !string.IsNullOrEmpty(ModifyProductMaxTxtBx.Text))
                {
                    MessageBox.Show("There must be a Minimum value", "Min/Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (!string.IsNullOrEmpty(ModifyProductMinTxtBx.Text) && string.IsNullOrEmpty(ModifyProductMaxTxtBx.Text))
                {
                    MessageBox.Show("There must be a Maximum value", "Min/Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //
        //Modify Product Name Tool Tip//
        //
        private void ModifyProductNameTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyProductTT.Show("A name is required", ModifyProductNameTxtBx);
        }
        //
        //Modify Product Price Tool Tip//
        //
        private void ModifyProductPriceTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyProductTT.Show("A number is required", ModifyProductPriceTxtBx);
        }
        //
        //Modify Product Inventory Tool Tip//
        //
        private void ModifyProductInventoryTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyProductTT.Show("A number is required", ModifyProductInventoryTxtBx);
        }
        //
        //Modify Product Min Tool Tip//
        //
        private void ModifyProductMinTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyProductTT.Show("A number is required", ModifyProductMinTxtBx);
        }
    
        //
        //Modify Product Max Tool Tip//
        //
        private void ModifyProductMaxTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyProductTT.Show("A number is required", ModifyProductMaxTxtBx);
        }
        //
        //Highlight ModifyProduct_PartsDgv rows yellow on mouse enter//
        //
        private void ModifyProduct_PartsDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProduct_PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
        //
        //Returns ModifyProduct_PartsDgv rows white on mouse leave//
        //
        private void ModifyProduct_PartsDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProduct_PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        //
        //Add Product add button//
        //
        private void ModifyProduct_PartAddBtn_Click(object sender, EventArgs e)
        {
            Part part = (Part)ModifyProduct_PartsDgv.CurrentRow.DataBoundItem;
            Inventory.AsPartAdd(part);
        }
        //
        //Modify Product delete button//
        //
        private void ModifyProduct_PartDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete part \"{ModifyProductDgv.CurrentRow.Cells[1].Value.ToString()}\" ?",
                "Delete Part", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ModifyProductDgv.Rows.Remove(ModifyProductDgv.CurrentRow);
            }
        }
        //
        //Modify Product Cancel Button//
        //
        private void ModifyProductCancelBtn_Click(object sender, EventArgs e)
        {
            foreach(Product pro in Inventory.products)
            {
                int id = pro.ProductID;
                ModifyProduct mp = new ModifyProduct();

                switch (id)
                {
                    
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        mp.ModifyProductDgv.Update();
                        mp.ModifyProductDgv.Rows.Clear();
                        break;
                }
            }        
            
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.ShowDialog();
            this.Close();
        }
        //
        //Modify Product Save Button//
        //
        private void ModifyAddProductSaveBtn_Click(object sender, EventArgs e)
        {
            foreach (Product pro in Inventory.products)
            {
                int id = pro.ProductID;
                ModifyProduct mp = new ModifyProduct();

                if (Convert.ToInt32(ModifyProductIdTxtBx.Text) == id)
                {
                    pro.ProductName = ModifyProductNameTxtBx.Text;
                    pro.ProductPrice = Convert.ToDecimal(ModifyProductPriceTxtBx.Text);
                    pro.ProductInventory = Convert.ToInt32(ModifyProductInventoryTxtBx.Text);
                    pro.ProductMin = Convert.ToInt32(ModifyProductMinTxtBx.Text);
                    pro.ProductMax = Convert.ToInt32(ModifyProductMaxTxtBx.Text);
                }
            }

            ModifyProductDgv.DataSource = null;
            BindingSource bs2 = new BindingSource()
            {
                DataSource = Inventory.asPart
            };

            ModifyProductDgv.DataSource = bs2;


            if (Convert.ToInt32(ModifyProductInventoryTxtBx.Text) < Convert.ToInt32(ModifyProductMinTxtBx.Text) ||
                Convert.ToInt32(ModifyProductInventoryTxtBx.Text) > Convert.ToInt32(ModifyProductMaxTxtBx.Text))
            {
                DialogResult result = MessageBox.Show("The Inventory value must be between the Min and the Max",
                    "Inventory Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainScreen ms = new MainScreen();
                this.Hide();
                ms.ShowDialog();
                this.Close();

            }

        }
        //
        //Highlight Product_Parts DGV Row Yellow on Mousehover//
        //
        private void ModifyProduct_PartsDgv_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProduct_PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
        //
        //Row back to white on MouseLeave//
        //
        private void ModifyProduct_PartsDgv_CellMouseLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProduct_PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        //
        //Highlight Product DGV row yellow on MouseHover//
        //
        private void ModifyProductDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProductDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;

            }
        }
        //
        //Return Product DGV Row back to white//
        //
        private void ModifyProductDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ModifyProductDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }

        }
        //
        //Serch Button Press//
        //
        private void ModifyProduct_PartSearchBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in ModifyProduct_PartsDgv.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(ModifyProduct_PartsSearchTxtBx.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)ModifyProduct_PartsDgv.BindingContext[ModifyProduct_PartsDgv.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
        //
        //Return DGV Data upon clear//
        //
        private void ModifyProduct_PartsSearchTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProduct_PartsSearchTxtBx.Text))
            {
                foreach(DataGridViewRow row in ModifyProduct_PartsDgv.Rows)
                {
                    row.Visible = true;
                }
            }
        }
        
    }
}
