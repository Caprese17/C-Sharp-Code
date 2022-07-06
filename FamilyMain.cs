using System;

namespace FamBirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Family[] BDay = new Family[5];

            for(int i = 0; i < BDay.Length; i++)
            {
                BDay[i] = new Family();
            }



            for(int i = 0; i < BDay.Length; i++)
            {
                Console.WriteLine("Please Enter A Family Member's Name: ");
                BDay[i].Name = Console.ReadLine();

                Console.WriteLine("Please Enter this Family Member's Relationship to You: ");
                BDay[i].Relationship = Console.ReadLine();

                Console.WriteLine("Please Enter your {0}'s Birthday Below", BDay[i].Relationship);
                
                Console.WriteLine("Month: ");
                string month = Console.ReadLine();
                int mon = 0;
                int.TryParse(month, out mon);
                BDay[i].Month = mon;
               
                Console.WriteLine("Day: ");
                string day = Console.ReadLine();
                int d = 0;
                int.TryParse(day, out d);
                BDay[i].Day = d;

                Console.WriteLine("Year: ");
                string year = Console.ReadLine();
                int y = 0;
                int.TryParse(year, out y);
                BDay[i].Year = y;

                Console.WriteLine("-------------------------------------------------------------\n");
            }

            for (int i = 0; i < BDay.Length; i++)
            {
                //Console.WriteLine("Name          Relationship        Birthday");
                Console.WriteLine(BDay[i].Name + "           " + BDay[i].Relationship + "             " + BDay[i].Month + "/" + BDay[i].Day + "/" + BDay[i].Year);
            }


            //for (int i = 0; i < BDay.Length; i++)
            //{
            //    Array.Sort(BDay[i].Name);
            //}
        }
    }
}
