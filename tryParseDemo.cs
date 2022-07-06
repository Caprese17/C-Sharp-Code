using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryParseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           int score;
            /*Console.Write("Enter a test score >>:  ");
            score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nthe value of score is {score}");

            Console.ReadLine();*/

            //boolean
            string arrayValue;
            int value;
            Console.Write("\n\n Please Enter the Values of the Array >>  ");
            arrayValue = Console.ReadLine();
            while (!int.TryParse(arrayValue, out value))
            {
                Console.WriteLine("The Input data was not Formatted Correctly!");
                Console.Write("Please Enter a Different Value >>  ");
                arrayValue = Console.ReadLine();

            }
            Console.WriteLine($"\n One value of the Array is {value}");

            Console.ReadLine();
        }
    }
}
