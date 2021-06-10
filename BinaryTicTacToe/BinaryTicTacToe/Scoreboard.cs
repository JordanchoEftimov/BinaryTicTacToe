using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    public static class Scoreboard
    {
        public static List<Player> listPlayer = new List<Player>();

        public static void AddStats(Player player)
        {
            bool found = false;
            foreach (Player p in listPlayer)
            {
                if (p.Equals(player))
                {
                    found = true;
                    p.UpdateStats(player);
                    break;
                }
            }
            if (!found)
                listPlayer.Add(player);
            listPlayer.Sort();
        }
    }
}
