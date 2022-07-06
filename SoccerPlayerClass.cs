using System;
using System.Collections.Generic;
using System.Text;

namespace inclassScocer
{
    class SoccerPlayer
    {
        public string pname;
        public int jnum;
        public int goalsS;
        public int assists;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }
        public int Jnum
        {
            get { return jnum; }
            set { jnum =  value; }
        }
        public int GoalsS
        {
            get { return goalsS; }
            set { goalsS = value; }
        }
        public int Assists
        {
            get { return assists; }
            set { assists = value; }
        }

        // or you can do..

        //public string pname { get; set; }
        //public int jnum { get; set; }
        //public int goalsS { get; set; }
        //public int assists { get; set; }


    }
}
