using System.ComponentModel;

namespace sbInventory.Models
{
    public class Product : INotifyPropertyChanged
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; private set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private int _inStock;
        public int InStock
        {
            get { return _inStock; }
            set
            {
                if (_inStock != value)
                {
                    _inStock = value;
                    OnPropertyChanged(nameof(InStock));
                }
            }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        private int _min;
        public int Min
        {
            get { return _min; }
            set
            {
                if (_min != value)
                {
                    _min = value;
                    OnPropertyChanged(nameof(Min));
                }
            }
        }

        private int _max;
        public int Max
        {
            get { return _max; }
            set
            {
                if (_max != value)
                {
                    _max = value;
                    OnPropertyChanged(nameof(Max));
                }
            }
        }

        public static int id = 1;

        public Product(string name, int inStock, decimal price, int min, int max)
        {
            ProductID = id++;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partId)
        {
            Part? associatedPart = LookupAssociatedPart(partId);

            if (associatedPart != null)
            {
                AssociatedParts.Remove(associatedPart);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part? LookupAssociatedPart(int partId)
        {
            Part? associatedPart = AssociatedParts.SingleOrDefault(p => p.PartID == partId);
            return associatedPart;
        }
    }
}
