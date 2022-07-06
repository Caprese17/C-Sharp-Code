using System;

namespace JaggedArray_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //define array
            int[][] jarr = new int[4][];
            
            //Populate Array
            jarr[0] =  new int[] { 21, 22 };
            jarr[1] = new int[] { 3, 4, 5, 6 };
            jarr[2] = new int[] { 9 };
            jarr[3] = new int[]{ 12, 24, 20 };
            
            //transverse thru, sort, and print array
            for(int r =0; r < jarr.Length; r++)
            {
                for(int c=0; c < jarr[r].Length; c++)
                {
                    Array.Sort(jarr);
                    Console.Write(jarr[r][c] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}
