using System;

namespace TaxIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax[] Products = new Tax[3];

            Products[0] = new Tax();
            Products[1] = new Tax();
            Products[2] = new Tax();

            double money = 0 ;

            for (int x = 0; x < Products.Length; x++)
            {
                Console.WriteLine("Please Enter the Name of the Product");
                Products[x].Name = Console.ReadLine();
                
                Console.WriteLine("Please Enter the Price of the Item");
                 string pr = Console.ReadLine();
                double.TryParse(pr, out money);
                Products[x].Price = money;
                Console.WriteLine("-----------------------------\n");

            }

            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine("Product Name:  " + Products[i].Name +"      Product Price:  " + Products[i].Price.ToString("C") + "       Tax:  " + Products[i].Taxowed.ToString("C"));
            }

            
        }
    }
}
