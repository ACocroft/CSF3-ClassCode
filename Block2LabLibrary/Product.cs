using InventoryInterfaces;

namespace InventoryLibrary
{
    public abstract class Product : IInventoriable
    {
        private readonly int _id;

        public int ID { get { return _id; } }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int qty, string description, decimal price)

        {
            _id = id;
            Name = name;
            Qty = qty;
            Description = description;
            Price = price;
        }
        public override string ToString() => 
            $"Name: {Name} \n" +
            $"ID: {ID} \n" +
            $"QTY: {Qty} \n" +
            $"Description: {Description} \n" +
            $"Price: {Price:c}";
        public virtual decimal SalePrice()
        {
            return Price;
        }

        public abstract decimal GetSalePrice();

    }
}