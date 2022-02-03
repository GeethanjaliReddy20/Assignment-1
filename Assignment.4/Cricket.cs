using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricket
{
    class Cricket
    {
        int sum = 0, avg;

        public void pointsCalculation(int no_of_matches)
        {
            int[] Score = new int[20];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter Match{0} score :", i + 1);
                Score[i] = Convert.ToInt32(Console.ReadLine());
                sum += Score[i];
            }
            avg = sum / no_of_matches;
            Console.WriteLine("Sum:{0} and Avg:{1} for IPL Scores in {2} matches!!", sum, avg, no_of_matches);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Cricket c = new Cricket();
            Console.WriteLine("Enter no of matches:");
            x = Convert.ToInt32(Console.ReadLine());
            c.pointsCalculation(x);
            Console.Read();
        }
    }
}
    