using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)

        {

            int operand;

          
            int a, b ,c;
            Console.Write("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            operand = Convert.ToInt32(Console.ReadLine());
      
            switch (operand)
            {
                case 1:
                    Console.WriteLine("Addition " );
                    c = a + b;
                    Console.WriteLine("Addition of a and b is :" + c);
                    break;
                case 2:
                    Console.WriteLine("Substraction");
                    c = a - b;
                    Console.WriteLine("Substraction of a and b is :" +c);
                    break;
                case 3:
                    Console.WriteLine("Multiplication");
                    c = a * b;
                    Console.WriteLine("Multiplication of a and b is :" + c);
                    break;
                case 4:
                    Console.WriteLine("Division");
                    c = a / b;
                    Console.WriteLine("Division of a and b is :" + c);
                    break;
                default:
                    Console.WriteLine("Please Enter a valid choice");
                    break;

            }
            Console.ReadLine();

        }
    }
}