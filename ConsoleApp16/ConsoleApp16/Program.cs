using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
             // for (int i = 0; i <= num; i--)
              //{
              //    fact = fact * i;
              //}
            
              Console.WriteLine("Please enter Num:");
            int Num = Convert.ToInt32(Console.ReadLine());
            factorial(5);

            
                                                           //Console.WriteLine("Factorial of " + num + " is :" + fact);

            static void factorial(int num)
            {
                int fact = 1;
                while (num > 0)
                {                                          //Process
                    fact = fact * num;              // 5*1 =5 then 5 will decrese to 4 then it will 5*4=20
                                                      // like this 20*3=60
                                                     //then 60*2=120
                                                    //then 120*1=120 that will our ans.
                    num--;
                }
                Console.WriteLine("Factorial of " + num + " is :" + fact);
            }

        }
    }
}
