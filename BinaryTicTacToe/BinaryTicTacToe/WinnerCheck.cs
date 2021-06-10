using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    /// <summary>
    ///     Helping class to check if the game has a winner!
    /// </summary>
    public static class WinnerCheck
    {
        /// <summary>
        ///     This variable contains all possible win combos depending on a click. 
        ///     <br>If the first field is field is clicked then there are 3 win possibilities:</br>
        ///     <br>1. Same row</br>
        ///     <br>2. Same column</br>
        ///     <br>3. Main diagonal </br>
        ///     <br>and only thoose possiblities are checked!</br>
        /// </summary>
        private static readonly int[][,] winCombos =
        {
            new[,] {{0, 1, 2}, {0, 3, 6}, {0, 4, 8} },            // 0
            new[,] {{0, 1, 2}, {1, 4, 7}},                        // 1
            new[,] {{0, 1, 2}, {2, 5, 8}, {2, 4, 6} },            // 2
            new[,] {{0, 3, 6}, {3, 4, 5}},                        // 3
            new[,] {{3, 4, 5}, {1, 4, 7}, {0, 4, 8}, {2, 4, 6} }, // 4
            new[,] {{2, 5, 8}, {3, 4, 5}},                        // 5
            new[,] {{0, 3, 6}, {6, 7, 8}, {2, 4, 6} },            // 6
            new[,] {{1, 4, 7}, {6, 7, 8}},                        // 7
            new[,] {{0, 4, 8}, {2, 5, 8}, {6, 7, 8} }             // 8
        };
        /// <summary>
        ///     The function checks if theres a win!
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <param name="last">The index of the fieled where the last move was made!</param>
        /// <param name="move">Wich player played last First Player(1) or Second Player / Bot (0)</param>
        /// <returns>
        ///     Returns None if no one won and it returns Win: field positions of the win seperated by comma.
        ///     <br>Ex: Win:0,1,2 Means It was a win on the first row!</br>
        /// </returns>
        public static String CheckWin(int[] plays, int last, int move)
        {
            int[,] pos = winCombos[last];
            /// Each row has 3 elements (the .Length attribute gives the total elemnts number) so
            /// dividing by 3 gives the number of rows (number of win possibilities for that field click)
            for (int i = 0; i < pos.Length / 3; i++) 
            {
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (plays[pos[i, j]] != move) /// If one field has different value than the player that moved no need to check further
                       break;
                    ++count;
                }
                if (count == 3) /// Win Message
                    return String.Format("Win:{0},{1},{2}", pos[i, 0], pos[i, 1], pos[i, 2]);
            }
            return "None";
        }
    }
}
