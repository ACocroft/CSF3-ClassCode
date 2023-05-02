using InventoryLibrary;

namespace InventoryLab
{
    internal class StoreInventory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory");
                         //ID   //Title  //Qty //Desc. //Price //Author  //PageNbr & Genre
            Book b1 = new(1111, "book1", 254, "yeah", 4.50m, "me", 1000, "Tragedy");
            Console.WriteLine(b1);
            Book b2 = new(2222, "book2", 348, "uh huh", 7.80m, "me again", 4, "Political Fiction");
            Console.WriteLine(b2);
                            //ID  //Name      //QTY //Type//price //size//Desc
            Apparel a1 = new(1338, "Sombrero", 25, "Hat", 4.99m, "large", "Hat");
            Console.WriteLine(a1);
            Apparel a2 = new(2196, "Blue Hoodie", 4, "Jacket", 29.50m, "Medium", "Blue");
            Console.WriteLine(a2);
            //ID,Name,QTY,Desc,Price,Width,isTransparent
            Sticker s1 = new(4040, "Sticker that says sticker", 0, "It says sticker", 79.00m, "4x30", false);
            Console.WriteLine(s1);
            Sticker s2 = new(0000, "Sticker that says 'Not a sticker'", 999999, "It says not a sticker", 0.00m, "4x31", true);
            Console.WriteLine(s2);
        }
    }
}