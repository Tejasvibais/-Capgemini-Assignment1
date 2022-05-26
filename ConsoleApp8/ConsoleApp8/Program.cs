using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {


                                                       /*int[] ar = new int[5];/// syntax for creating array
                                                                              ///another way
                                                             int[] ar1 = new int[] { 1, 2, 3, 4, 5 };          // declaration and initialization together 
                                                           for (int i = 0; i <= ar1.Length; i++)
                                              
                                                                                Console.WriteLine(ar*}*/

                string str ="";          // declare a string
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();          ///used for taking a input from user
            char[] arr = str.ToCharArray();     // str string in char array for reverse the string
            Array.Reverse(arr); ///      here we reverse our given string and check it is palindrom or not
            String str_reverse = new string(arr);


            if (str.Equals(str_reverse))

            {
                Console.WriteLine("Given string is a palindrom ..");
            }
            else
            {
                Console.WriteLine("Given String is not palidrom..");
            }
            Console.ReadLine();

           
            
        }
    }
}