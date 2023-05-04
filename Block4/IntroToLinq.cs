using HRLibrary;

namespace Block4
{
    internal class IntroToLinq
    {
        static void Main(string[] args)
        {
            #region Hourly Employee Objects
            HourlyEmployee he1 = new("Tony", "Stark", new DateTime(1970, 5, 29), 1000, "CEO of Stark Industries", new DateTime(1991, 1, 1), true, 35, 50.25m);

            HourlyEmployee he2 = new("Walter", "White", new DateTime(1958, 9, 7), 2000, "High School Chemistry Teacher", new DateTime(2008, 1, 1), false, 25, 20.18m);

            HourlyEmployee he3 = new("Arthur", "Dent", new DateTime(1966, 3, 11), 4242, "Traveler", new DateTime(1979, 10, 12), true, 20, 10.17m);

            HourlyEmployee he4 = new("James", "Bond", new DateTime(1920, 11, 11), 1007, "MI6 Agent", new DateTime(1953, 11, 17), false, 40, 150.07m);

            HourlyEmployee he5 = new("Harvey", "Dent", new DateTime(1978, 3, 30), 3000, "District Attorney", new DateTime(2008, 1, 1), true, 80, 18.25m);
            #endregion

            //LINQ - Language Integrated Query
            //3.5 gave us a lot of stuff
            //Inferred Data types - use of var keyword. The compiler will infer the datatype we need based on context.
            //Object initialization syntax - datatype name = new() { prop - value}
            //prop + tab -> auto props { get; set; }
            //Anonymous types -> new { otfProp = value,...}
            //=> (lambda) create off the fly otf parameters for an expression, or shortcut simple methods.
            //Extension Methods: Adding new behavior to existing classes without needing
            //to modify the original class file.

            //LINQ to Object
            List<HourlyEmployee> hourlyEmployees = new() { he3, he5, he1, he2, he4 }; //when we have angle brackets it means "of the type"
            //it is similar to object initialization syntax because you make use of brackets to initialize an object
            //Evaluate 2 conditions: HourlyWage and DateOfBirth
            //Anyone before 1960 --cant cook-- and who makes less than 25 an hour.

            Console.WriteLine("Nested IF");
            foreach (HourlyEmployee e in hourlyEmployees)
            {
                if (e.DOB.Year < 1960)
                {
                    if (e.HourlyWage < 25)
                    {
                        Console.WriteLine($"{e.GetFullName()}\tWage: {e.HourlyWage:c}\t" +
                            $"DOB: {e.DOB:d}");
                    }
                }
            }
            Console.WriteLine("IF with multiple conditions:");
            foreach (HourlyEmployee e in hourlyEmployees)
            {
                if (e.DOB.Year < 1960 && e.HourlyWage < 25)
                {
                    Console.WriteLine($"{e.GetFullName()}\tWage: {e.HourlyWage:c}\t" +
                        $"DOB: {e.DOB:d}");
                }
            }

            //Method Syntax
            Console.WriteLine("\nSame Query using Linq - Method Syntax");
            //where will return a collection//resolves to
            var emps = hourlyEmployees.Where(e => e.DOB.Year < 1960 && e.HourlyWage < 25).ToList();//need a foreach because it's a list
            foreach (var e in emps)
            {
                Console.WriteLine($"{e.GetFullName()}\tWage: {e.HourlyWage:c}\t" +
                         $"DOB: {e.DOB:d}");
            }
            //same results using Linq Keyword/Query syntax
            Console.WriteLine("\nSame Query using Linq - Keyword Syntax");
            var empsKW = (from e in hourlyEmployees
                         where e.HourlyWage < 25 && e.DOB.Year < 1960
                         select e).ToList();
            foreach (var e in empsKW)
            {
                Console.WriteLine($"{e.GetFullName()}\tWage: {e.HourlyWage:c}\t" +
                        $"DOB: {e.DOB:d}");
            }

            //Return an anonymous object//data type is 'a'
            var anon = new { Name = "This is a name", NumberOfFins = 13, IsBlue = false };
            Console.WriteLine(anon.NumberOfFins);

            var agents = from e in hourlyEmployees
                         where e.JobTitle == "MI6 Agent"
                         select new
                         {
                             FullName = e.GetFullName(),
                             e.HourlyWage,
                             e.DOB//Formatting is NOT allowed in the query
                         };
            Console.WriteLine("Returning anonymous type instead of whole object");
            foreach (var e in agents)
            {
                Console.WriteLine($"{e.FullName}\tWage: {e.HourlyWage:c}\t" +
                        $"DOB: {e.DOB:d}");
            }

            //method syntax for an anonymous object (Recommend keyword syntax instead)
            var agentsM = hourlyEmployees.Where(e => e.JobTitle == "MI6 Agent").Select(e => new { FullName = e.GetFullName(), e.HourlyWage, DateOfBirth = e.DOB }).ToList();

            Console.WriteLine("\nLast Names are the Same - Method Syntax");
            foreach(var e in hourlyEmployees.Where(h => h.LastName.ToLower()== "dent"))
            {
                Console.WriteLine(e.GetFullName());
            }
            //Write a query that returns a single value (should be unique)
            //var, or a strongly typed variable

            //.Single() signifies a return of 1 object. Otherwise, the default return of a linq statement is some kind of collection.
            //HourlyEmployee single = hourlyEmployees.Where(e => e.ID == 4242).Single();
            HourlyEmployee single = hourlyEmployees.Single(e => e.ID == 4242)/*.Single()*/;//single also operates as a where
            Console.WriteLine("\nReturning a single Employee");
            Console.WriteLine(single);
            //if there is a chance that there is more than one result, DON'T use single.
            //If there is a chance that there is no matching result, DON'T use single.
            HourlyEmployee? singleNull = hourlyEmployees.SingleOrDefault(e => e.ID == 13);
            Console.WriteLine("\nReturning a null employee");
            Console.WriteLine(singleNull);
            if (singleNull == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine(singleNull);
            }
            //...OrDefault gives us the ability to return a null object
            //.First() / FirstOrDefault() will return the FIRST instance of an object that matches the condition.
            HourlyEmployee? first = hourlyEmployees.FirstOrDefault(e => e.LastName == "Dent");
            Console.WriteLine("Using FirstOrDefault(): " + first);

            //.Single() if there is ONE and ONLY ONE result.
            //.SingleOrDefault() if there is either ONE or NO result.
            //.First() if there is ONE or MORE results
            //.FirstOrDefault() if there is ANY NUMBER of results, including NONE

        }//end Main()
    }//end class
}//end namespace
