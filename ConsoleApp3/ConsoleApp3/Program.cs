using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b");
            b
                = Convert.ToInt32(Console.ReadLine());
            if (a %2 == 0)
            {
                Console.WriteLine("a is even no.");

            }
            else
            {
                Console.WriteLine("a is odd no.");
            }
            if (b %2 == 0)
            {
                Console.WriteLine("b is even no.");

            }
            else
            {
                Console.WriteLine("b is odd no.");
            }
        }
    }
}
