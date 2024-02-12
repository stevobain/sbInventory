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
            
            partToUpdate.Name = nameTextBox.Text;
            partToUpdate.InStock = int.Parse(inventoryTextBox.Text);
            partToUpdate.Price = decimal.Parse(priceCostTextBox.Text);
            partToUpdate.Min = int.Parse(minTextBox.Text);
            partToUpdate.Max = int.Parse(maxTextBox.Text);

            if (label8.Text == "Machine ID")
            {
                In_House inHousePartToUpdate = (In_House)partToUpdate;
                inHousePartToUpdate.MachineID = int.Parse(machineIdCompanyNameTextBox.Text);
                Inventory.UpdatePart(id, inHousePartToUpdate);
            }
            else if (label8.Text == "Company Name")
            {
                Outsourced outsourcedPartToUpdate = (Outsourced)partToUpdate;
                outsourcedPartToUpdate.CompanyName = machineIdCompanyNameTextBox.Text;
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
