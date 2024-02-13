using sbInventory.Model;

namespace sbInventory
{
    public partial class ModifyPartScreen : Form
    {
        Part partToUpdate;

        public ModifyPartScreen(Part part)
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

            partToUpdate = part;
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
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a Name.", "Empty Name", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(inventoryTextBox.Text, out int inStock) || string.IsNullOrEmpty(inventoryTextBox.Text))
            {
                MessageBox.Show("Please enter a number for Inventory.", "Invalid or empty Inventory", MessageBoxButtons.OK);
                return;
            }

            if (!decimal.TryParse(priceCostTextBox.Text, out decimal price) || string.IsNullOrEmpty(priceCostTextBox.Text))
            {
                MessageBox.Show("Please enter a number for Price.", "Invalid or empty Price", MessageBoxButtons.OK);
                return;
            }
            else
            {
                price = decimal.Parse(decimal.Parse(priceCostTextBox.Text).ToString("F"));
            }

            if (!int.TryParse(maxTextBox.Text, out int max) || string.IsNullOrEmpty(maxTextBox.Text))
            {
                MessageBox.Show("Please enter a number for Max.", "Invalid or empty Max", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(minTextBox.Text, out int min) || string.IsNullOrEmpty(minTextBox.Text))
            {
                MessageBox.Show("Please enter a number for Min.", "Invalid or empty Min", MessageBoxButtons.OK);
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

            partToUpdate.Name = name;
            partToUpdate.InStock = inStock;
            partToUpdate.Price = price;
            partToUpdate.Min = min;
            partToUpdate.Max = max;

            if (inHouseRadioButton.Checked)
            {
                if (!int.TryParse(machineIdCompanyNameTextBox.Text, out int machineId) || string.IsNullOrEmpty(machineIdCompanyNameTextBox.Text))
                {
                    MessageBox.Show("Please enter a number for Machine ID.", "Invalid or empty Machine ID", MessageBoxButtons.OK);
                    return;
                }

                In_House inHousePartToUpdate = (In_House)partToUpdate;
                inHousePartToUpdate.MachineID = machineId;
                Inventory.UpdatePart(id, inHousePartToUpdate);
            }
            else if (outsourcedRadioButton.Checked)
            {
                string companyName = machineIdCompanyNameTextBox.Text;
                if (string.IsNullOrEmpty(companyName))
                {
                    MessageBox.Show("Please enter a Company Name.", "Empty Company Name", MessageBoxButtons.OK);
                    return;
                }

                Outsourced outsourcedPartToUpdate = (Outsourced)partToUpdate;
                outsourcedPartToUpdate.CompanyName = companyName;
                Inventory.UpdatePart(id, outsourcedPartToUpdate);
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
