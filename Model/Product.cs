using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbInventory.Model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {

        }

        public bool RemoveAssociatedPart(int i)
        {
            return false;
        }

        public Part LookupAssociatedPart(int i)
        {
            return AssociatedParts[i];
        }
    }
}
