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

            Part? part = Inventory.LookupPart(int.Parse(textBox1.Text));

            foreach(DataGridViewRow row in dataGridView1.Rows)
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

            Product? product = Inventory.LookupProduct(int.Parse(textBox2.Text));

            foreach(DataGridViewRow row in dataGridView2.Rows)
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
            ModifyPartScreen modifyPartScreen = new ModifyPartScreen(part);
            modifyPartScreen.ShowDialog();
        }

        private void mainDeletePartBtn_Click(object sender, EventArgs e)
        {
            Part? part = dataGridView1.CurrentRow.DataBoundItem as Part;
            Inventory.DeletePart(part);
        }

        private void mainAddProdBtn_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.ShowDialog();
            dataGridView2.DataSource = Inventory.Products;
        }

        private void mainModifyProdBtn_Click(object sender, EventArgs e)
        {
            ModifyProductScreen modifyProductScreen = new ModifyProductScreen();
            modifyProductScreen.ShowDialog();
            dataGridView2.DataSource = Inventory.Products;
        }

        private void mainDeleteProdBtn_Click(object sender, EventArgs e)
        {
            Product? product = dataGridView2.CurrentRow.DataBoundItem as Product;
            Inventory.RemoveProduct(product.ProductID);
            dataGridView2.DataSource = Inventory.Products;
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
