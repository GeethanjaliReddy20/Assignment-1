using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
     class StringReverse
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            string rev = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i];
            }
            Console.Write("Reverse of the string:");
            Console.Write(rev);
        }
    }
}
