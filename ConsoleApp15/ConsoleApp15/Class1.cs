using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num = 5, fact = 1;
            // Console.WriteLine("Please enter Num:");
            // int Num = Convert.ToInt32(Console.ReadLine());
            // void factorial(int num)
            // {

            // }
            for (int i = 1; i <= num; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + num + " is :" + fact);

        }
    }
}

    