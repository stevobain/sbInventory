using sbInventory.Model;

namespace sbInventory
{
    public partial class AddPartScreen : Form
    {

        public AddPartScreen()
        {
            InitializeComponent();
            inHouseRadioButton.Checked = true;
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

            if (inHouseRadioButton.Checked) 
            {
                if (!int.TryParse(machineIdCompanyNameTextBox.Text, out int machineId) || string.IsNullOrEmpty(machineIdCompanyNameTextBox.Text))
                {
                    MessageBox.Show("Please enter a number for Machine ID.", "Invalid or empty Machine ID", MessageBoxButtons.OK);
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
                if (string.IsNullOrEmpty(companyName))
                {
                    MessageBox.Show("Please enter a Company Name.", "Empty Company Name", MessageBoxButtons.OK);
                    return;
                }

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
    }
}
