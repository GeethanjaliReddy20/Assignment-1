using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    abstract class Students
    {
        public string Name;
        public int StudentId;
        public float Grade;
        abstract public Boolean IsPassed(float grade);
    }
    class Undergraduated : Students
    {
        public override Boolean IsPassed(float grade)
        {
            Console.WriteLine("Enter Name of the Student is:");
            Name = Console.ReadLine();
            Console.WriteLine("Student Name: (0)", Name);
            Console.WriteLine("Enter Student Id:");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Id: (0)", StudentId);
        .   if (grade >= 70.0f)
            {
                Console.WriteLine("The Grade of Student is:");
                return false;
            }
        }
      
    }
}
class UnderGraduate : Students
{
    public override Boolean IsPassed(float grade)
    {
        Console.WriteLine("Enter the Name of the Student is:");
        Name = Console.ReadLine();
        Console.WriteLine("Student Name: {0}", Name);
        Console.WriteLine("Enter Student Id: ");
        StudentId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("StudentId : (0)", StudentId);

        if (grade >= 80.0f)
        {
            Console.WriteLine("The Grade of Student is:");
            return true;
        }
        else
        {
            Console.WriteLine("The Grade of Student is:");
            return false;
        }
    }
}
class Abstract
{
    static void Main()
    {

        Undergraduated ug = new Undergraduated();
        Console.WriteLine(ug.IsPassed(55.0f));
        Console.WriteLine(g.IsPassed(85.0f));
        Console.Read();
    }
}


