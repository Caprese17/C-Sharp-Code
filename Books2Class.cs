using System;
using System.Collections.Generic;
using System.Text;

namespace BOOKS
{
    class Books
    {
        public string title { get; set; }
        public string author { get; set; }
        public int pages { get; set; }

        public void PrintBook()
        {
            Console.WriteLine("\n The title of the books is {0}, it was written by {1}, and it contains {2} pages.",title, author, pages);
        }
    }
}
