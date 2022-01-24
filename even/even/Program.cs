using System;

namespace even
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the input");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("given number is even");
            }
            else
                Console.WriteLine("given number is odd");
        }
    }
}
