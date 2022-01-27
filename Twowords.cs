using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twowords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, str1;
            Console.WriteLine("Enter the first string: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter the second string: "); 
            str1 = Console.ReadLine();
            if(str==str1)
            {
                Console.WriteLine("Given strings are same");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
            Console.Read();
        }
    }
}
