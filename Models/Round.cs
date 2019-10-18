using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket.Models
{
    public class Round
    {
        public Round(MatchPlayer battingPlayer, MatchPlayer throwingPlayer)
        {
            BattingPlayer = battingPlayer;
            ThrowingPlayer = throwingPlayer;
        }

        public MatchPlayer BattingPlayer { get; set; }
        public MatchPlayer ThrowingPlayer { get; set; }
        public int Score { get; set; }
        public bool IsOver { get; set; }
        public Throw Throw { get; set; }
    }
}
