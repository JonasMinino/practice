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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            InitialTextBox();
        }
        //
        //Empty textboxes color is Light Salmon///
        //
        public void InitialTextBox()
        {
            if (string.IsNullOrEmpty(PartNameTxtBx.Text))
            {
                PartNameTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(PartPriceTxtBx.Text))
            {
                PartPriceTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(PartInventoryTxtBx.Text))
            {
                PartInventoryTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(PartMinTxtBx.Text))
            {
                PartMinTxtBx.BackColor = Color.LightSalmon;

            }
            if (string.IsNullOrEmpty(PartMaxTxtBx.Text))
            {
                PartMaxTxtBx.BackColor = Color.LightSalmon;
            }
            if (string.IsNullOrEmpty(MachineIDTxtBx.Text))
            {
                MachineIDTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        // Name textbox key press accepts only letters, space, backspace, and delete//
        //
        private void PartNameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 || c == '\0')
            {
                PartNameTxtBx.Focus();
                PartNameTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                PartNameTxtBx.Focus();
                PartNameTxtBx.BackColor = Color.White;
            }
        }
        //
        // Price textbox key press accepts only letters, backspace, and delete//
        //
        private void PartPriceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 8 && c != 46 || c == '\0')
            {
                PartPriceTxtBx.Focus();
                PartPriceTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                PartPriceTxtBx.Focus();
                PartPriceTxtBx.BackColor = Color.White;
            }
        }
        //
        // Inventory textbox key press accepts only letters, backspace, and delete//
        //
        private void PartInventoryTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                PartInventoryTxtBx.Focus();
                PartInventoryTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                PartInventoryTxtBx.Focus();
                PartInventoryTxtBx.BackColor = Color.White;
            }
        }
        //
        // Min textbox key press accepts only letters, backspace, and delete//
        //
        private void PartMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                PartMinTxtBx.Focus();
                PartMinTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                PartMinTxtBx.Focus();
                PartMinTxtBx.BackColor = Color.White;
            }

        }
        //
        // Max textbox key press accepts only letters, backspace, and delete//
        //
        private void PartMaxTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                PartMaxTxtBx.Focus();
                PartMaxTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                PartMaxTxtBx.Focus();
                PartMaxTxtBx.BackColor = Color.White;
            }

        }
        //
        // MachineID textbox key press accepts only letters, backspace, and delete//
        //
        private void MachineIDTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
           
            //In-House Part//
            if (InHouseRdBtn.Checked)
            {

                if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
                {
                    MachineIDTxtBx.Focus();
                    MachineIDTxtBx.BackColor = Color.LightSalmon;
                }
                else
                {
                    MachineIDTxtBx.Focus();
                    MachineIDTxtBx.BackColor = Color.White;
                }

            }

            //Outsourced Part//
            else
            {
                if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 || c == '\0')
                {
                    MachineIDTxtBx.Focus();
                    MachineIDTxtBx.BackColor = Color.LightSalmon;
                }
                else
                {
                    MachineIDTxtBx.Focus();
                    MachineIDTxtBx.BackColor = Color.White;
                }
            }
        }
        //
        // In-House radio button Machine ID label//
        //
        private void InHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDLbl.Text = "Machine ID";
        }
        //
        // Outsourced radio button Machine ID label//
        //
        private void OutsourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            MachineIDLbl.Text = "Company Name";
        }
        //
        // Add Part cancel button click//
        //
        private void AddPartCancelBtn_Click(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            this.Hide();
            ms.ShowDialog();
            this.Close();
        }
        //
        //Name text box tool tip//
        //
        private void PartNameTxtBx_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A name is required", PartNameTxtBx);
        }
        //
        // Price text box tool tip//
        //
        private void PartPriceTxtBx_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A number is required", PartPriceTxtBx);
        }
        //
        // Invenotry text box tool tip//
        //
        private void PartInventoryTxtBx_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A number is required", PartInventoryTxtBx);
        }
        //
        // Min text box tool tip//
        //
        private void PartMinTxtBx_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A number is required", PartMinTxtBx);
        }
        //
        // Max text box tool tip//
        //
        private void PartMaxTxtBx_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A number is required", PartMaxTxtBx);
        }
        //
        // Machine ID text box tool tip//
        //
        private void MachineIDTxtBx_MouseHover(object sender, EventArgs e)
        {
            if (InHouseRdBtn.Checked)
            {
                toolTip1.Show("A number is required", MachineIDTxtBx);
            }
            else
            {
                toolTip1.Show("A company name is required", MachineIDTxtBx);
            }
        }
        //
        //Add Part Save Button//
        //Warning, Inventory must be bewtween Min and Max//
        //
        private void AddPartSaveBtn_Click(object sender, EventArgs e)
        {
            if (InHouseRdBtn.Checked)
            {
                InHouse inpart = new InHouse((Inventory.parts.Count + 1), PartNameTxtBx.Text.ToString(),
                    Convert.ToDecimal(PartPriceTxtBx.Text), Convert.ToInt32(PartInventoryTxtBx.Text),
                    Convert.ToInt32(PartMinTxtBx.Text), Convert.ToInt32(PartMaxTxtBx.Text), Convert.ToInt32(MachineIDTxtBx.Text));

                Inventory.AddPart(inpart);
            }
            if (OutsourcedRdBtn.Checked)
            {
                Outsourced outpart = new Outsourced((Inventory.parts.Count + 1), PartNameTxtBx.Text.ToString(),
                    Convert.ToDecimal(PartPriceTxtBx.Text), Convert.ToInt32(PartInventoryTxtBx.Text),
                    Convert.ToInt32(PartMinTxtBx.Text), Convert.ToInt32(PartMaxTxtBx.Text), MachineIDTxtBx.Text.ToString());

                Inventory.AddPart(outpart);
            }


            if (Convert.ToInt32(PartInventoryTxtBx.Text) < Convert.ToInt32(PartMinTxtBx.Text) ||
               Convert.ToInt32(PartInventoryTxtBx.Text) > Convert.ToInt32(PartMaxTxtBx.Text))
            {
                MessageBox.Show("The Inventory value must be between the Min and the Max",
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
        //Warning, Max must be higher than Min//
        //Warning, must have a minimum number//
        //Warning, must have a maximum number//
        //If Textbox is empty color returns to Light Salmon//
        //If 
        //
        private void PartMaxTxtBx_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(PartMinTxtBx.Text) > Convert.ToInt32(PartMaxTxtBx.Text))
                {
                    MessageBox.Show("The Maximum value must be higher than the Minimum value", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (!string.IsNullOrEmpty(PartMinTxtBx.Text) && string.IsNullOrEmpty(PartMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Maxium number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (string.IsNullOrEmpty(PartMinTxtBx.Text) && !string.IsNullOrEmpty(PartMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Minimum number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (string.IsNullOrEmpty(PartMaxTxtBx.Text))
            {
                PartMaxTxtBx.BackColor = Color.LightSalmon;
            }
           
        }
        //
        //If Name textbox is empty backcolor returns to light salmon//
        //
        private void PartNameTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PartNameTxtBx.Text))
            {
                PartNameTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Price textbox is empty backcolor returns to light salmon//
        //
        private void PartPriceTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PartPriceTxtBx.Text))
            {
                PartPriceTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Inventory textbox is empty backcolor returns to light salmon//
        //
        private void PartInventoryTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PartInventoryTxtBx.Text))
            {
                PartInventoryTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If Min textbox is empty backcolor returns to light salmon//
        //
        private void PartMinTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PartMinTxtBx.Text))
            {
                PartMinTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //If MachineID textbox is empty backcolor returns to light salmon//
        //
        private void MachineIDTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MachineIDTxtBx.Text))
            {
                MachineIDTxtBx.BackColor = Color.LightSalmon;
            }
        }
    }
}
