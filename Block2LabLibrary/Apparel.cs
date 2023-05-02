using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public class Apparel : Product
    {
        private string _type;
        public string Size { get; set; }
        public string Type 
        {
            get { return _type; }
            set { _type = value; }
        }

        public Apparel(int id, string name, int qty, string description, decimal price, string size, string type) : base(id, name, qty, description, price)
        {
            Size = size;
            Type = type;
        }
        public override string ToString() =>
            base.ToString() +
            $"Size: {Size}\n" +
            $"Type: {Type}";
        public override decimal GetSalePrice()
        {
            return Price * (1 - .5m);
        }
    }
}
