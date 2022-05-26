using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int max1, max2;
            int[] ar1 = new int[] { 12, 34, 54, 23, 85 };         /// declartion and initialization of array
            // Console.WriteLine(ar1[1]);
            Console.WriteLine("array elements are");
            for (int i = 0; i <= ar1.Length; i++)
            {                                     /// loop for printing array elements .
                Console.WriteLine(ar1[i] + " "); 
            }


            max1 = max2 = ar1[0];
            for (int i = 0; i < ar1.Length; i++)
            {
                if (ar1[i] > max1)
                {
                    max2 = max1;
                    max1 = ar1[i];
                }
                else if (ar1[i] > max2)
                {
                    max2 = ar1[i];
                }
            }
            Console.WriteLine("first max no.  " + max1);
            Console.WriteLine("second max no.   " + max2);
            Console.ReadLine();

        }
    }
}
        
    

