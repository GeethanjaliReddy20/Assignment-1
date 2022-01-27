using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the name");
            string s = Console.ReadLine();
            Console.WriteLine("find the length of the string :{0}", s.Length);
            Console.ReadLine();
        }
    }
}
