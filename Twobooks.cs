using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twobooks
{
    struct book
    {

        public string title;
        public string author;

    }
    class NoBooks
    {
        public static void Main()
        {
            int bookss = 10;
            book[] books = new book[bookss];
            int i, j, n = 1, k = 1;
            Console.WriteLine("Insert The Information of Two Books.");
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Information of book : {0} ", k);

                Console.Write("Input name of the book : ");
                books[j].title = Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].author = Console.ReadLine();
                k++;
                Console.WriteLine();
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                Console.WriteLine();
            }
    
        }
    }
}
