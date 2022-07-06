using System;

namespace OverloadMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number (no decimals)");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a number (no decimals)");
            int i2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Enter a number with decimals");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter a number with decimals");
            double d2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please Enter the First Half of a Word");
            string s = Console.ReadLine();
            Console.WriteLine("Please Enter the Second Half of the Same Word");
            string s2 = Console.ReadLine();

            int c = AddThem(i, i2);
            double dd = AddThem(d, d2);
            string ss =AddThem(s, s2);
            
            Console.WriteLine("\n");
            Console.WriteLine(c);
            Console.WriteLine("\n");
            Console.WriteLine(dd);
            Console.WriteLine("\n");
            Console.WriteLine(ss);

        }
        public static int AddThem(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static double AddThem(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public static string AddThem(string a, string b)
        {
            string c = a + b;
            return c;
        }

    }
}
