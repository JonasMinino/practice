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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            InitialTextBox();
            //
            //AddProduct_Parts DGV DataSource//
            //
            BindingSource bs = new BindingSource()
            {
                DataSource = Inventory.parts
            };
            AddProduct_PartsDgv.DataSource = bs;

            foreach (DataGridViewColumn col in AddProduct_PartsDgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            AddProduct_PartsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //
            //AddProduct DGV Data Source//
            //
            BindingSource ba = new BindingSource()
            {
                DataSource = Inventory.asPart
            };
            AddProductDgv.DataSource = ba;

            foreach (DataGridViewColumn col in AddProductDgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            AddProductDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }    
        //
        //Empty textboxes color is Light Salmon///
        //
        public void InitialTextBox()
        {
            if (string.IsNullOrEmpty(ProductNameTxtBx.Text))
            {
                ProductNameTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(ProductPriceTxtBx.Text))
            {
                ProductPriceTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(ProductInventoryTxtBx.Text))
            {
                ProductInventoryTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(ProductMinTxtBx.Text))
            {
                ProductMinTxtBx.BackColor = Color.LightSalmon;

            }
            if (string.IsNullOrEmpty(ProductMaxTxtBx.Text))
            {
                ProductMaxTxtBx.BackColor = Color.LightSalmon;
            }

        }
        //
        // Product Name key press accepts: letters, backspace, delete, and spacebar//
        //
        private void ProductNameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 || c == '\0')
            {
                ProductNameTxtBx.Focus();
                ProductNameTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ProductNameTxtBx.Focus();
                ProductNameTxtBx.BackColor = Color.White;
            }
        }
        //
        // Product Price key press accepts: numbers, backspace, and delete//
        //
        private void ProductPriceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 8 && c != 46 || c == '\0')
            {
                ProductPriceTxtBx.Focus();
                ProductPriceTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ProductPriceTxtBx.Focus();
                ProductPriceTxtBx.BackColor = Color.White;
            }
        }
        //
        //Product Inventory key press accepts: numbers, backspace, and delete//
        //
        private void ProductInventoryTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ProductInventoryTxtBx.Focus();
                ProductInventoryTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ProductInventoryTxtBx.Focus();
                ProductInventoryTxtBx.BackColor = Color.White;
            }
        }
        //
        // Product Min key press accepts: numbers, backspace, and delete//
        //
        private void ProductMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ProductMinTxtBx.Focus();
                ProductMinTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ProductMinTxtBx.Focus();
                ProductMinTxtBx.BackColor = Color.White;
            }
        }
        //
        //Product Max key press accepts: numbers, backspace, and delete//
        //
        private void ProductMaxTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ProductMaxTxtBx.Focus();
                ProductMaxTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ProductMaxTxtBx.Focus();
                ProductMaxTxtBx.BackColor = Color.White;
            }
        }
        //
        // Warming, Max must be higher than Min//
        //Warning, there must be a minimum value//
        //Warming, there must be a maximum value//
        //If Max textbox is empty back color changes to light salmon//
        //
        private void ProductMaxTxtBx_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ProductMinTxtBx.Text) > Convert.ToInt32(ProductMaxTxtBx.Text))
                {
                    MessageBox.Show("The Maximum value must be higher than the Minimum value", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if(!string.IsNullOrEmpty(ProductMinTxtBx.Text) && string.IsNullOrEmpty(ProductMaxTxtBx.Text))
                {
                   DialogResult result = MessageBox.Show("You must include a Maxium number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (string.IsNullOrEmpty(ProductMinTxtBx.Text) && !string.IsNullOrEmpty(ProductMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Minimum number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (string.IsNullOrEmpty(ProductMaxTxtBx.Text))
            {
                ProductMaxTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Name textbox is empty backcolor returns to light salmon//
        //
        private void ProductNameTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductNameTxtBx.Text))
            {
                ProductNameTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Price textbox is empty backcolor returns to light salmon//
        //
        private void ProductPriceTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductPriceTxtBx.Text))
            {
                ProductPriceTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Inventory textbox is empty backcolor returns to light salmon//
        //
        private void ProductInventoryTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductInventoryTxtBx.Text))
            {
                ProductInventoryTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Min textbox is empty backcolor returns to light salmon//
        //
        private void ProductMinTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductMinTxtBx.Text))
            {
                ProductMinTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //Product Name Tool Tip//
        //
        private void ProductNameTxtBx_MouseHover(object sender, EventArgs e)
        {
            ProductTT.Show("A name is required", ProductNameTxtBx);
        }
        //
        //Product Price Tool Tip//
        //
        private void ProductPriceTxtBx_MouseHover(object sender, EventArgs e)
        {
            ProductTT.Show("A number is required", ProductPriceTxtBx);
        }
        //
        //Product Inventory Tool Tip//
        //
        private void ProductInventoryTxtBx_MouseHover(object sender, EventArgs e)
        {
            ProductTT.Show("A number is required", ProductInventoryTxtBx);
        }
        //
        //Product Min Tool Tip//
        //
        private void ProductMinTxtBx_MouseHover(object sender, EventArgs e)
        {
            ProductTT.Show("A number is required", ProductMinTxtBx);
        }
        //
        //Product Max Tool Tip//
        //
        private void ProductMaxTxtBx_MouseHover(object sender, EventArgs e)
        {
            ProductTT.Show("A number is required", ProductMaxTxtBx);
        }
        //
        //Highlight AddProduct_PartsDgv rows yellow on mouse enter//
        //
        private void AddProduct_PartsDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                AddProduct_PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
        //
        //Returns AddProduct_PartsDgv rows white on mouse leave//
        //
        private void AddProduct_PartsDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                AddProduct_PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        //
        //Add Product add button//
        //
        private void AddProduct_PartAddBtn_Click(object sender, EventArgs e)
        {
            Part part = (Part)AddProduct_PartsDgv.CurrentRow.DataBoundItem;
            Inventory.AsPartAdd(part);
        }
        //
        //Add Product delete button//
        //
        private void AddProduct_PartDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete part \"{AddProductDgv.CurrentRow.Cells[1].Value.ToString()}\" ?",
                "Delete Part", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Part newPart = (Part)AddProductDgv.CurrentRow.DataBoundItem;
                Inventory.AddPart(newPart);
                AddProductDgv.Rows.Remove(AddProductDgv.CurrentRow);
            }
        }
        //
        //Add Product Cancel Button//
        //
        private void AddProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.ShowDialog();
            this.Close();
        }
        //
        //Add Product Save Button//
        //Warning, There must be an associated part//
        //Warning, Inventory must be between Min and Max//
        //
        private void AddProductSaveBtn_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            if (Convert.ToInt32(ProductInventoryTxtBx.Text) < Convert.ToInt32(ProductMinTxtBx.Text) ||
                   Convert.ToInt32(ProductInventoryTxtBx.Text) > Convert.ToInt32(ProductMaxTxtBx.Text))
            {
                MessageBox.Show("The Inventory value must be between the Min and the Max",
                    "Inventory Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (AddProductDgv.RowCount > 0) //Saves the new product//
            {

                int id = (ms.ProductDgv.RowCount + 1);
                Product newProduct = new Product(id, ProductNameTxtBx.Text, Math.Round(Convert.ToDecimal(ProductPriceTxtBx.Text), 2), Convert.ToInt32(ProductInventoryTxtBx.Text),
                    Convert.ToInt32(ProductMinTxtBx.Text), Convert.ToInt32(ProductMaxTxtBx.Text));
                Inventory.ProductAdd(newProduct);

                this.Hide();
                ms.ShowDialog();
                this.Close();
            }
            else //warning message//
            {
                MessageBox.Show("There must be at least one part associated with a new product", "Associated Parts", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            
           
        }
        //
        //Add Product Part Search//
        //
        private void AddProduct_PartSearchBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AddProduct_PartsDgv.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(AddProduct_PartsSearchTxtBx.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)AddProduct_PartsDgv.BindingContext[AddProduct_PartsDgv.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
        //
        //Return DGV Data upon clear//
        //
        private void AddProduct_PartsSearchTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddProduct_PartsSearchTxtBx.Text))
            {
                foreach (DataGridViewRow row in AddProduct_PartsDgv.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
} 
