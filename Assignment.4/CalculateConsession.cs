using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConsession;

namespace CalculateConsession
{
    class Program224
    {
        static void Main()
        {
            int TotalFare = 500;
            string Name;
            int Age;
            Console.Write("Enter No. of Tickets You Want to Book: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Citizen Name: ");
                Name = Console.ReadLine();
                Concession c = new Concession();
                c.CalculateConcession1();

            }

        }
    }
}
