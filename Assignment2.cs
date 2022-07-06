using System;
using static System.Console;


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please write your name ");
            ReadLine();
            WriteLine("Please enter the price of the item. Use decimal point if needed ");
            double itemPrice = Convert.ToInt32(ReadLine());
            WriteLine("Please enter the quantity");
            int itemQuantity = Convert.ToInt32(ReadLine());
            WriteLine("Please enter discount percent with out decimal, i.e. 25% is 25 ");
            double itemDiscount = Convert.ToInt32(ReadLine());
            double total = (itemPrice * itemQuantity) * (1 - itemDiscount / 100);
            string totalString = total.ToString("C");
            WriteLine("The total is: {0} ", totalString);
        }
    }
}
