using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] moviesPlaying = { { "Toy Story 4", "G", "Fantasy/Animation", "100" },
                                        { "Spider-Man: No Way Home", "PG-13", "Adventure/Comedy", "148" },
                                        { "CODA", "PG-13", "Drama","112" },
                                        { "West Side Story", "PG-13","Romance/Musical","156" },
                                        { "Judy Moody and the Not Bummer Summer", "PG", "Adventure/Kid & Family", "87"},
                                        { "Power of the Dog", "R", "Drama/Western", "128" }};
            
            Console.WriteLine("Please Select One of the Below:");
            Console.WriteLine("1 - Movie Title");
            Console.WriteLine("2 - Movie Rating");
            Console.WriteLine("3 - Movie Type");
            Console.WriteLine("4 - Movie Duration");
            
            string pick1 = Console.ReadLine();
            Console.WriteLine("Your second search option: ");
            string pick2 = Console.ReadLine();

            string choice1 = "";
            string choice2 = "";

            if (pick1 == "1")
            {
                Console.WriteLine("Please Enter the Name of the Movie");
                choice1 = Console.ReadLine();
            }
            if (pick1 == "2")
            {
                Console.WriteLine("Please Enter A Movie Rating");
                choice1 = Console.ReadLine();
            }
            if (pick1 == "3")
            {
                Console.WriteLine("Please Enter A Movie Genre");
                choice1 = Console.ReadLine();
            }
            if (pick1 == "4")
            {
                Console.WriteLine("PLease Enter A Movie Duration");
                choice1 = Console.ReadLine();
            }


            if (pick2 == "1")
            {
                Console.WriteLine("Please Enter the Name of the Movie");
                choice2 = Console.ReadLine();
            }
            if (pick2 == "2")
            {
                Console.WriteLine("Please Enter A Movie Rating");
                choice2 = Console.ReadLine();
            }
            if (pick2 == "3")
            {
                Console.WriteLine("Please Enter A Movie Genre");
                choice2 = Console.ReadLine();
            }
            if (pick2 == "4")
            {
                Console.WriteLine("Please Enter A Movie Duration");
                choice2 = Console.ReadLine();
            }

            if (pick1 == "1" || pick1 == "2" || pick1 == "3")
            {
                if (pick2 == "4")
                {
                    //int pick2int = Convert.ToInt32(pick2);
                    int choice2int = Convert.ToInt32(choice2);
                    Console.WriteLine("Here Are Your Results: ");

                    Movie(moviesPlaying, choice1, choice2int);
                }
                else
                    Console.WriteLine("Here Are Your Results: ");
                    Movie(moviesPlaying, choice1, choice2);
            }


        }

        public static void Movie(string[,] MoviesPlaying, string pic1, int pic2)
        {
            string pick2 = Convert.ToString(pic2);

            for (int r = 0; r < MoviesPlaying.GetLength(0); r++)
            {
                for(int c = 0; c < MoviesPlaying.GetLength(1); c++)
                {
                   if (pic1 == MoviesPlaying[r, c])
                        //&& pick2 == MoviesPlaying[r,c])
                   //if(MoviesPlaying[r,c].Contains(pic1) && MoviesPlaying[r, c].Contains(pick2))
                    {
                        printOutMethod(MoviesPlaying, pic1);
                        //printOutMethod(MoviesPlaying, pic1, pick2);

                    }
                }
            }

            for (int r = 0; r < MoviesPlaying.GetLength(0); r++)
            {
                for (int c = 0; c < MoviesPlaying.GetLength(1); c++)
                {
                    if (pick2 == MoviesPlaying[r, c])
                    //if (MoviesPlaying[r, c].Contains(pick2))
                    {

                        printOutMethod(MoviesPlaying, pick2);
                    }
                }
            }

        }

        public static void Movie(string[,] MoviesPlaying, string pic1, string pic2)
        {
            
            for (int r = 0; r < MoviesPlaying.GetLength(0); r++)
            {
                for (int c = 0; c < MoviesPlaying.GetLength(1); c++)
                {

                    if(pic1 == MoviesPlaying[r, c])
                    //if (MoviesPlaying[r, c].Contains(pic1) && MoviesPlaying[r, c].Contains(pic2))
                    {

                        printOutMethod(MoviesPlaying, pic1);
                    }
                }
            }

            for (int r = 0; r < MoviesPlaying.GetLength(0); r++)
            {
                for (int c = 0; c < MoviesPlaying.GetLength(1); c++)
                {
                    if (pic2 == MoviesPlaying[r, c])
                    //if (MoviesPlaying[r, c].Contains(pic2))
                    {

                        printOutMethod(MoviesPlaying, pic2);
                    }
                }
            }
        }

        public static void printOutMethod(string[,] MoviesPlaying, string choice)
        {
             
            for (int r = 0; r < MoviesPlaying.GetLength(0); r++)

            { 
                for (int c = 0; c < MoviesPlaying.GetLength(1); c++)
                {
                    if (choice == MoviesPlaying[r, c])
                        //if (MoviesPlaying[r, c].Contains(choice))

                        Console.Write(MoviesPlaying[3, c] + "  ");
                  
                }
                Console.WriteLine();
            }


        }
    }
}
