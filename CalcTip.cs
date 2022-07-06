using System;

namespace CalcTip
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolamt;
            float perc;
            bool check = false;
           
                while (check == false)
               {
                Console.WriteLine("Please Enter the Total Price of Your Bill");
                double bill = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Please Enter a Tip (Percentage % or Dollar Amount $)");
                string input = Console.ReadLine();

                if (input.Contains("$"))
                    //(input.Substring(0, 1) == "$")
                {
                    string input2 = input.Substring(0, input.Length-1) ; 
                    double.TryParse(input2, out dolamt);
                    TipCalc(bill, dolamt);
                }


                if (input.Contains("%"))
                {
                    string input3 = input.Substring(0, input.Length-1);
                    float.TryParse(input3, out perc);
                    TipCalc(bill, perc);
                }

                Console.WriteLine("Are You Finished Calculating the Tip? Y or N");
                string ans = Convert.ToString(Console.ReadLine());
                ans.ToUpper();
                if (ans == "Y")
                    Console.WriteLine("Thank You, Good Bye!");
                check = true;
                if (ans == "N")
                    check = false;
                
            }

            
            
        }
        public static void TipCalc(double b, double t = 0)
        {
            double amount = b + t;
            Console.WriteLine("The Bill is {0}$, before tip", b);
            Console.WriteLine("The Tip is {0}$", t);
            Console.WriteLine("The Total is {0}$", amount);

        }

        public static void TipCalc(double b, float p = 0)
        {
            float t = p / 100;
            double tip = b * t;
            double amount = b + tip;
            Console.WriteLine("The Bill it {0}$, before tip", b);
            Console.WriteLine("The Tip is {0}$", tip);
            Console.WriteLine("The Total is {0}$", amount);

        }
       

    }
}
