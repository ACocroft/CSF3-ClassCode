namespace InventoryInterfaces
{
    public interface IInventoriable
    {
        decimal GetSalePrice();

        int Quantity { get; }
    }
}