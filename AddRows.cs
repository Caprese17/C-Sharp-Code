using System;

namespace AddRows
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2d = { { 5, 8, 4 }, { 1, 9, 3 }, { 11, 2, 6 } };
            Console.WriteLine("The Orginal Array Values are: ");
            for (int r = 0; r < array2d.GetLength(0); r++)
            {
                for (int c =0; c < array2d.GetLength(1); c++)
                {
                    Console.Write(array2d[r, c] + "\t");
                }
                Console.WriteLine();
            }
            //this section will add the rows and put the sum into position 0 of the row
            int sum = 0;
            
            for (int r = 0; r < array2d.GetLength(0); r++)
            {
                for (int c = 0; c < array2d.GetLength(1); c++)
                {
                    sum = array2d[r, c] + sum; // sum+= arrray2d[r,c];

                }
                array2d[r, 0] = sum;
                sum = 0;
            }

            Console.WriteLine("The rows are added and total  put into first position: ");
            for (int r = 0; r < array2d.GetLength(0); r++)
            {
                for (int c = 0; c < array2d.GetLength(1); c++)
                {
                    Console.Write(array2d[r, c] + "\t");
                }
                Console.WriteLine();
            }



            Console.ReadLine();

        }
    }
}
