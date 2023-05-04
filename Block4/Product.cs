using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class Product
    {
        //Fields - none

        //Properties - autoprops only
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCountry { get; set; }

        //ctors - fqctor
        public Product(int id, string name, string category, int qty, decimal price, string status, string supplierName, string supplierCountry)
        {
            ID = id;
            Name = name;
            Category = category;
            Qty = qty;
            Price = price;
            Status = status;
            SupplierName = supplierName;
            SupplierCountry = supplierCountry;

        }

        //override the ToString();
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                   $"Name: {Name}\n" +
                   $"Price: {Price}\n" +
                   $"Qty: {Qty}\n" +
                   $"Category: {Category}\n" +
                   $"Status: {Status}\n" +
                   $"SupplierName: {SupplierName} from {SupplierCountry}\n\n";
        }
    }
}
