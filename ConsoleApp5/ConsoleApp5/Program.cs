using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  for (int i=0; i < 1; i++)
              {
             Console.WriteLine("*");
            }
         for(int i = 1; i < 2; i++)
         {
             Console.WriteLine("* *");
         }
         for (int i = 2; i < 3; i++)
         {
             Console.WriteLine("* * *");
         }
         for (int i = 3; i < 4; i++)
         {
             Console.WriteLine("* * * *");

         }
         for (int i = 4; i < 5; i++)
         {
             Console.WriteLine("* * * * *");
         }
     }*/
            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
