using ABCPayroll;
using HRLibrary;

namespace Block1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Build an object of the Person class and output to the console
            //Added a reference using the Intellisense Quick Actions
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
            Console.WriteLine("\n\n********** Paper Checks **********\n");
            //PayrollManager pm = new PayrollManager();
            PayrollManager.ProcessPaycheck(he1);
            PayrollManager.ProcessPaycheck(se1);
            PayrollManager.ProcessPaycheck(m1);
            Console.WriteLine("\n\n********** Direct Deposit **********\n");
            PayrollManager.DoDirectDeposit(he1);
            PayrollManager.DoDirectDeposit(se1);
            PayrollManager.DoDirectDeposit(m1);

            List<Employee> employees = new() { he1, se1, m1 };
            Console.WriteLine("\n\n***************** Employees ******************\n");
            foreach (Employee e in employees)
            {
                if (e.IsDirectDeposit)//e.IsDirectDeposit == true
                {
                    PayrollManager.DoDirectDeposit(e);
                }
                else
                {
                    PayrollManager.ProcessPaycheck(e);
                }
                Console.WriteLine(" *** ");
            }
            //How many different implementations do we have for the manager object?
            //Manager
            //SalariedEmployee
            //Employee
            //Person
            //Object
            //IPayable
            //IDirectDepositable
            //Polymorphism! (not one of the types)

        }
    }
}