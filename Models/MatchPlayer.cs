using HandCricket.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket.Models
{
    public class MatchPlayer : Player
    {
        public MatchPlayer(string name)
        {
            Name = name;
        }

        public Form PlayerForm { get; set; }
        public int Score { get; set; }
        public bool IsOut { get; set; }
        public bool? IsWinner { get; set; }
    }
}
