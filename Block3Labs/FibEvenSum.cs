namespace Block3Labs
{
    internal class FibEvenSum
    {
        static void Main(string[] args)
        {
            long n1 = 1, n2 = 0, n3 = 0, sum = 0;
            for (n3 = 0; n3 <= 4000000;)
            {
                Console.WriteLine(n3);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                if (n3 % 2 == 0)
                {
                    sum += n3;
                }
            }
            Console.WriteLine($"\n All even numbers add up to: {sum}");
        }
    }
}