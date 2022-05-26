using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)/// creating for rows (total 5 rows)
            { 
                for (int j = i; j <= 4; j++)     /// for observing  spaces
                {
                 Console.Write(" ");/// this is will execute 4 times
                }
                for(int k = 1; k <= i; k++)    //// for printing *  columwise
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();/// to put in new line

            }
            
           Console.ReadLine();
        }
    }
}
