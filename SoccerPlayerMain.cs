using System;

namespace inclassScocer
{
    class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer splayer1 = new SoccerPlayer();
            splayer1.pname = "James";
            splayer1.jnum = 17;
            splayer1.goalsS = 28;
            splayer1.assists = 21;

            SoccerPlayer splayer2 = new SoccerPlayer();
            splayer2.pname = "Rinaldi";
            splayer2.jnum = 10;
            splayer2.goalsS = 50;
            splayer2.assists = 57;

            Console.WriteLine("Soccer player {0} has a jersey number of {1} he scored {2} goals and has {3} assists ", splayer1.pname, splayer1.jnum, splayer1.goalsS, splayer1.assists);


        }
    }
}
