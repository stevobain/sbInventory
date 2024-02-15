using sbInventory.Models;

namespace sbInventory.Forms
{
    public partial class AddPartForm : Form
    {

        public AddPartForm()
        {
            InitializeComponent();
            inHouseRadioButton.Checked = true;
            saveButton.Enabled = false;
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

            if (inHouseRadioButton.Checked)
            {
                if (!int.TryParse(machineIdCompanyNameTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Please enter a number for Machine ID.", "Invalid Machine ID", MessageBoxButtons.OK);
                    return;
                }

                In_House in_House = new In_House(
                    name,
                    inStock,
                    price,
                    min,
                    max,
                    machineId
                    );

                Inventory.AddPart(in_House);
            }
            else if (outsourcedRadioButton.Checked)
            {
                string companyName = machineIdCompanyNameTextBox.Text;

                Outsourced outsourced = new Outsourced(
                    name,
                    inStock,
                    price,
                    min,
                    max,
                    companyName
                    );

                Inventory.AddPart(outsourced);
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ValidateTextBoxes()
        {
            if(!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(inventoryTextBox.Text) && !string.IsNullOrEmpty(priceCostTextBox.Text) &&
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
