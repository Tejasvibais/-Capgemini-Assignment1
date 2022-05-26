using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";                 /// declartion of strings
            Console.WriteLine("Enter string");
            s = Console.ReadLine();  
            for(int i = s.Length - 1; i >= 0; i--)  ////  String reverse
            {
                revs += s[i].ToString();

            }
            if(revs == s)
            {
                Console.WriteLine("string is palindrom");

            }
            else
            {
                Console.WriteLine("string is not palindrom");
            }
                                                                                                                                                           //Console.WriteLine("Hello World!");
        }
    }
}
