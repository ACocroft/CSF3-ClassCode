using HRLibrary;

namespace Block3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hourly Employee Objects
            HourlyEmployee he1 = new("Tonard", "Starnk", new DateTime(1970, 5, 29), 1000, "CEO of Starnk Industries", new DateTime(1991, 1, 1), true, 35, 50.25m);

            HourlyEmployee he2 = new("Waltuh", "White", new DateTime(1958, 9, 7), 2000, "High School Chemistry Teacher", new DateTime(2008, 1, 1), false, 25, 20.18m);

            HourlyEmployee he3 = new("Oarthur", "Dent", new DateTime(1966, 3, 11), 4242, "Traveler", new DateTime(1979, 10, 12), true, 20, 10.17m);

            HourlyEmployee he4 = new("Names", "Nond", new DateTime(1920,11,11), 1007,"MI6 Shpee", new DateTime(1953, 11, 17),false,40,150.07m);
            #endregion

            //Stack / Queue - Non-generic
            //Stack<T> / Queue<T> - Generic
            //Stack is LIFO (Last In First Out)
            //Undo functionality
            //back button in a browser
            //To Add an object to the stack : we use the dot push method .Push(obj)
            //To remove an object from the stack : we use the dot pop method .Pop() (also returns the object)
            //To view the next object, but not remove it : use .Peek()

            //Queue is the opposite, First In First Out (FIFO)
            //Anything where waiting in a line is the goal
            //Add - .Enqueue(obj)
            //Remove - .Dequeue() also returns the object
            //.Peek() - view the object at the front of the queue

            //Because the order is important, there is NO collection initialization syntax.
            Stack<HourlyEmployee> hourlies = new();
            hourlies.Push(he4);//4
            hourlies.Push(he1);//3
            hourlies.Push(he3);//2
            hourlies.Push(he2);//1 This is counted using LIFO!
            //dotnet restore
            //NuGet Package Manager Console in tools
            Console.WriteLine("Foreach");
            foreach (Employee item in hourlies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPeek()");
            Console.WriteLine(hourlies.Peek());//he2. unindex collection, we can't just call to it
            Console.WriteLine("\nPop()");
            Console.WriteLine(hourlies.Pop());//we see he2 because he is stacked first on top
            Console.WriteLine("\nPeek");
            Console.WriteLine(hourlies.Peek());//we see he3 because he was before the employee that was popped
            //clear()
            hourlies.Clear();//reduces count to 0, empties collection, returning resources to the Runtime
            Console.WriteLine(hourlies.Count);

            //Queue<T> (qwayway)
            Queue<HourlyEmployee> employees = new();//no initilization syntax
            employees.Enqueue(he4);
            employees.Enqueue(he1);
            employees.Enqueue(he3);
            employees.Enqueue(he2);
            Console.WriteLine("\n\nQUEUE\n\n");
            foreach (Employee item in employees)//Queue is FIFO
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(employees.Peek());//he4
            Console.WriteLine(employees.Dequeue());//he4
            Console.WriteLine(employees.Peek());//he1
            employees.Clear();

            //Example of the TRICKERY with stack and queue interview questions
            int five = 1, four = 2, three = 4, two = 3, one = 5;
            Queue<int> q = new();
            q.Enqueue(one);
            q.Enqueue(two);
            q.Enqueue(five);
            q.Enqueue(three);
            q.Enqueue(four);

            int result = q.Dequeue();//what will we see? ITEM : one | Value : 5
            Console.WriteLine(result);
            //the trick is to know which value they want : Variable name, or actual value.

            //create a List<T>/Typed List with all of the objects you want.
            //Select one item at random
            //Enqueue or Push that item to the sequential collection AND remove that item from the List with the remove method .Remove(obj)
            q.Clear();
        }
    }
}