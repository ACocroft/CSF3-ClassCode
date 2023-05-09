using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3Labs
{
    internal class LongestCollatz
    {
        static void Main(string[] args)
        {
            int longestNumber = 0;
            int longestSequence = 0;

            for (int i = 1; i < 1000; i++)
            {
                int totalSteps = 0;
                int val = i;

                while (val > 1)
                {
                    totalSteps++;
                    if (val % 2 == 0)
                    {
                        val /= 2;
                    }
                    else
                    {
                        val = (val * 3) + 1;
                    }
                }

                if (totalSteps > longestSequence)
                {
                    longestSequence = totalSteps;
                    longestNumber = i;
                }
            }

            Console.WriteLine("The number under one thousand that produces the longest chain is: " + longestNumber);
        }
    }
}

