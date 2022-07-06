using System;

namespace CookieSale1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie co1 = new Cookie("Mints", 4);
            Cookie co2 = new Cookie("Lemonades", 5);

            Cookie Sum = co1 + co2;

            co1.Display();
            Console.WriteLine();
            co2.Display();

            double tCost = Sum.Amt * 5;

            Console.WriteLine("The total cost for {0} boxes of cookies is: {1}", Sum.Amt, tCost);
        }
    }
}
