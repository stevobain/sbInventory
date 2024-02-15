using sbInventory.Models;
using System.ComponentModel;

namespace sbInventory.Forms
{
    public partial class AddProductForm : Form
    {
        public BindingList<Part> PartsToAssociate = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = PartsToAssociate;

            saveButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Part? part;

            if (!int.TryParse(searchTextBox.Text, out int lookupPartId))
            {
                part = Inventory.AllParts.FirstOrDefault(p => p.Name.ToLower() == searchTextBox.Text.ToLower());
            }
            else
            {
                part = Inventory.LookupPart(lookupPartId);
            }

            if (part == null)
            {
                MessageBox.Show("Please enter the ID or Name of the Part you're searching for.", "No Part with that ID or Name", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var boundItem = (Part)row.DataBoundItem;
                if (boundItem == part)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (!int.TryParse(inventoryTextBox.Text, out int inStock))
            {
                MessageBox.Show("Please enter a number for Inventory.", "Invalid Inventory", MessageBoxButtons.OK);
                return;
            }

            if (!decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Please enter a number for Price.", "Invalid Price", MessageBoxButtons.OK);
                return;
            }
            else
            {
                price = decimal.Parse(decimal.Parse(priceTextBox.Text).ToString("F"));
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

            Product product = new Product(
                name,
                inStock,
                price,
                min,
                max
                );

            foreach (Part part in PartsToAssociate)
            {
                product.AddAssociatedPart(part);
            }

            Inventory.AddProduct(product);

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Part? partToAssociate = dataGridView1.CurrentRow.DataBoundItem as Part;

                if (!PartsToAssociate.Contains(partToAssociate))
                {
                    PartsToAssociate.Add(partToAssociate);
                }
                else
                {
                    MessageBox.Show("The part you selected is already assoicated with this Product.", "Part already associated", MessageBoxButtons.OK);
                }

                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select the Part you wish to associate with the Product.", "No Part selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                Part? partToDisassociate = dataGridView2.CurrentRow.DataBoundItem as Part;

                PartsToAssociate.Remove(partToDisassociate);

                dataGridView2.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select the Part you wish to disassociate with the Product.", "No Part selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void ValidateTextBoxes()
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(inventoryTextBox.Text) && !string.IsNullOrEmpty(priceTextBox.Text) &&
                !string.IsNullOrEmpty(maxTextBox.Text) && !string.IsNullOrEmpty(minTextBox.Text))
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

        private void priceTextBox_TextChanged(object sender, EventArgs e)
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

        private void AddProductScreen_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
    }
}
