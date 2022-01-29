using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStudent
{
    class IStudent
    {
        interface IStudent
        {
            public void ShowDetails(int StudentId, string Name);

        }

        class Dayscholar : IStudent
        { 
            public void ShowDetails(int StudentId, string Name)
            {
                Console.WriteLine($"{Name} is a Student and The ID is {StudentId}. The student is a Residental student.");
            }


        }

        class Resident : IStudent
        {
            public void ShowDetails(int StudentId, string Name)
            {
                Console.WriteLine($"{Name} is a Student and The ID is {StudentId}. The student is a Residental student.");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {

                Dayscholar D1 = new Dayscholar();
                D1.ShowDetails(101, "Geetha");
                Dayscholar D2 = new Dayscholar();
                D2.ShowDetails(102, "Hemanth");
                Resident D3 = new Resident();
                D3.ShowDetails(103, "Nikki");
                Resident D4 = new Resident();
                D3.ShowDetails(104, "Hanisha");
            }
        }
    }
}
