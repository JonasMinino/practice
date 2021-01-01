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
    public partial class ModifyPart : Form
    {
        //
        //Load InHouse Part to Modify Form//
        //
        public ModifyPart(InHouse inpart)
        {
            InitializeComponent();

            ModifyPartIdTxtBx.Text = inpart.PartID.ToString();
            ModifyPartNameTxtBx.Text = inpart.Name;
            ModifyPartPriceTxtBx.Text = inpart.Price.ToString();
            ModifyPartInventoryTxtBx.Text = inpart.Inventory.ToString();
            ModifyPartMinTxtBx.Text = inpart.Min.ToString();
            ModifyPartMaxTxtBx.Text = inpart.Max.ToString();
            ModifyMachineIDTxtBx.Text = inpart.MachineID.ToString();

            ModifyInHouseRdBtn.Checked = true;
            InitialTextBox();
        }
        //
        //Load Outsourced Part to Modify Form//
        //
        public ModifyPart(Outsourced outpart)
        {
            InitializeComponent();

            ModifyPartIdTxtBx.Text = outpart.PartID.ToString();
            ModifyPartNameTxtBx.Text = outpart.Name;
            ModifyPartPriceTxtBx.Text = outpart.Price.ToString();
            ModifyPartInventoryTxtBx.Text = outpart.Inventory.ToString();
            ModifyPartMinTxtBx.Text = outpart.Min.ToString();
            ModifyPartMaxTxtBx.Text = outpart.Max.ToString();
            ModifyMachineIDTxtBx.Text = outpart.CompanyName;

            ModifyOutsourcedRdBtn.Checked = true;
            InitialTextBox();
        }
        //
        //Empty textboxes color is Light Salmon///
        //
        public void InitialTextBox()
        {
            if (String.IsNullOrEmpty(ModifyPartNameTxtBx.Text))
            {
                ModifyPartNameTxtBx.BackColor = Color.LightSalmon;
                ModifyPartPriceTxtBx.BackColor = Color.LightSalmon;
                ModifyPartInventoryTxtBx.BackColor = Color.LightSalmon;
                ModifyPartMinTxtBx.BackColor = Color.LightSalmon;
                ModifyPartMaxTxtBx.BackColor = Color.LightSalmon;
                ModifyMachineIDTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        // Name textbox key press accepts only letters, space, backspace, and delete//
        //
        private void ModifyPartNameTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 || c == '\0')
            {
                ModifyPartNameTxtBx.Focus();
                ModifyPartNameTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyPartNameTxtBx.Focus();
                ModifyPartNameTxtBx.BackColor = Color.White;
            }

        }
        //
        // Price textbox key press accepts only letters, backspace, and delete//
        //
        private void ModifyPartPriceTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 8 && c != 46 || c == '\0')
            {
                ModifyPartPriceTxtBx.Focus();
                ModifyPartPriceTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyPartPriceTxtBx.Focus();
                ModifyPartPriceTxtBx.BackColor = Color.White;
            }
        }
        //
        // Inventory textbox key press accepts only letters, backspace, and delete//
        //
        private void ModifyPartInventoryTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ModifyPartInventoryTxtBx.Focus();
                ModifyPartInventoryTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyPartInventoryTxtBx.Focus();
                ModifyPartInventoryTxtBx.BackColor = Color.White;
            }
        }
        //
        // Min textbox key press accepts only letters, backspace, and delete//
        //
        private void ModifyPartMinTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ModifyPartMinTxtBx.Focus();
                ModifyPartMinTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyPartMinTxtBx.Focus();
                ModifyPartMinTxtBx.BackColor = Color.White;
            }

        }
        //
        // Max textbox key press accepts only letters, backspace, and delete//
        //
        private void ModifyPartMaxTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
            {
                ModifyPartMaxTxtBx.Focus();
                ModifyPartMaxTxtBx.BackColor = Color.LightSalmon;
            }
            else
            {
                ModifyPartMaxTxtBx.Focus();
                ModifyPartMaxTxtBx.BackColor = Color.White;
            }
        }
        //
        // MachineID textbox key press accepts only letters, backspace, and delete//
        //
        private void ModifyMachineIDTxtBx_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            //In-House Part//
            if (ModifyInHouseRdBtn.Checked)
            {

                if (!char.IsNumber(c) && c != 46 && c != 8 || c == '\0')
                {
                    ModifyMachineIDTxtBx.Focus();
                    ModifyMachineIDTxtBx.BackColor = Color.LightSalmon;
                }
                else
                {
                    ModifyMachineIDTxtBx.Focus();
                    ModifyMachineIDTxtBx.BackColor = Color.White;
                }
            }
            //Outsourced Part//
            else
            {
                if (!char.IsLetter(c) && c != 8 && c != 46 && c != 32 || c == '\0')
                {
                    ModifyMachineIDTxtBx.Focus();
                    ModifyMachineIDTxtBx.BackColor = Color.LightSalmon;
                }
                else
                {
                    ModifyMachineIDTxtBx.Focus();
                    ModifyMachineIDTxtBx.BackColor = Color.White;
                }
            }
        }   
        //
        //Modify Name Tool Tip//
        //
        private void ModifyPartNameTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyTT.Show("A name is required", ModifyPartNameTxtBx);
        }
        //
        //Modify Price Tool Tip//
        //
        private void ModifyPartPriceTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyTT.Show("A number is required", ModifyPartPriceTxtBx);
        }
        //
        //Modify Inventory Tool Tip//
        //
        private void ModifyPartInventoryTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyTT.Show("A number is required", ModifyPartInventoryTxtBx);
        }
        //
        //Modify Min Tool Tip//
        //
        private void ModifyPartMinTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyTT.Show("A number is required", ModifyPartMinTxtBx);
        }
        //
        //Modify Max Tool Tip//
        //
        private void ModifyPartMaxTxtBx_MouseHover(object sender, EventArgs e)
        {
            ModifyTT.Show("A number is required", ModifyPartMaxTxtBx);
        }
        //
        // Modify Machine ID Tool Tip//
        //
        private void ModifyMachineIDTxtBx_MouseHover(object sender, EventArgs e)
        {
            if (ModifyInHouseRdBtn.Checked == true)
            {
                ModifyTT.Show("A number is required", ModifyMachineIDTxtBx);

            }
            else
            {
                ModifyTT.Show("A  company name is required", ModifyMachineIDTxtBx);

            }
        }
        //
        // Machine ID Label Change "Machine ID"//
        //Empty MachineId Textbox if letters are present//
        //
        private void ModifyInHouseRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            ModifyMachineIDLbl.Text = "Machine ID";
            if (!int.TryParse(ModifyMachineIDTxtBx.Text, out int parseValue))
            {
                ModifyMachineIDTxtBx.Text = string.Empty;
                ModifyMachineIDTxtBx.BackColor = Color.LightSalmon;
            }

        }
        //
        // Machine ID Label Change "Company Name"//
        //Empty MachineId Textbox if numbers are present//
        //
        private void ModifyOutsourcedRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            ModifyMachineIDLbl.Text = "Company Name";
            if (int.TryParse(ModifyMachineIDTxtBx.Text, out int parseValue))
            {
                ModifyMachineIDTxtBx.Text = string.Empty;
                ModifyMachineIDTxtBx.BackColor = Color.LightSalmon;
            }
        }

        //
        //Warning, Max must be higher than Min//
        //Warning, must have a minimum number//
        //Warning, must have a maximum number//
        //If Textbox is empty color returns to Light Salmon//
        //
        private void ModifyPartMaxTxtBx_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ModifyPartMinTxtBx.Text) > Convert.ToInt32(ModifyPartMaxTxtBx.Text))
                {
                    MessageBox.Show("The Maximum value must be higher than the Minimum value", "Min/Max",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                if (!string.IsNullOrEmpty(ModifyPartMinTxtBx.Text) && string.IsNullOrEmpty(ModifyPartMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Maxium number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (string.IsNullOrEmpty(ModifyPartMinTxtBx.Text) && !string.IsNullOrEmpty(ModifyPartMaxTxtBx.Text))
                {
                    DialogResult result = MessageBox.Show("You must include a Minimum number", "Min && Max", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (string.IsNullOrEmpty(ModifyPartMaxTxtBx.Text))
            {
                ModifyPartMaxTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //Modify cancel button click//
        //
        private void ModifyAddPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen ms = new MainScreen();
            ms.ShowDialog();
            this.Close();
        }
        //
        //Modify save button click//
        //
        private void ModifyAddPartSaveBtn_Click(object sender, EventArgs e)
        {
            if (ModifyInHouseRdBtn.Checked == true)
            {
                InHouse inpart = new InHouse(Convert.ToInt32(ModifyPartIdTxtBx.Text), ModifyPartNameTxtBx.Text.ToString(), Convert.ToDecimal(ModifyPartPriceTxtBx.Text),
                    Convert.ToInt32(ModifyPartInventoryTxtBx.Text), Convert.ToInt32(ModifyPartMinTxtBx.Text), Convert.ToInt32(ModifyPartMaxTxtBx.Text),
                    Convert.ToInt32(ModifyMachineIDTxtBx.Text));
                               
                foreach(Part part in Inventory.parts.ToArray())
                {
                    if(part.PartID == inpart.PartID)
                    {
                        Inventory.parts.Remove(part);
                    }
                }

                Inventory.parts.Add(inpart);






            }
            else
            {
                Outsourced outpart = new Outsourced(Convert.ToInt32(ModifyPartIdTxtBx.Text), ModifyPartNameTxtBx.Text.ToString(),
                    Convert.ToDecimal(ModifyPartPriceTxtBx.Text), Convert.ToInt32(ModifyPartInventoryTxtBx.Text), Convert.ToInt32(ModifyPartMinTxtBx.Text),
                    Convert.ToInt32(ModifyPartMaxTxtBx.Text), ModifyMachineIDTxtBx.Text.ToString());


                foreach (Part part in Inventory.parts.ToArray())
                {
                    if (part.PartID == outpart.PartID)
                    {
                        Inventory.parts.Remove(part);
                    }
                }

                Inventory.parts.Add(outpart);


            }



            if (Convert.ToInt32(ModifyPartInventoryTxtBx.Text) < Convert.ToInt32(ModifyPartMinTxtBx.Text) ||
               Convert.ToInt32(ModifyPartInventoryTxtBx.Text) > Convert.ToInt32(ModifyPartMaxTxtBx.Text))
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
        //Name textbox background returns to Light Salmon when empty
        //
        private void ModifyPartNameTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyPartNameTxtBx.Text))
            {
                ModifyPartNameTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //Price textbox background returns to Light Salmon when empty
        //
        private void ModifyPartPriceTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyPartPriceTxtBx.Text))
            {
                ModifyPartPriceTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //Inventory textbox background returns to Light Salmon when empty
        //
        private void ModifyPartInventoryTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyPartInventoryTxtBx.Text))
            {
                ModifyPartInventoryTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //Min textbox background returns to Light Salmon when empty
        //
        private void ModifyPartMinTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyPartMinTxtBx.Text))
            {
                ModifyPartMinTxtBx.BackColor = Color.LightSalmon;
            }
        }
        //
        //MachineID textbox background returns to Light Salmon when empty
        //
        private void ModifyPartMachineIDTxtBx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyMachineIDTxtBx.Text))
            {
                ModifyMachineIDTxtBx.BackColor = Color.LightSalmon;
            }
        }

    }
}
