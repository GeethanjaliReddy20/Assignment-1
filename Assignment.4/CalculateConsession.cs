1. Create a class library CalculateConcession ()  that takes age as an input and calculates concession for travel as below:If age<=5 then “Little Champs- Free Ticket” should be displayed
If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and Display “ Senior Citizen” + Calculated Fare Else “Print Ticket Booked” + Fare. 
Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.  Accept Name, Age from the user and call the CalculateConcession() function

namespace CalculateConsession
{

    public class Concession
    {
        int TotalFare = 500;
        int Age;

        public void CalculateConcession1()
        {
            Console.WriteLine("Enter Age of Citizen : ");
            Age = Convert.ToInt32(Console.ReadLine());



            if (Age <= 5)
            {
                Console.WriteLine("Little Champs-Free Ticket");
            }
            else if (Age > 60)
            {
                double CalculatedFare = TotalFare * 0.03;
                double Fare = TotalFare - CalculatedFare;
                Console.WriteLine("Senior Citizen has to pay:Rs.{0}", Fare);
            }
            else
            {
                Console.WriteLine("Ticked Booked with a payment of Rs.{0}", TotalFare);
            }
        }



    }
}

***Main Class Program***

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
Output:
Enter No. of Tickets You Want to Book: 3
Enter Citizen Name:
Hemanth
Enter Age of Citizen :
65
Senior Citizen has to pay:Rs.485
Enter Citizen Name:
Geetha
Enter Age of Citizen :
55
Ticked Booked with a payment of Rs.500
Enter Citizen Name:
5
Enter Age of Citizen :
5
Little Champs-Free Ticket

C:\Users\GB65860\source\repos\CC\CalculateConsession\bin\Debug\net6.0\CalculateConsession.exe (process 44040) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .










