using System;

namespace Merged
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask how many colums the user wants in the 2 arrays
            Console.WriteLine("How many columns will the first array have?");
            int a1col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns will the second array have?");
            int a2col = Convert.ToInt32(Console.ReadLine());
            
            //Declare the new arrays(using the numer of columns the user inputted)
            int[] array1 = new int[a1col];
            int[] array2 = new int[a2col];

            //Ask the user to populate the arrays

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Please Enter the Values of the First array");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Please Enter the Values of the Second array");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            //print out original Array
            
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
            }
            Console.WriteLine();
           

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + "\t");
            }
            Console.WriteLine();

            //Merge Arrays
            //array1 # of cols = a1col()
            //array2 # of cols = a2col()
            //mergeA # of cols = a1col + a2col

            int[] mergeA = new int[a1col + a2col];
            
            //int MAcol = a1col + a2col;
            //int [] mergeA = new int [MAcol];

            

            for(int i =0; i < array1.Length; i++ )
            {
                mergeA[i] = array1[i];
              
            }
            int y = 0;
            for(int x =1; x <mergeA.Length; x++)
            {
                mergeA[x] = array2[y];
                y++;
            }

            Array.Sort(mergeA);
            Array.Reverse(mergeA);
            
            //print merged array
            for (int i = 0; i < mergeA.Length; i++)
            {
                Console.Write(mergeA[i] + "\t");
            }
            Console.WriteLine();



        }
    }
}
