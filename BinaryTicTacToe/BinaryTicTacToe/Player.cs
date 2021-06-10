using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    [Serializable]
    public class Player : IComparable<Player>
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
            return Wins * 3 + Draws - 2 * Looses;
        }
        /// <summary>
        ///     Get number of played games;
        /// </summary>
        /// <returns>Total played games!</returns>
        public int TotalGames()
        {
            return Wins + Draws + Looses;
        }

        /// <summary>
        ///     Adds the new wins, looses and draws to a player.
        /// </summary>
        /// <param name="player">The object that holds the stats that should be added!</param>

        public void UpdateStats(Player player)
        {
            this.Wins += player.Wins;
            this.Looses += player.Looses;
            this.Draws += player.Draws;
        }

        /// <summary>
        ///     Implementation of IComperable interface to sort the players descending by totalPoints
        /// </summary>
        /// <param name="other">The player with who we compare!</param>
        public int CompareTo(Player other)
        {
            // To be modified
            return other.GetPoints().CompareTo(this.GetPoints());
        }
    }
}
