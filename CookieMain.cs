using System;

namespace CookieSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Cookie co1 = new Cookie("Mints", 4);
            Cookie co2 = new Cookie("Lemonades", 5);

            Cookie Sum = co1.Amt + co2.Amt;

            co1.Display();
            Console.WriteLine();
            co2.Display();

            double tCost = Total.Amt * 5;

        }
    }
}
