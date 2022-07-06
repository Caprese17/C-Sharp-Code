using System;
using System.Collections.Generic;
using System.Text;

namespace MarchMadness
{
    class Teams
    {
        public string name; //{ get; set; }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string rank; //{ get; set; }

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }



        public void PrintTeams(string P)
        {
            Console.WriteLine("\n From the {0} - {1} is ranked {2}", P, name, rank);
        }
    }
}
