using System;
using static System.Console;

namespace DemoOrandAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ZONE1 = 1, ZONE2 = 2;
            const int LOW_QUALITY = 10;
            string inputString;
            int quantity;
            int deliveryZone;

            WriteLine("Delivery is free for zone {0} or {1}", ZONE1, ZONE2);
            WriteLine("when the number of boxes is less than {0}", LOW_QUALITY);
            WriteLine("Enter Delivery zone ");
            inputString = ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            WriteLine("Enter the of boxes in the shipment");
            inputString = ReadLine();
            quantity = Convert.ToInt32(inputString);

            if ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && quantity < LOW_QUALITY)
                WriteLine("Delivery is free");
            else
                WriteLine("A delivery charge applies");

        }
    }
}
