namespace sbInventory.Models
{
    public class In_House : Part
    {
        public int MachineID { get; set; }

        public In_House(string name, int inStock, decimal price, int min, int max, int machineId) :
            base(name, inStock, price, min, max)
        {
            MachineID = machineId;
        }
    }
}
