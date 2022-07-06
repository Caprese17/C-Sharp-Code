using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console; 

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string strinputPath = "Vehicles.txt";
            string stroutputPath = "Registration.txt";
            using (StreamReader sr = new StreamReader(strinputPath))
            using (StreamWriter sw = new StreamWriter(stroutputPath))

            {
                string[] vehicleClassificationArray = { "AA", "BB", "CC", "DD", "EE", "FF", "GG", "HH" };
                double[] vehicleRateArray = { .015, .023, .010, .042, .051, .004, .022, .030 };
                // read through each row in input
                string vehicleClassification = "";
                string vehicleOwnersName = "";
                int vehicleWeight = 0;
                string vehicleDescription = "";
                string strInputLine = "";
                int x = 0;
                double rate = 0;
                double vehicleRegFee = 0;
                sw.WriteLine("                        REGISTRATION REPORT  ");
                sw.WriteLine("CLASSIFICATION         NAME        WEIGHT       REGISTRATION FEE      ");
                while ((strInputLine = sr.ReadLine()) != null)
                {
                    //parse input line
                    vehicleClassification = strInputLine.Substring(0, 2);
                    vehicleOwnersName = strInputLine.Substring(2, 13);
                    vehicleWeight = Convert.ToInt32(strInputLine.Substring(15, 5));
                    vehicleDescription = strInputLine.Substring(20, 10);
                    //find vehicleClassification in vehicleClassificationArray
                    for(x = 0; x < vehicleClassificationArray.Length; ++x)
                    {
                        if (vehicleClassification == vehicleClassificationArray[x])
                        {
                            rate = vehicleRateArray[x];
                            vehicleRegFee = rate * vehicleWeight;
                            sw.WriteLine("       " + vehicleClassification +  "          " + vehicleOwnersName  + "    " + vehicleWeight + "            " + vehicleRegFee.ToString("C"));
                            //force early exit from loop
                            x = vehicleClassificationArray.Length;
                                
                        }
                    }

                }



            }
              
        }
    }
}
