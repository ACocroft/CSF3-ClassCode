using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class Exceptions
    {
        //Exception: Anything that interrupts the normal execution of an assembly.
        //Assembly is called a project in VS

        //Exception Handling: Internally in code we have Try/Catch/Finally structure

        //Try - allows us to "test" code to see if it throws and exception
        //"Potentially" dangerous, because the outcome of the code is unknown

        //Catch - "Catches" the exception and runs alternative code instead.

        //Finally - Always executes and can be used to return resources to the runtime for use. (data readers, sql connections, file streams, documents, etc) (optional)

        //Object
        //Exception
        //etc
        static void Main(string[] args)
        {
            try
            {
                int y = 0;
                //int x = 1 / y;//System.DivideByZero Exception
                //Exception ex = new Exception("This is a custom error message.)'
                Exception ex = new Exception("This is a custom error message");
                throw new InsufficientFundsException();

                ex.Data.Add(1, "This is some analytical data. Wowr.");
                throw ex;
            }
            catch(InsufficientFundsException ife)
            {
                Console.WriteLine(ife);
                //goto thisIsTheEnd;
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);
            }
            catch (NullReferenceException nre)
            {
                //will run if you try to access the details of an object that doesn't exist.
                Console.WriteLine(nre.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine(ioore.Message);
            }
            catch (Exception e)
            {
                //Source - Project/Assembly that threw the exception
                Console.WriteLine($"Source: " + e.Source);

                //Message - Default messaging defining the datatype of the exception thrown.
                Console.WriteLine($"Message: " + e.Message);

                //StackTrace - Project.ClassName.Method AND the physical file location including the line number that threw the exception.
                Console.WriteLine($"StackTrace: " + e.StackTrace);

                //Data is developer-defined in a key/value pair.
                Console.WriteLine($"Data: {e.Data[1]}");

                //ToString() - combination of the Source, Messge, and Stack Trace properties.
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("This block will run no matter what, probably.");
                /*
                 * used to return/release any resources that may have been trapped in
                 * the try block when the operation failed
                 */
            }
            Console.WriteLine("This is the End of the File");
            //thisIsTheEnd: Console.WriteLine("This is the end");
            Console.Clear();
            Console.WriteLine("Pick a number ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Selection.");
            }
            //int choice = 0;
            //try
            //{
            //    choice = int.Parse(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("That wasn't a number");
            //} use this for weapons and races in the dungeon app!
            Console.WriteLine(choice + 42);
        }


    }//end class
    
    public class InsufficientFundsException : ArithmeticException 
    {
        //simulates a full prop, readonly (get { return ""; } )
        //public override string Message => "Your request for funds exceeds your account balance.";
        public InsufficientFundsException(string message) : base(message)
        {
            
        }
        public InsufficientFundsException() : base("Your request for funds exceeds your account balance")
        {

        }
    }
}
