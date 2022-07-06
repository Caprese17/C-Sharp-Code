using System;

namespace ApartmentHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartments[] Apts = new Apartments[8];

            for(int i = 0; i < Apts.Length; i++)
            {
                Apts[i] = new Apartments();
            }

            Apts[0].propnum = 192873;
            Apts[1].propnum = 498730;
            Apts[2].propnum = 218502;
            Apts[3].propnum = 612739;
            Apts[4].propnum = 457834;
            Apts[5].propnum = 927439;
            Apts[6].propnum = 570520;
            Apts[7].propnum = 734059;

            Apts[0].proptype = "Single Family";
            Apts[1].proptype = "Single Family";
            Apts[2].proptype = "Apartment";
            Apts[3].proptype = "Apartment";
            Apts[4].proptype = "Townhouse";
            Apts[5].proptype = "Apartment";
            Apts[6].proptype = "Apartment";
            Apts[7].proptype = "Townhouse";

            Apts[0].bed = 5;
            Apts[1].bed = 4;
            Apts[2].bed = 2;
            Apts[3].bed = 1;
            Apts[4].bed = 3;
            Apts[5].bed = 1;
            Apts[6].bed = 3;
            Apts[7].bed = 4;

            Apts[0].bath = 3.5;
            Apts[1].bath = 2.5;
            Apts[2].bath = 1.0;
            Apts[3].bath = 1.0;
            Apts[4].bath = 2.5;
            Apts[5].bath = 1.0;
            Apts[6].bath = 2.0;
            Apts[7].bath = 1.5;

            Apts[0].rent = 2250.00;
            Apts[1].rent = 1885.00;
            Apts[2].rent = 1175.50;
            Apts[3].rent = 945.00;
            Apts[4].rent = 1750.50;
            Apts[5].rent = 1100.00;
            Apts[6].rent = 1245.95;
            Apts[7].rent = 1950.25;


            //print to check it is populated
            //for (int i = 0; i < Apts.Length; i++)
            //{
            //    Console.WriteLine(Apts[i].propnum + " " + Apts[i].proptype + " " + Apts[i].bed + " " + Apts[i].bath + " " + Apts[i].rent);
            //}

            bool stoploop = false;
            while (stoploop == false)
            {
                Console.WriteLine("Please Enter the Number of the Search Option You Would Like");
                Console.WriteLine("1 - Property Number ");
                Console.WriteLine("2 - Property Type");
                Console.WriteLine("3 - Number of Bedrooms");
                Console.WriteLine("4 - Number of Bathrooms");
                Console.WriteLine("5 - Monthly Rent");

                string input = Console.ReadLine();
                int search;
                int.TryParse(input, out search);

                if (search == 1)
                {
                    bool found = false;
                    Console.WriteLine("Please Enter the Property Number Your Are Looking for");
                    string input1 = Console.ReadLine();
                    int propnum;
                    int.TryParse(input1, out propnum);
                    for (int i = 0; i < Apts.Length; i++)
                    {
                        if (Apts[i].propnum == propnum)
                        {
                            Console.WriteLine(Apts[i].propnum + "   " + Apts[i].proptype + "   " + Apts[i].bed + "     " + Apts[i].bath + "   " + Apts[i].rent);
                            found = true;
                        }
                    }

                    if(found == false)
                        Console.WriteLine("Number Not Found");
                 
                }

                if (search == 2)
                {
                    Console.WriteLine("Please Enter a Number for the Property Type Your Are Looking for");
                    Console.WriteLine("1 - Apartment");
                    Console.WriteLine("2 - Single Family");
                    Console.WriteLine("3 - Townhome");
                    string input2 = Console.ReadLine();
                    int type;
                    int.TryParse(input2, out type);

                    if (type == 1)
                    {
                        for (int i = 0; i < Apts.Length; i++)
                        {
                            if (Apts[i].proptype == "Apartment")
                            {
                                Console.WriteLine(Apts[i].propnum + "   " + Apts[i].proptype + "    " + Apts[i].bed + "    " + Apts[i].bath + "     " + Apts[i].rent);
                            }

                        }
                    }
                    if (type == 2)
                    {
                        for (int i = 0; i < Apts.Length; i++)
                        {
                            if (Apts[i].proptype == "Single Family")
                            {
                                Console.WriteLine(Apts[i].propnum + "    " + Apts[i].proptype + "    " + Apts[i].bed + "    " + Apts[i].bath + "    " + Apts[i].rent);
                            }

                        }
                    }
                    if (type == 3)
                    {
                        for (int i = 0; i < Apts.Length; i++)
                        {
                            if (Apts[i].proptype == "Townhouse")
                            {
                                Console.WriteLine(Apts[i].propnum + "   " + Apts[i].proptype + "   " + Apts[i].bed + "    " + Apts[i].bath + "   " + Apts[i].rent);
                            }

                        }
                    }

                }


                if (search == 3)
                {
                    Console.WriteLine("Please Enter the Number of Bedrooms you Would Like, From 1 -5");
                    string input3 = Console.ReadLine();
                    int bed;
                    int.TryParse(input3, out bed);

                    for (int i = 0; i < Apts.Length; i++)
                    {
                        if (Apts[i].bed == bed)
                        {
                            Console.WriteLine(Apts[i].propnum + "    " + Apts[i].proptype + "    " + Apts[i].bed + "    " + Apts[i].bath + "    " + Apts[i].rent);
                        }

                    }
                }

                if (search == 4)
                {
                    Console.WriteLine("Please Enter the Number of Bathrooms you Would Like, From 1.0 - 3.5");
                    string input4 = Console.ReadLine();
                    double bath;
                    double.TryParse(input4, out bath);

                    for (int i = 0; i < Apts.Length; i++)
                    {
                        if (Apts[i].bath == bath)
                        {
                            Console.WriteLine(Apts[i].propnum + "    " + Apts[i].proptype + "    " + Apts[i].bed + "    " + Apts[i].bath + "   " + Apts[i].rent);
                        }

                    }

                }

                if (search == 5)
                {
                    Console.WriteLine("Please Enter the the Number for the Price Range Your are Searching for");
                    Console.WriteLine("1 - below $1,000");
                    Console.WriteLine("2 - between $1,000 - $2,000");
                    Console.WriteLine("3 - between $2,000 -$3,000");

                    string input5 = Console.ReadLine();
                    double rent;
                    double.TryParse(input5, out rent);

                    if (rent == 1)
                    {
                        for (int i = 0; i < Apts.Length; i++)
                        {
                            if (Apts[i].rent < 1000)
                            {
                                Console.WriteLine(Apts[i].propnum + "    " + Apts[i].proptype + "    " + Apts[i].bed + "    " + Apts[i].bath + "    " + Apts[i].rent);
                            }
                        }
                    }

                    if (rent == 2)
                    {
                        for (int i = 0; i < Apts.Length; i++)
                        {
                            if (Apts[i].rent > 1000 && Apts[i].rent < 2000)
                            {
                                Console.WriteLine(Apts[i].propnum + "    " + Apts[i].proptype + "    " + Apts[i].bed + "    " + Apts[i].bath + "    " + Apts[i].rent);
                            }
                        }
                    }

                    if (rent == 3)
                    {
                        for (int i = 0; i < Apts.Length; i++)
                        {
                            if (Apts[i].rent > 2000 && Apts[i].rent < 3000)
                            {
                                Console.WriteLine(Apts[i].propnum + "   " + Apts[i].proptype + "   " + Apts[i].bed + "   " + Apts[i].bath + "   " + Apts[i].rent);
                            }
                        }
                    }

                }

                Console.WriteLine("Would You Like to Do Another Search? Y or N ");
                string quest = Console.ReadLine();
                quest.ToUpper();
                
                if (quest == "N")
                    Console.WriteLine("Hope You Found Your Dream Home! Goodbye!");
                    stoploop = true;
                if (quest == "Y")
                    stoploop = false;

            }

        }
    }
}
