using System;

namespace smallestlargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("largest and smallest number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"The largest number is{a}");
            }
            else if (b > a && b > c)
                Console.WriteLine($"The largest number is{b}");
            else
                Console.WriteLine($"The largest numebr is{c}");

            if (a < b && a < c)
            {
                Console.WriteLine($"The  smallest number is{a}");
            }
            else if (b < a && b < c)
                Console.WriteLine($"The  smallest number is{b}");
            else
                Console.WriteLine($"The smallest numebr is{c}");
        }
    }
}
