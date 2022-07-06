using System;

namespace InClassOutPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1, char2, char3;
            string all = Concat(out char1, out char2, out char3);
            Console.WriteLine(all);
        }

        private static string Concat(out char ch1, out char ch2, out char ch3)
        {
            Console.WriteLine("Please Enter a Character ");
            string c1 = Console.ReadLine();
            ch1 = Convert.ToChar(c1);

            Console.WriteLine("Please Enter a Character ");
            string c2 = Console.ReadLine();
            ch2 = Convert.ToChar(c2);

            Console.WriteLine("Please Enter a Character ");
            string c3 = Console.ReadLine();
            ch3 = Convert.ToChar(c3);

            string all = Convert.ToString(ch1 + ch2 + ch3);
            return all;
        }
    }
}
