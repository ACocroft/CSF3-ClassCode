using InventoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public sealed class Book : Product, IInventoriable
    {
        public string Author { get; set; }
        public int NbrPages { get; set; }
        public string Genre { get; set; }

        public Book(int id, string name, int qty, string description, decimal price, string author, int nbrPages, string genre) : base(id, name, qty, description, price)
        {
            Author = author;
            Genre = genre;
            NbrPages = nbrPages;
        }
        public override decimal GetSalePrice()
        {
            return Price * (1 - .15m);
        }

    }
}
