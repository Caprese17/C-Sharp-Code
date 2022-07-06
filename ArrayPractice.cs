using System;

namespace In_class_Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int col = 0;

            int[,] array3DA = { { 5, 8, 4 }, { 1, 9, 3 }, { 11, 2, 6 } };

            for (int r = 0; r < array3DA.GetLength(0); r++)
            {
                
                for (int c = 0; c < array3DA.GetLength(1); c++)
                {
                    sum =+ array3DA[r, c]; // sum = sum + array3DA[r,c];
                    Console.Write(array3DA[r, c] + "\t");
                    //Console.WriteLine(sum);
                }
                
                array3DA[r, col] = sum;
                Console.WriteLine(array3DA[r, col] + "\t");
               //Console.WriteLine(sum);
            }
            
            
        }
    }
}
