using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket.Models
{
    public class Match
    {
        public Match(int noofRounds, Round round1, Round round2, int maxThrows)
        {
            Rounds = new List<Round>(noofRounds) { round1, round2 };
            Throws = new Throw(maxThrows);
        }
        public IEnumerable<Round> Rounds { get; set; }
        public IEnumerable<MatchPlayer> Players { get; set; }
        public Throw Throws { get; set; }
        public bool IsTie { get; set; }

        Random random = new Random();

        public void PlayFirstRound()
        {
            Round firstRound = Rounds.First();
            Console.WriteLine("Playing First Round");
            int batsmanScore, throwingScore;
            for (int throwNumber = 1; throwNumber <= Throws.TotalThrows; throwNumber++)
            {
                batsmanScore = RandomNumber();
                throwingScore = RandomNumber();
                if (batsmanScore == throwingScore)
                {
                    Console.WriteLine(firstRound.BattingPlayer.Name + " Throws: " + batsmanScore + ", " + firstRound.ThrowingPlayer.Name + " Throws: " + throwingScore + " "
                        + firstRound.BattingPlayer.Name + " is Out");
                    break;
                }
                else
                {
                    firstRound.BattingPlayer.Score += batsmanScore;
                    Console.WriteLine(firstRound.BattingPlayer.Name + " Throws: " + batsmanScore + ", " + firstRound.ThrowingPlayer.Name + " Throws: " + throwingScore + " "
                        + firstRound.BattingPlayer.Name + " Score is " + firstRound.BattingPlayer.Score);
                }
            }
        }

        public void PlaySecondRound()
        {
            Round firstRound = Rounds.First();
            Round secondRound = Rounds.Last();
            Console.WriteLine("Playing Second Round");
            int batsmanScore, throwingScore;
            for (int throwNumber = 1; throwNumber <= Throws.TotalThrows; throwNumber++)
            {
                batsmanScore = RandomNumber();
                throwingScore = RandomNumber();
                if (batsmanScore == throwingScore)
                {
                    Console.WriteLine(secondRound.BattingPlayer.Name + " Throws: " + batsmanScore + ", " + secondRound.ThrowingPlayer.Name + " Throws: " + throwingScore + " "
                        + secondRound.BattingPlayer.Name + " is Out");
                    break;
                }
                else
                {
                    
                    secondRound.BattingPlayer.Score += batsmanScore;

                    Console.WriteLine(secondRound.BattingPlayer.Name + " Throws: " + batsmanScore + ", " + secondRound.ThrowingPlayer.Name + " Throws: " + throwingScore + " "
                        + secondRound.BattingPlayer.Name + " Score is " + secondRound.BattingPlayer.Score);
                    
                }
            }
            if (firstRound.BattingPlayer.Score > secondRound.BattingPlayer.Score)
            {
                DeclareResult();
            }
        }

        public void DeclareResult()
        {
            Round firstRound = Rounds.First();
            Round secondRound = Rounds.Last();
            if (firstRound.BattingPlayer.Score > secondRound.BattingPlayer.Score)
                Console.WriteLine(firstRound.BattingPlayer.Name + " Wins");
            else if (firstRound.BattingPlayer.Score < secondRound.BattingPlayer.Score)
                Console.WriteLine(secondRound.BattingPlayer.Name + " Wins");
            else
                Console.WriteLine("Match is a tie");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public int RandomNumber()
        {
            return random.Next(0, Throws.TotalThrows);
        }
    }
}
