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
            if (label8.Text == "Machine ID") 
            {
                In_House in_House = new In_House(
                    nameTextBox.Text,
                    int.Parse(inventoryTextBox.Text),
                    decimal.Parse(priceCostTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    int.Parse(machineIdCompanyNameTextBox.Text)
                    );

                Inventory.AddPart(in_House);
            }
            else if (label8.Text == "Company Name")
            {
                Outsourced outsourced = new Outsourced(
                    nameTextBox.Text,
                    int.Parse(inventoryTextBox.Text),
                    decimal.Parse(priceCostTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    machineIdCompanyNameTextBox.Text
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
