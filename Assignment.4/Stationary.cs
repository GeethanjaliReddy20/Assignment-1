using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationary
{

    class Stationary
    {
        static void Main()
        {
            List<string> Stat = new List<string>();
            Stat.Add("Pen");
            Stat.Add("Pencil");
            Stat.Add("Eraser");
            Stat.Add("Scale");
            Stat.Add("Sharpner");
            Stat.Add("Books");
            Console.WriteLine("The Added Items are:");
            foreach (var item in Stat)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}


       
