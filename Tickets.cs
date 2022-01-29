using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickects
{
    class TicketBooking : ApplicationException
    {
        public TicketBooking(string msg):base(msg)
        {
           
        }
    }
    class Passenger
    {
        string Name;
        int age;

        public void TicketBooking(int No_of_Tickets)
        {
            if (No_of_Tickets < 5)
            {
                throw (new TicketBooking("Ticket Booking Successfully"));

            }
            else
                Console.WriteLine("Cannot Book more than 5 tickets");
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Passenger P = new Passenger();
            //P.name=Console.ReadLine();
            //P.age=ConvertToInt32(Console.ReadLine())
            try
            {
                P.TicketBooking(1);
            }
            catch (TicketBooking ve)
            {
                Console.WriteLine(ve.Message + " " + ve.Source);
            }
            Console.Read();
        }
    }
}

