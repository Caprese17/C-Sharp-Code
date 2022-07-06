using System;

namespace BOOKS
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();
            book1.title = "The Lake";
            book1.author = "Natash Preston";
            book1.pages = 384;

            book1.PrintBook();

            Books book2 = new Books();
            book2.title = "The Time Machine";
            book2.author = "J.R.R. Tolkien";
            book2.pages = 320;

            book2.PrintBook();

            Books book3 = new Books();
            book3.title = "The Alchemist";
            book3.author = "Paublo Coelho";
            book3.pages = 208;

            book3.PrintBook();




        }
    }
}
