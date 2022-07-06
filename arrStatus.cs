using System;
using System.Linq;

namespace arrStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                int value;
                Console.Write("\n\n Please Enter the Values of the Array >>  ");
                string save = (Console.ReadLine());

                while (!int.TryParse(save, out value))
                 {
                     Console.WriteLine("The Input Value was not Formatted Correctly!");
                     Console.Write("Please Enter a Different Value >>  ");
                     array1[i] = Convert.ToInt32(Console.ReadLine());
                
                 }
                //Console.WriteLine($"\n One value of the Array is {value}");
                //Console.WriteLine("Press Enter to continue Entering Values ");

                 //Console.ReadLine();
            }

            Console.WriteLine("The printed array is:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
            }
            Console.WriteLine();

            int m, n, s;
            double a;
            
            CalcMethod(out m, out n, out s, out a);
            
            Console.WriteLine($"The maximum value in the array is {m} ");
            Console.WriteLine($"The minimum value in the array is {n} ");
            Console.WriteLine($"The sum of values in the array is {s} ");
            Console.WriteLine($"The average value of the array is {m} ");
        }
        private static void CalcMethod(out int max, out int min, out int sum, out double avg, params int[] a1)
        {
            max = a1.Max();
            min = a1.Min();
            sum = a1.Sum();
            avg = a1.Average(); 
        }

        
    }
}
