﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    struct Books
    {  
        public string Name;
        private int BookId;
        public int m
        {
            get
            {
                return BookId;
            }
            set
            {
                BookId = value;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Book ID is {BookId}.");
            Console.WriteLine($"Book Name is {Name}.");
        }
    }
    class Booklb
    {
        static void Main()
          {
            Books b = new Books();
            Console.Write("Enter Book No: ");
            b.m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Name: ");
            b.Name = Console.ReadLine();
            b.Display();

        }
    }

}

