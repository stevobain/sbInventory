namespace sbInventory.Models
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string name, int inStock, decimal price, int min, int max, string companyName) :
            base(name, inStock, price, min, max)
        {
            CompanyName = companyName;
        }
    }
}
