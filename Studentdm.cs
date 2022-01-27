﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdm
{
    class student
    {
        int RollNo;

        string Name;

        string Class;

        int Semister;

        string Branch;

        int sum = 0;

        int avg;

        int[] marks = new int[5];
        public student(int rollno, string name, string StudClass, int sem, string branch)
        {
            RollNo = rollno;
            Name = name;
            Class = StudClass;
            Semister = sem;
            Branch = branch;
        }


        public void DisplayResults()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the sub (0) marks of Student :", 1 + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / 5;
            Console.WriteLine("The Average of student in 5 subjects is: {0}", avg);

            for (int i = 0; i < 5; i++)
            {
                if (marks[1] < 35)
                {
                    Console.WriteLine("Student result is FAILED");
                }
                else if ((marks[i] > 35) && (avg < 50))
                {
                    Console.WriteLine("Student result is FAILED");
                }
                else
                {
                    Console.WriteLine("Student result is PASSED");
                }
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("The Student details are:");
            Console.WriteLine("RollNo:" + RollNo + "\n" + "name:" + Name + "\n" + "Class:" + Class + "\n" + "Semister:" + Semister + "\n" + "Branch:" + Branch);
            DisplayResults();
        }
        static void Main()
        {
            student Stud = new student(555,"Geetha", "BTech", 8, "CSE"); 
            Stud.DisplayData();
            Console.ReadLine();
        }
    }
}
