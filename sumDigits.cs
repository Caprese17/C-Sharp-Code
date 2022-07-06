using System;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "y"; 

            while (ans == "y")
            {
                Console.WriteLine("Please Enter A number to be summed");
                string num = Console.ReadLine();

                
               SumNum(num);
                Console.WriteLine("Would You Like to Continue Entering Numbers y or n ?");
                ans = Console.ReadLine();
                //ans = String.ToUpper(response);

            }
            Console.WriteLine("Thanks for playing");
            Console.ReadLine();
        }

        private static void SumNum(string number)
        {
            //int numLen = number.Length;
            //int[] sum = new int[numLen];
            //Console.WriteLine("the length of the number entered is: {0}", numLen);
            //sum[0] = number[0] - '0';
            //int result = sum[0]; 
            //int result = 0;
            //


            /*for(int i = 1; i < numLen; i++)
           {
                int numi = Convert.ToInt32(number.Substring(0, i));
                //Console.WriteLine(numi);
                result =+ numi;
                
                //number[i] ;
                //sum[i] = (i + 1) * numi + 10 * sum[i - 1];
                //result += sum[i];
                //sum[i];   
            }*/
            //Console.WriteLine(result);

            int sum = 0; 
            for(int x=0; x < number.Length; x++)
            {
                sum = sum + Convert.ToInt32(number.Substring(x, 1));
            }
            Console.WriteLine("The Sum of the digits in the number entered is: {0}", sum );

            //int num1 = Convert.ToInt32(number.Substring(0, 1));
            //Console.WriteLine(num1);
            //int num2 = Convert.ToInt32(number.Substring(1, 1));
            //Console.WriteLine(num2);
            //int num3 = Convert.ToInt32(number.Substring(2, 1));
            //Console.WriteLine(num3);
       
            //Console.WriteLine(num1 + num2 + num3);
        }
    }
}
