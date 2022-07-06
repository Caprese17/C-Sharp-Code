using System;

namespace Readin_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows will your array have? ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns will your array have? ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] array2d = new int[rows,cols];

            //Ask the user for the values to populate the array;
            for (int r = 0; r < array2d.GetLength(0); r++)
            {
                for (int c = 0; c < array2d.GetLength(1); c++)
                {
                    Console.WriteLine("Please enter the value of cell {0}, {1}; ", r, c);
                    array2d[r, c] = Convert.ToInt32(Console.ReadLine());

                }
               
            }
            // This section prints out the array with the numbers the user inputted
            Console.WriteLine("\nThe inputted array is: ");
            for (int r = 0; r < array2d.GetLength(0); r++)
            {
                for (int c = 0; c < array2d.GetLength(1); c++)
                {
                    Console.Write(array2d[r, c] + "\t");
                }
                Console.WriteLine();
            }

            //this section will add the array entries
            int sum = 0;

            for (int r = 0; r < array2d.GetLength(0); r++)
            {
                for (int c = 0; c < array2d.GetLength(1); c++)
                {
                    sum = array2d[r, c] + sum; // sum+= arrray2d[r,c];

                }
                
                
            }
            Console.WriteLine("The sum of the array is: {0}", sum);
            

            for(int r = 0; r < array1.GetLength(0); r++)
            {
                for (int c = 0; c < array1.GetLenght(1); c++)
                {
                    Console.WriteLine("Please Enter the Value of cell {0}, {1}", r, c);
                    array1[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for(int r = 0; r < array1.GetLenght(0); r++)
            {
                for(int c = 0; c < array1.GetLegth(1); c++)
                {
                    Console.Write(array1[r, c] + "\t");
                }
                Console.WriteLine();
            }






            

        }
    }
}


