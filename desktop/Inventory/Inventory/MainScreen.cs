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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            BindingSource bs = new BindingSource()
            {
                DataSource = Inventory.parts
            };
            PartsDgv.DataSource = bs;

            foreach (DataGridViewColumn col in PartsDgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            PartsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingSource bp = new BindingSource()
            {
                DataSource = Inventory.products
            };
            ProductDgv.DataSource = bp;

            foreach (DataGridViewColumn col in ProductDgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            ProductDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        //
        //Main Screen Exit Button//
        //
        private void MainScreenExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        // Parts DGV Mouse enter backcolor yellow/
        //
        private void PartsDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            { 
                PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
        //
        //Parts DGV Mouse leave backcolor white//
        //
        private void PartsDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            { 
                PartsDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        //
        //Part Add button//
        //
        private void PartsAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart ap = new AddPart();
            ap.ShowDialog();

        }
        //
        //Part Delete Button//
        //
        private void PartsDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete \"{PartsDgv.CurrentRow.Cells[1].Value.ToString()}\" part?", 
                "Delete Part", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
               
                    PartsDgv.Rows.Remove(PartsDgv.CurrentRow);             
 
            }
                        
        }
        //
        //Part Modify Button//
        //
        private void PartsModifyBtn_Click(object sender, EventArgs e)
        {
            if(PartsDgv.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
            {
                InHouse inPart = (InHouse)PartsDgv.CurrentRow.DataBoundItem;
                ModifyPart mp = new ModifyPart(inPart);

                this.Hide();
                mp.ShowDialog();
            }
            if(PartsDgv.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outPart = (Outsourced)PartsDgv.CurrentRow.DataBoundItem;
                ModifyPart mp = new ModifyPart(outPart);

                this.Hide();
                mp.ShowDialog();
            }
            
            

            
        }
        //
        //Parts search button click//
        //
        private void PartsSearchBtn_Click(object sender, EventArgs e)
        {
           foreach (DataGridViewRow row in PartsDgv.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(PartsSearchTxtBx.Text.ToString()))
                
                {
                    row.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)PartsDgv.BindingContext[PartsDgv.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                                                           
                }
            }
        }
        //
        //Return DGV Back to original state//
        //
        private void PartsSearchTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PartsSearchTxtBx.Text))
            {
                BindingSource bs = new BindingSource()
                {
                    DataSource = Inventory.parts
                };
                PartsDgv.DataSource = bs;
            }
        }
        //
        //Highlight Product DGV row yellow//
        //
        private void ProductDgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ProductDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        //
        //Returns the Product DGV row back to white//
        //
        private void ProductDgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ProductDgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
        //
        // Product Add Button//
        //
        private void ProductAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
            
        }
        //
        // Product Delete Button//
        //
        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
               if (Inventory.asPart.Count == 0)
                {
                    ProductDgv.Rows.Remove(ProductDgv.CurrentRow);

                }
               else
                {
                    MessageBox.Show("Cannot delete a Product with Parts associated", "Parts Associated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
        //
        //Product Search Button//
        //
        private void ProductSearchBtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in ProductDgv.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(ProductSearchTxtBx.Text.ToString()))

                {
                    row.Visible = true;
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)ProductDgv.BindingContext[ProductDgv.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }
        //
        //Returning Product Data Grid View Data//
        //
        private void ProductSearchTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProductSearchTxtBx.Text))
            {
                ProductDgv.DataSource = Inventory.products;
            }
        }
        //
        //Product Modify Button//
        //
        private void ProductModifyBtn_Click(object sender, EventArgs e)
        {
            //
            //Populate the textboxes//
            //
            ModifyProduct mp = new ModifyProduct();
            mp.ModifyProductIdTxtBx.Text = ProductDgv.CurrentRow.Cells[0].Value.ToString();
            mp.ModifyProductNameTxtBx.Text = ProductDgv.CurrentRow.Cells[1].Value.ToString();
            mp.ModifyProductPriceTxtBx.Text = ProductDgv.CurrentRow.Cells[2].Value.ToString();
            mp.ModifyProductInventoryTxtBx.Text = ProductDgv.CurrentRow.Cells[3].Value.ToString();
            mp.ModifyProductMinTxtBx.Text = ProductDgv.CurrentRow.Cells[4].Value.ToString();
            mp.ModifyProductMaxTxtBx.Text = ProductDgv.CurrentRow.Cells[5].Value.ToString();
            //
            //Associate Parts to Original Products//
            //
            Inventory.populateAssociated();

            this.Hide();
            mp.ShowDialog();
        }
    }
}
