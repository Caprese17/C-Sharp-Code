using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many books have you read?");
            string input = Console.ReadLine();
            
            Book read = new Book();
            
            read.Pages(input);
            

            Console.ReadLine();
        }
        
    }
}
