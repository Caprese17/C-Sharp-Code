using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_4__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInputPath = "Movies input file.txt";
            string strOutputPath = "PickList.txt";
            using (StreamReader sr = new StreamReader(strInputPath))
            using (StreamWriter sw = new StreamWriter(strOutputPath))
            {
                string strInputLine;
                // input fields
                string movieName;
                int movieMinutes = 0;
                string movieGenre;
                string movieRating;
               
                // Work feilds
                int totalMinutes = 0;
                int movieCounter = 0;
                int dramaCounter = 0;
                int GCounter = 0;
                string genreDesc = "";
                string ratingDesc = "";
               

                // Write out Headings
                sw.WriteLine("Movie Pick List");
                sw.WriteLine("Movie                            Minutes      Genre         Rating");

                //process each record
                while ((strInputLine = sr.ReadLine()) != null)
                {
                    //sw.WriteLine(strInputLine);
                    //Parse input line
                    movieName = strInputLine.Substring(0, 30);
                    movieMinutes = Convert.ToInt32(strInputLine.Substring(30, 3));
                    movieGenre = strInputLine.Substring(33, 3);
                    movieRating = strInputLine.Substring(36, 5).Trim();

                    //sw.Write(movieName + "   " + movieMinutes + "   ");  
                    //sw.WriteLine(movieGenre + "   " + movieRating);

                    // for every record
                    
                    //add movieMinutes to totalMinutes
                    //add 1 to movieCounter
                    totalMinutes = totalMinutes + movieMinutes;
                    movieCounter = movieCounter + 1;
                    //if (movieGenre = "DRA", add 1 to dramaCounter)
	                //if (movieRating = "G", add 1 to GCounter)
                    if (movieGenre == "DRA")
                    dramaCounter = dramaCounter + 1;
                   
                    if (movieRating == "G")
                       GCounter = GCounter + 1;
                    
                    /*if(movieGenre = CRI, movieMinutes >= 60 && movieMinues <= 200 minutes)
	                  or 
	                  if (movieGenre = ROM, movieMinutes > 115)
                     */
                    if ((movieGenre == "CRI" && movieMinutes >= 60 && movieMinutes <= 200)
                        ||
                       (movieGenre == "ROM" && movieMinutes > 115))
                    {
                        //switch movieGenre
                        //when CRI then genreDesc = "Crime"
                        //when ROM then genreDesc = "Romance"
                        switch (movieGenre)
                        {
                            case "CRI":
                                ;
                                genreDesc = "Crime";
                                break;
                            case "ROM":
                                ;
                                genreDesc = "Romance";
                                break;
                        }
                        /*when G ratingDesc = "General Audiences"
                        when PG ratingDesc = "Parental Guidance Suggested"
                        when PG-13 ratingDesc = "Parents Stongly Cautioned"
                        when R ratingDesc = "Restricted"*/
                        switch (movieRating)
                        { 
                            case "G":
                                ;
                                ratingDesc = "General Audiences";
                                break;
                            case "PG":
                                ;
                                ratingDesc = "Parental Guidance Suggested";
                                break;
                            case "PG-13":
                                ;
                                ratingDesc = "Parents Strongly Cautioned";
                                break;
                            case "R":
                                ;
                                ratingDesc = "Restricted";
                                break;
                        }
                        sw.WriteLine(movieName + "   " + movieMinutes.ToString().PadRight(3) + "          " + genreDesc.PadRight(10) + "    " + ratingDesc.PadLeft(3));
                        }// end of if statement




                } // end of while

                //Write Summary Lines
                sw.WriteLine("");
                sw.WriteLine("Number of Drama Movies: " + dramaCounter);
                sw.WriteLine("Number of G Rated Movies: " + GCounter);
                sw.WriteLine("Average Length of All Movies: " + (totalMinutes / movieCounter).ToString());

                //Console.ReadLine();
            }
        }
      
    }
  
}
