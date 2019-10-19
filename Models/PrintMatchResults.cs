using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket.Models
{
    public static class PrintMatchResults
    {
        public static void PrintFirstRound()
        {
            Console.WriteLine("Playing First Round..");
        }
        public static void PrintMatchStats(string batsman, string bowler, int batScore, int throwScore, int totalScore, bool isOut)
        {
            if(isOut)
                Console.WriteLine(batsman + " Throws: " + batScore + ", " + bowler + " Throws: " + throwScore + " "
                        + batsman + " is Out");
            else
                Console.WriteLine(batsman + " Throws: " + batScore + ", " + bowler + " Throws: " + throwScore + " "
                        + batsman + " Score is " + totalScore);
        }
        public static void PrintSecondRound()
        {
            Console.WriteLine("Playing Second Round..");
        }
    }
}
