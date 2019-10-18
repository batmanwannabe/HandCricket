using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket.Models
{
    public class Game
    {
        public Game(MatchPlayer player1, MatchPlayer player2, int noOfThrows)
        {
            Round firstRound = new Round(player1, player2);
            Round secondRound = new Round(player2, player1);
            Throw throws = new Throw(noOfThrows);
            CurrentMatch = new Match(2, firstRound, secondRound, noOfThrows);
        }
        public Match CurrentMatch { get; set; }

        public void PlayMatch()
        {
            CurrentMatch.PlayFirstRound();
            CurrentMatch.PlaySecondRound();
            CurrentMatch.DeclareResult();
        }
    }
}
