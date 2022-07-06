using System;

namespace DeliverCo_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Zip Code");
            int custzc = Convert.ToInt32(Console.ReadLine());

            int[] zipcode = { 12601, 12538, 12572, 12578, 12514 };
            
            bool find = false;
            for(int i = 0; i < zipcode.Length && !find; i++)
            {
                if (custzc == zipcode[i])
                { Console.WriteLine("We do deliver to your address");
                    find = true;
                }
                if (!(custzc == zipcode[i]) )
                {
                    Console.WriteLine("We do not deliver to your address");
                    find = true;
                }
                
                
                
            }
        }
    }
}
