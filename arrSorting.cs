using System;

namespace arrSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strgArr = { "Q", "D", "R", "I", "K" };
            
            Console.WriteLine("The original string is:");
            
            foreach (string x in strgArr)
            { Console.WriteLine(x + "\t"); }
         

            Array.Sort(strgArr);

            Console.WriteLine("The sorted string is:");
            
            foreach (string x in strgArr)
            { Console.WriteLine(x + "\t"); }
           
            Console.WriteLine("What Letter would you like to search for in the array?");
            string input = Console.ReadLine().ToUpper();
           
            
            indexMethod(strgArr,input);

            
            

        }
        public static void indexMethod(string[] strgArr1, string input1)
        {
           int index =  Array.BinarySearch(strgArr1, input1);
            if (index < 0)
                Console.WriteLine("the letter you entered is not in the array!");
            else
                Console.WriteLine($"index value is: {index}");
        }
    }
}
