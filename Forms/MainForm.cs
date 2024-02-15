using sbInventory.Models;

namespace sbInventory.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = Inventory.Products;
        }

        private void mainSearchPartBtn_Click(object sender, EventArgs e)
        {
            Part? part;

            if (!int.TryParse(textBox1.Text, out int lookupPartId))
            {
                part = Inventory.AllParts.FirstOrDefault(p => p.Name.ToLower() == textBox1.Text.ToLower());
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

        private void mainSearchProductBtn_Click(object sender, EventArgs e)
        {
            Product? product;

            if (!int.TryParse(textBox2.Text, out int lookupProductId))
            {
                product = Inventory.Products.FirstOrDefault(p => p.Name == textBox2.Text);
            }
            else
            {
                product = Inventory.LookupProduct(lookupProductId);
            }

            if (product == null)
            {
                MessageBox.Show("Please enter the ID or Name of the Product you're searching for.", "No Product with that ID or Name", MessageBoxButtons.OK);
                return;
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                var boundItem = (Product)row.DataBoundItem;
                if (boundItem == product)
                {
                    row.Selected = true;
                    dataGridView2.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void mainAddPartBtn_Click(object sender, EventArgs e)
        {
            AddPartForm addPartScreen = new AddPartForm();
            addPartScreen.ShowDialog();

            dataGridView1.ClearSelection();
        }

        private void mainModifyPartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Part? part = dataGridView1.CurrentRow.DataBoundItem as Part;

                ModifyPartForm modifyPartScreen = new ModifyPartForm(part);
                modifyPartScreen.ShowDialog();

                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select the Part you wish to modify.", "No Part selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void mainDeletePartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Part Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Part? part = dataGridView1.CurrentRow.DataBoundItem as Part;

                    Inventory.DeletePart(part);
                }                

                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select the Part you wish to delete.", "No Part selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void mainAddProdBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductScreen = new AddProductForm();
            addProductScreen.ShowDialog();

            dataGridView2.ClearSelection();
        }

        private void mainModifyProdBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                Product? product = dataGridView2.CurrentRow.DataBoundItem as Product;

                ModifyProductForm modifyProductScreen = new ModifyProductForm(product);
                modifyProductScreen.ShowDialog();

                dataGridView2.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select the Product you wish to modify.", "No Product selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void mainDeleteProdBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                Product? product = dataGridView2.CurrentRow.DataBoundItem as Product;

                if (product.AssociatedParts.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Part Deletion", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Inventory.RemoveProduct(product.ProductID);
                    }
                }
                else
                {
                    MessageBox.Show("You can not remove Products that have associated parts. Remove all associated parts and try again.", "Product has associated parts", MessageBoxButtons.OK);
                }

                dataGridView2.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select the Product you wish to delete.", "No Product selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainScreen_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }
    }
}
