using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class LinqContinued
    {
        static void Main(string[] args)
        {

            #region Products
            Product p1 = new Product(1, "Chef Cart", "Kitchen", 5, 37.99m, "In Stock", "Chefs Friend", "Germany");
            Product p2 = new Product(2, "Craft Maple Cheddar", "Dairy", 35, 4.99m, "In Stock", "Blue Dairy", "Switzerland");
            Product p3 = new Product(3, "Cotton Candy Milk", "Dairy", 10, 6.99m, "Discontinued", "Shatto", "United States");
            Product p4 = new Product(4, "Organic Apples", "Produce", 60, 0.99m, "In Stock", "Macks Apples", "Germany");
            Product p5 = new Product(5, "Ground Bison", "Meat", 0, 10.99m, "Out of Stock", "Bills Bisons", "United States");
            List<Product> products = new List<Product>() { p1, p2, p3, p4, p5 };
            #endregion

            //Return all products with a price between $10 and $40
            //Method Syntax:
            var prods10to40 = products.Where(p => p.Price >= 10 && p.Price <= 40);
            Console.WriteLine("Products $10 to $40");
            foreach(Product item in prods10to40)
            {
                Console.WriteLine(item);
            }
            //Keyword Syntax:
            Console.WriteLine("Products $10 to $40 with Keyword Syntax (KW)");
            var prods10to40KW = from p in products
                                where p.Price >= 10 && p.Price <= 40
                                select p;
            foreach (var item in prods10to40KW)
            {
                Console.WriteLine(item);
            }

            //foreach(var item in products) Console.WriteLine(item);
            //products.Sort();//Sorting a collection of complex objects results in an error.
            //foreach(var item in products) Console.WriteLine(item);
            var sortedProds = products.OrderBy(p => p.Price);
            foreach (var item in sortedProds) Console.WriteLine(item);

            //return all products in the category Dairy, ordered alphabetically by product name.
            Console.WriteLine("\nDairy, alphabetical using Method Syntax");
            var dairyProducts = products.Where(p => p.Category.Contains("airy")).OrderBy(x=> x.Name);
            foreach (var item in dairyProducts)
            {
                Console.WriteLine(item);
            }

            var dairyProductsKW = from p in products//foreach also starts with an f
                                  where p.Category.ToLower().Contains("Dairy")
                                  orderby p.Name //descending
                                  select p;
            foreach (var item in dairyProductsKW) Console.WriteLine(item);

            //Using method syntax, how could I do the same query, but only return the name, category, and price, instead of the entire object?
            //It would be an anonymous object in the select method (.Select()

            //We'll do it using Keyword, because it's easier to read.
            Console.WriteLine("Doing the same query, but only returning a limited number of props\n");
            var dairyAnon = from p in products
                            where p.Category.ToLower().Contains("dairy")
                            orderby p.Name
                            select new
                            {
                                p.Name,
                                p.Category,
                                p.Price
                            };
            foreach (var item in dairyAnon)
            {
                Console.WriteLine(item);//probably format this as a string.
            }
            //List the top 2 most expensive products baybey.
            var expensive = products.OrderByDescending(x => x.Price).Take(2);
            foreach (var item in expensive) Console.WriteLine(item);

            var expensiveKW = (from p in products orderby p.Price descending select p).Take(2);
            foreach (var item in expensiveKW) Console.WriteLine(item);
        }
    }
}
