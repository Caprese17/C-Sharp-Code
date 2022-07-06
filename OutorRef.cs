using System;

namespace inclassOutofRef
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter a Character: ");
            string stg1 = Console.ReadLine();
            char char1 = Convert.ToChar(stg1);

            Console.WriteLine("Please Enter a Character: ");
            string stg2 = Console.ReadLine();
            char char2 = Convert.ToChar(stg2);


            Console.WriteLine("Please Enter a Character: ");
            string stg3 = Console.ReadLine();
            char char3 = Convert.ToChar(stg3);


            string str = Concatenate(ref char1, ref char2, ref char3);
            Console.WriteLine(str);
             

        }
        private static string Concatenate(ref char c1, ref char c2, ref char c3)
      
        {
            
            
            
            string all = Convert.ToString(c1 + c2 + c3);

            return all;
        }
    }
}
