using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3Labs
{
    internal class _10DigitFib
    {
        static void Main(string[] args)
        {
            long n1 = 1, n2 = 0, n3 = 0;
            Stack<long> fibNumber = new();

            while (n3 <= 1000000000)
            {
                Console.WriteLine(n3);
                fibNumber.Push(n3);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine(fibNumber.Count()+1);
        }
    }
}
