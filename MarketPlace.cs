using System;

namespace MarketPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            double result2;
           
            Console.WriteLine("Please Enter a Price");
            string str = Console.ReadLine();
            
            int.TryParse(str, out result);

            double.TryParse(str, out result2);

            Offer(str);
            Offer(result);
            Offer(result2);
            
        }

        public static void Offer(string r)
        {
            string[] units = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            if (r.Substring(0, 1) == "$" || r.Contains("dollars"))
            {
                Console.WriteLine("Offer Accepted, Thank You");
            }
            else
            {
                for (int i = 0; i < units.Length; i++)
                {
                    if (r.Contains(units[i]))
                    {
                        Console.WriteLine("Offer can not be accepted, please try again");
                    }
                }


            }

        }

        public static void Offer(int r1)
        {
            int num = 10;

            if (r1 >= num)
            {
                Console.WriteLine("Offer accepted, Thank You!");
            }

            if (r1 < num)
            {
                Console.WriteLine("Offer can not be Accepted");
            }

        }
        
        public static void Offer(double r2)
        {
            double num = 10.00;

            if (r2 >= num)
            { 
                Console.WriteLine("Offer accepted, Thank you!"); 
            }
            
            if (r2 < num)
            { 
                Console.WriteLine("Offer can not be Accepted"); 
            }
        }

     
    }
}
