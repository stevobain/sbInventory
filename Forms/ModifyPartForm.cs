using sbInventory.Models;

namespace sbInventory.Forms
{
    public partial class ModifyPartForm : Form
    {
        Part PartToUpdate;

        public ModifyPartForm(Part part)
        {
            InitializeComponent();

            if (part is In_House)
            {
                In_House in_House = (In_House)part;
                inHouseRadioButton.Checked = true;
                outsourcedRadioButton.Checked = false;
                label8.Text = "Machine ID";
                machineIdCompanyNameTextBox.Text = in_House.MachineID.ToString();
            }
            else
            {
                Outsourced outsourced = (Outsourced)part;
                outsourcedRadioButton.Checked = true;
                inHouseRadioButton.Checked = false;
                label8.Text = "Company Name";
                machineIdCompanyNameTextBox.Text = outsourced.CompanyName;
            }

            idTextBox.Text = part.PartID.ToString();
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = part.InStock.ToString();
            priceCostTextBox.Text = part.Price.ToString();
            minTextBox.Text = part.Min.ToString();
            maxTextBox.Text = part.Max.ToString();

            PartToUpdate = part;

            saveButton.Enabled = true;
        }

        private void inHouseOrOutsourced()
        {
            if (inHouseRadioButton.Checked)
            {
                outsourcedRadioButton.Checked = false;
                label8.Text = "Machine ID";
            }
            else if (outsourcedRadioButton.Checked)
            {
                inHouseRadioButton.Checked = false;
                label8.Text = "Company Name";
            }
        }

        private void inHouseRadioButton_Click(object sender, EventArgs e)
        {
            inHouseOrOutsourced();
        }

        private void outsourcedRadioButton_Click(object sender, EventArgs e)
        {
            inHouseOrOutsourced();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);

            string name = nameTextBox.Text;

            if (!int.TryParse(inventoryTextBox.Text, out int inStock))
            {
                MessageBox.Show("Please enter a number for Inventory.", "Invalid Inventory", MessageBoxButtons.OK);
                return;
            }

            if (!decimal.TryParse(priceCostTextBox.Text, out decimal price))
            {
                MessageBox.Show("Please enter a number for Price.", "Invalid Price", MessageBoxButtons.OK);
                return;
            }
            else
            {
                price = decimal.Parse(decimal.Parse(priceCostTextBox.Text).ToString("F"));
            }

            if (!int.TryParse(maxTextBox.Text, out int max))
            {
                MessageBox.Show("Please enter a number for Max.", "Invalid Max", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(minTextBox.Text, out int min))
            {
                MessageBox.Show("Please enter a number for Min.", "Invalid Min", MessageBoxButtons.OK);
                return;
            }

            if (max < min || min > max)
            {
                MessageBox.Show("Please ensure Max is greater than Min and Min is less than Max.", "Invalid Max/Min", MessageBoxButtons.OK);
                return;
            }

            if (inStock > max || min > inStock)
            {
                MessageBox.Show("Please ensure Inventory is not greater than Max or less than Min.", "Invalid Inventory", MessageBoxButtons.OK);
                return;
            }

            PartToUpdate.Name = name;
            PartToUpdate.InStock = inStock;
            PartToUpdate.Price = price;
            PartToUpdate.Min = min;
            PartToUpdate.Max = max;

            if (inHouseRadioButton.Checked)
            {
                if (!int.TryParse(machineIdCompanyNameTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Please enter a number for Machine ID.", "Invalid Machine ID", MessageBoxButtons.OK);
                    return;
                }

                In_House inHousePartToUpdate = (In_House)PartToUpdate;
                inHousePartToUpdate.MachineID = machineId;
                Inventory.UpdatePart(id, inHousePartToUpdate);
            }
            else if (outsourcedRadioButton.Checked)
            {
                string companyName = machineIdCompanyNameTextBox.Text;

                Outsourced outsourcedPartToUpdate = (Outsourced)PartToUpdate;
                outsourcedPartToUpdate.CompanyName = companyName;
                Inventory.UpdatePart(id, outsourcedPartToUpdate);
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidateTextBoxes()
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(inventoryTextBox.Text) && !string.IsNullOrEmpty(priceCostTextBox.Text) &&
                !string.IsNullOrEmpty(maxTextBox.Text) && !string.IsNullOrEmpty(minTextBox.Text) && !string.IsNullOrEmpty(machineIdCompanyNameTextBox.Text))
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void priceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void machineIdCompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }
    }
}
