using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    public class Player
    {
        public String Name { get; }
        public int Wins { get; set; }
        public int Looses { get; set; }
        public int Draws { get; set; }
        /// <summary>
        ///     Creates a new player! With 0 wins, looses, draws.
        /// </summary>
        /// <param name="name">The name of the player!</param>
        public Player(String name)
        {
            this.Name = name;
            Wins = Looses = Draws = 0;
        }
        /// <summary>
        ///     Calculates the points of a player;
        /// </summary>
        /// <returns>Total point of a player</returns>
        public int GetPoints()
        {
            return Wins * 3 + Draws;
        }
        /// <summary>
        ///     Get number of played games;
        /// </summary>
        /// <returns>Total played games!</returns>
        public int TotalGames()
        {
            return Wins + Draws + Looses;
        }
    }
}
