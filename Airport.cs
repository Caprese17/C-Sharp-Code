using System;
using System.Linq;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int[] flights = {201, 321, 510, 633};

            Console.WriteLine("Please Enter a Flight Number");
            int input = Convert.ToInt32(Console.ReadLine());

            string res = GetInfo(ref input);
            Console.WriteLine(res);
               
        }

        public static string GetInfo(ref int ip)
        {
            
            //if (ip == flights[0])
            if (ip == 201)
            {
                string acode = "ALB";
                string aname = "Albany";
                string time = "0710";

                string result = "Your flight number 201 flighing out of " + acode + " " + aname + " " + "will depart at " + time;
                return result;

            }
            //if (ip == flights[1])
            if (ip == 321)
           {
                string acode = "SWF";
                string aname = "Newburg";
                string time = "0830";

                string result = "Your flight number 321 flighing out of " + acode + " " + aname + " " + "will depart at " + time;
                return result;
            }
            //if (ip == flights[2])
            if (ip == 510)
            {
                string acode = "HPN";
                string aname = "Westchester";
                string time = "0915";

                string result = "Your flight number 510 flighing out of " + acode + " " + aname + " " + "will depart at " + time;
                return result;

            }
            //if (ip == flights[3])
            if (ip == 633)
            {
                string acode = "JFK";
                string aname = "JF Kennedy";
                string time = "1140";

                string result = "Your flight number 633 flighing out of " + acode + " " + aname + " " + "will depart at " + time;
                return result;
            }
            else
            {
                string result = "Your flight information could not be found ";
                return result;
            }
        }

        

        
    }

}
