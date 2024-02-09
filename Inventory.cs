using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbInventory
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void AddProduct(Product product) 
        {

        }

        public static bool RemoveProduct(int i)
        {
            return false;
        }

        public static Product LookupProduct(int i)
        {
            return Products[i];
        }

        public static void UpdateProduct(int i, Product product)
        {

        }

        public static void AddPart(Part part)
        {

        }

        public static bool DeletePart(Part part)
        {
            return false;
        }

        public static Part LookupPart(int i)
        {
            return AllParts[i];
        }

        public static void UpdatePart(int i, Part part)
        {

        }
    }
}
