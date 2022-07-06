using System;

namespace RevArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask how many rows and columns in the array
            Console.WriteLine("How many columns do you want your array to have?");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many rows do you want your array to have?");
            int rows = Convert.ToInt32(Console.ReadLine());

            //create new array
            int[,] array1 = new int [rows, cols];

            //populate and print the original array (method call)
            populateArray(array1, rows, cols);

            //reverse and print the reversed arrray (method call)
            reverseArray(array1, rows, cols);

            

        }
        //populate array method
        private static void populateArray(int[,] poparray, int rows,int cols )
        {
            

            //populating the array
            for (int r = 0; r < poparray.GetLength(0); r++)
            {
                for (int c = 0; c < poparray.GetLength(1); c++)
                {
                    Console.WriteLine("Please enter the value of cell {0}, {1}; ", r, c);
                    poparray[r, c] = Convert.ToInt32(Console.ReadLine());

                }
            }
            // printing the array
            Console.WriteLine();
            Console.WriteLine("This is the Original Array: ");
            for (int r = 0; r < poparray.GetLength(0); r++)
            {
                for (int c = 0; c < poparray.GetLength(1); c++)
                {
                    Console.Write(poparray[r, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private static void reverseArray(int [,] RevArray, int rows, int cols )
        {
            //print reverse array
            Console.WriteLine("This is the Reverse Array: ");

            for( int r = 0; r < RevArray.GetLength (0); r++)
            {
                for( int c = 0; c < RevArray.GetLength (1); c++)
                {
                    Console.Write(RevArray[c, r] + "\t");
                }
                Console.WriteLine();
            }
        }

        
    }
}
