using HRLibrary;

namespace Block1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Build an object of the Person class and output to the console
            //Added areference using the Intellisense Quick Actions
            //Access the intellisense quick actions (light bulbs and screwdrivers) using CTRL +.
            //Person p1 = new Person("Cushman", "Armitage", new DateTime(1925, 1, 1));
            //Console.WriteLine("Create and output a Person object:\n " + p1);

            Console.WriteLine("Hourly Employee: ");
            HourlyEmployee he1 = new("Pam","Beesly",new DateTime(1979, 3, 25),111,"Receptionist",
                new DateTime(2005, 3, 24),false,40,21.50m);

            Console.WriteLine(he1);

            Console.WriteLine("\n\nSalaried Employee: ");
            SalariedEmployee se1 = new("Stanley", "Hudson", new DateTime(1958, 2, 19), 222, "Sales Representative", new DateTime(1995, 6, 12), true, 52000);

            Console.WriteLine(se1);

            Manager m1 = new("Michael", "Scott", new DateTime(1964, 3, 15), 333, "Regional Manager",
                new DateTime(2005, 3, 24), true, 79900, 25000);

            Console.WriteLine("\n\nManager:\n" + m1);
        }
    }
}