using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
    public sealed class Sticker : Product
    {
        public string Width { get; set; }
        public bool isBackgroundTransparent { get; set; }
        public Sticker(int id, string name, int qty, string description, decimal price, string width, bool isBackgroundTransparent) : base(id, name, qty, description, price)
        {
            this.Width = width;
            this.isBackgroundTransparent = isBackgroundTransparent;
        }
        public override string ToString() =>
            base.ToString() +
            $"Width: {Width}\n" +
            $"Transparency: {(isBackgroundTransparent ? "Yes" : "No")}";
        public override decimal GetSalePrice()
        {
            return Price * (1 - .10m);
        }
    }
}
