using System;

namespace MarchMadness
{
    class Program
    {
        static void Main(string[] args)
        {
            Teams finalfour1 = new Teams();
            finalfour1.name = "Duke";
            finalfour1.rank = "2nd";
            string west = "West";

            finalfour1.PrintTeams(west);

            Teams finalfour2 = new Teams();
            finalfour2.name = "Villanova";
            finalfour2.rank = "2nd";
            string south = "South";

            finalfour2.PrintTeams(south);

            Teams finalfour3 = new Teams();
            finalfour3.name = "Kansas";
            finalfour3.rank = "1st";
            string midwest = "Mid West";

            finalfour3.PrintTeams(midwest);

            Teams finalfour4 = new Teams();
            finalfour4.name = "North Carolina";
            finalfour4.rank = "8th";
            string east = "East";

            finalfour4.PrintTeams(east);

            //Console.WriteLine("\n From the {0} - {1} is ranked {2}", west, finalfour1.name, finalfour1.rank);
            //Console.WriteLine("\n From the {0} - {1} is ranked {2}", south, finalfour2.name, finalfour2.rank);
            //Console.WriteLine("\n From the {0} - {1} is ranked {2}", midwest, finalfour3.name, finalfour3.rank);
            //Console.WriteLine("\n From the {0} - {1} is ranked {2}", east, finalfour4.name, finalfour4.rank);


            Console.WriteLine("\n {0} vs. {1} ", finalfour1.name, finalfour4.name);
            Console.WriteLine("\n {0} vs. {1} ", finalfour3.name, finalfour2.name);






        }
    }
}
