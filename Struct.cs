using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class structureex
    {
        
        struct employee
        {
            public string eName;
            public DOB Date;
        }
       
        struct DOB
        {
            public int Date;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {

            int d, m, y;

            Console.WriteLine("Create a nested structure and store data in an array :");
            Console.WriteLine("Enter Total no of employee you want to enter");
            int t = Convert.ToInt32(Console.ReadLine());
            employee[] emp = new employee[t];
            
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Enter day of birth : ");
                d = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Date = d;

                Console.Write("Enter month of birth : ");
                m = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = m;

                Console.Write("Enter year for birth : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = y;
            }
        }
    }
}
