using HandCricket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandCricket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name of Batting Player: ");
            var player1 = new MatchPlayer(Console.ReadLine());
            Console.WriteLine("Name of Throwing Player: ");
            var player2 = new MatchPlayer(Console.ReadLine());
            //Console.Write("Number of throws: ");
            var throws = 6;

            var game = new Game(player1, player2, throws);
            game.PlayMatch();


        }
        
    }
}
