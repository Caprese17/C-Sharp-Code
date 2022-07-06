using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5_Headcount
{
    class Program
    {
        static string strPrevTerr = "";
        static string strPrevArea = "";
        static string strPrevDept = "";
        static string strTerrIn;
        static string strAreaIn;
        static string strDeptIn;
        static bool bolFirstRec = true;
        static int intEmployeeCount = 0;
        static StreamReader sr = new StreamReader("InputAsgn5.txt");
        static StreamWriter sw = new StreamWriter("HeadcountReport.txt");
        static string strInputLine;
        //headings
        static string strHeading1 = "    ASSIGNMENT 5";
        static string strHeading2 = "      HEADCOUNT ";
        static string strTerrHeading = "Territory:   ";
        static string strAreaHeading = "       Area:   ";
        static string strHeading3 = "              DEPARTMENT       NUMBER OF EMPLOYEES";
        //------- Read Thru input file
        static void Main(string[] args)
        {
            //------- Read Thru input file
            while ((strInputLine = sr.ReadLine()) != null)
            {
                //sw.WriteLine(strInputLine);
                // parse input line 
                strTerrIn = strInputLine.Substring(0, 2);
                strAreaIn = strInputLine.Substring(2, 2);
                strDeptIn = strInputLine.Substring(4, 2);
                //sw.WriteLine("+++++++++++++++++++++++++");
                //sw.WriteLine(strTerrIn);
                //sw.WriteLine(strAreaIn);
                //sw.WriteLine(strDeptIn);

                //check for first record
                if(bolFirstRec)
                {
                    // Establish basis for comparison 
                    EstabBasisForComparison();
                    //turn off first rescord flag
                    bolFirstRec = false;
                    //write headings 
                    WriteHeadings();
                }
                else
                // check on upper level control break 
                // check for change in Territory or Area
                {
                    if(strTerrIn != strPrevTerr ||strAreaIn != strPrevArea)
                    {
                        //finish previous Department
                        //write out Department Line using strPrevDept and intEmployeeCount
                        WriteAndResetDept();
                        // reestalish basis for comparison
                        EstabBasisForComparison();
                        // write headings
                        WriteHeadings();
                    }
                    else
                    // check for change in lower level control break (Dept)
                    {
                        if (strDeptIn != strPrevDept)
                        {
                            WriteAndResetDept();
                            strPrevDept = strDeptIn;
                        }
                    }
                }
                intEmployeeCount = intEmployeeCount + 1;
            }
            WriteAndResetDept();
            sw.Close();

        } private static void EstabBasisForComparison()
        {
            strPrevTerr = strTerrIn;
            strPrevArea = strAreaIn;
            strPrevDept = strDeptIn;
        }
        private static void WriteHeadings()
        {
            sw.WriteLine(" ");
            sw.WriteLine(strHeading1);
            sw.WriteLine(strHeading2);
            sw.WriteLine(strTerrHeading + " " + strTerrIn);
            sw.WriteLine(strAreaHeading + " " + strAreaIn);
            sw.WriteLine(strHeading3);
        }
        private static void WriteAndResetDept()
        {
            sw.WriteLine("                  " + strPrevDept + "                    " + intEmployeeCount);
            intEmployeeCount = 0;
        }
    }
}
