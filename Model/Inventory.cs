using System.ComponentModel;

namespace sbInventory.Model
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int productId)
        {
            Product? product = LookupProduct(productId);

            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Product? LookupProduct(int productId)
        {
            Product? product = Products.SingleOrDefault(p => p.ProductID == productId);
            return product;
        }

        public static void UpdateProduct(int productId, Product product)
        {
            Product? productToUpdate = LookupProduct(productId);

            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.InStock = product.InStock;
                productToUpdate.Price = product.Price;
                productToUpdate.Min = product.Min;
                productToUpdate.Max = product.Max;
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(Part part)
        {
            if (AllParts.Contains(part))
            {
                AllParts.Remove(part);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Part? LookupPart(int partId)
        {
            return AllParts.SingleOrDefault(p => p.PartID == partId);
        }

        public static void UpdatePart(int partId, Part part)
        {
            Part? partToUpdate = LookupPart(partId);

            if (partToUpdate != null)
            {
                partToUpdate.Name = part.Name;
                partToUpdate.InStock= part.InStock;
                partToUpdate.Price = part.Price;
                partToUpdate.Min = part.Min;
                partToUpdate.Max = part.Max;
            }        
        }
    }
}
