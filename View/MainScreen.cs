using sbInventory.Model;

namespace sbInventory
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void mainSearchPartBtn_Click(object sender, EventArgs e)
        {            
            Inventory.LookupPart(int.Parse(textBox1.Text));
        }

        private void mainSearchProductBtn_Click(object sender, EventArgs e)
        {
            Inventory.LookupProduct(int.Parse(textBox2.Text));
        }

        private void mainAddPartBtn_Click(object sender, EventArgs e)
        {
            AddPartScreen addPartScreen = new AddPartScreen();
            addPartScreen.ShowDialog();
        }

        private void mainModifyPartBtn_Click(object sender, EventArgs e)
        {
            ModifyPartScreen modifyPartScreen = new ModifyPartScreen();
            modifyPartScreen.ShowDialog();
        }

        private void mainDeletePartBtn_Click(object sender, EventArgs e)
        {
            Part part = dataGridView1.CurrentRow.DataBoundItem as Part;
            Inventory.DeletePart(part);
        }

        private void mainAddProdBtn_Click(object sender, EventArgs e)
        {
            AddProductScreen addProductScreen = new AddProductScreen();
            addProductScreen.ShowDialog();
        }

        private void mainModifyProdBtn_Click(object sender, EventArgs e)
        {
            ModifyProductScreen modifyProductScreen = new ModifyProductScreen();
            modifyProductScreen.ShowDialog();
        }

        private void mainDeleteProdBtn_Click(object sender, EventArgs e)
        {
            Product product = dataGridView2.CurrentRow.DataBoundItem as Product;
            Inventory.RemoveProduct(product.ProductID);
        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
