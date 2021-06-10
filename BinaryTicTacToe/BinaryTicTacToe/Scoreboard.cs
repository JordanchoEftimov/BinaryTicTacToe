using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    public static class Scoreboard
    {
        public static SortedSet<Player> players = new SortedSet<Player>();
        public static List<Player> listPlayer = players.ToList<Player>();

        public static void UpdateList()
        {
            listPlayer = players.ToList();
        }
        public static void AddStats(Player player)
        {
            if (players.Contains(player))
            {
                Player p;
                players.TryGetValue(player, out p);
                players.Remove(player);
                p.UpdateStats(player);
                players.Add(p);
            } else
            {
                players.Add(player);
            }
            UpdateList();
        }
    }
}
