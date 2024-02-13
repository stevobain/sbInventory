using sbInventory.Model;

namespace sbInventory
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = Inventory.Products;
        }

        private void mainSearchPartBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

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
                    break;
                }
            }
        }

        private void mainSearchProductBtn_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();

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
                    break;
                }
            }
        }

        private void mainAddPartBtn_Click(object sender, EventArgs e)
        {
            AddPartScreen addPartScreen = new AddPartScreen();
            addPartScreen.ShowDialog();
        }

        private void mainModifyPartBtn_Click(object sender, EventArgs e)
        {
            Part? part = dataGridView1.CurrentRow.DataBoundItem as Part;

            if (part == null)
            {
                MessageBox.Show("Please select the Part you wish to modify.", "No Part selected", MessageBoxButtons.OK);
                return;
            }

            ModifyPartScreen modifyPartScreen = new ModifyPartScreen(part);
            modifyPartScreen.ShowDialog();
        }

        private void mainDeletePartBtn_Click(object sender, EventArgs e)
        {
            Part? part = dataGridView1.CurrentRow.DataBoundItem as Part;

            if (part == null)
            {
                MessageBox.Show("Please select the Part you wish to delete.", "No Part selected", MessageBoxButtons.OK);
                return;
            }

            Inventory.DeletePart(part);
        }

        private void mainAddProdBtn_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.ShowDialog();            
        }

        private void mainModifyProdBtn_Click(object sender, EventArgs e)
        {
            Product? product = dataGridView2.CurrentRow.DataBoundItem as Product;

            if (product == null)
            {
                MessageBox.Show("Please select the Product you wish to modify.", "No Product selected", MessageBoxButtons.OK);
                return;
            }

            ModifyProductScreen modifyProductScreen = new ModifyProductScreen();
            modifyProductScreen.ShowDialog();
        }

        private void mainDeleteProdBtn_Click(object sender, EventArgs e)
        {
            Product? product = dataGridView2.CurrentRow.DataBoundItem as Product;

            if (product == null)
            {
                MessageBox.Show("Please select the Product you wish to delete.", "No Product selected", MessageBoxButtons.OK);
                return;
            }

            Inventory.RemoveProduct(product.ProductID);
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
