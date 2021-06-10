using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    public static class Bot
    {

        public static byte botDifficulty = 0;
        public static bool botActive = false;
        private static readonly Random rand = new Random();
        private static int Moves;

        /// <summary>
        ///     The function generates a random place for the bot!
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <returns>The index where the AI/Bot play (Easy)</returns>
        public static int EasyMove(int[] plays)
        {
            
            while (true)
            {
                int ind = rand.Next(9);
                if (plays[ind] == -1)
                {
                    return ind;
                }
            }
        }
        /// <summary>
        ///     If the Bot can win with the next move than position will be played, 
        ///     otherwise we check if we can block opponent win on next move and if none of those is possible
        ///     then with the help of easyMove function we generate a random position to play
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <returns>The index where the AI/Bot play (Medium)</returns>
        public static int MediumMove(int[] plays)
        {
            List<int> enemyWin = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (plays[i] == -1)
                {
                    plays[i] = 0;
                    String res = WinnerCheck.CheckWin(plays, i, 0);
                    plays[i] = -1;
                    if (!res.Equals("None"))
                        return i;
                    
                    // Check if enemy can win

                    plays[i] = 1;
                    res = WinnerCheck.CheckWin(plays, i, 1);
                    if (!res.Equals("None"))
                        enemyWin.Add(i);
                    plays[i] = -1;
                }
            }

            // If bot can't win and Enemy can on next move block one possible way
            if (enemyWin.Count != 0)
                return enemyWin[0];

            return EasyMove(plays);
        }
        /// <summary>
        ///     This function with the help of minimax algorithm finds the best best move for the AI
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <param name="moves">The number of moves made util now, helps on checking Draw</param>
        /// <returns>The index where the AI/Bot play (Hard)</returns>
        public static int HardMove(int[] plays, int moves)
        {
            // MinMax Algorithm
            
            int maxScore = Int32.MinValue;
            int bestMove = -1;
            for (int i = 0; i < 9; i++)
            {
                if (plays[i] == -1)
                {
                    Moves = moves + 1;
                    plays[i] = 0;
                    int res = Minimax(plays, i, false);
                    if (res > maxScore)
                    {
                        maxScore = res;
                        bestMove = i;
                    }
                    plays[i] = -1;
                }
            }
            return bestMove;
        }
        /// <summary>
        ///     The MiniMax algorithm to find the best move for the bot Hard move!
        /// </summary>
        /// <param name="plays">The array used to check the game state!</param>
        /// <param name="lastIndex">The last index of the board where is played! (used in checkWin)</param>
        /// <param name="isMaximizing">true if AI turns, false if the player turn</param>
        /// <returns>Score that depends on the game state AI win = 10pts, Player win = -10pts and Draw = 0pts</returns>
        private static int Minimax(int[] plays, int lastIndex, bool isMaximizing)
        {
            String result = WinnerCheck.CheckWin(plays, lastIndex, isMaximizing ? 1 : 0);
            if (result.StartsWith("Win"))
            {
                return isMaximizing ? -10 : 10; //if ai looses return -10 otherwise 10
            } else if (Moves == 9)
            {
                return 0;
            }

            if (isMaximizing) // Ai Move 
            {
                int bestScore = Int32.MinValue;
                for (int i = 0; i < 9; i++)
                {
                    if (plays[i] == -1)
                    {
                        plays[i] = 0;
                        Moves++;
                        int score = Minimax(plays, i, false);
                        plays[i] = -1;
                        Moves--;
                        bestScore = Math.Max(score, bestScore);
                    }
                }
                
                return bestScore;
            }
            else
            {
                int bestScore = Int32.MaxValue;
                for (int i = 0; i < 9; i++)
                {
                    if (plays[i] == -1)
                    {
                        plays[i] = 1;
                        Moves++;
                        int score = Minimax(plays, i, true);
                        plays[i] = -1;
                        Moves--;
                        bestScore = Math.Min(score, bestScore);
                    }
                }
                return bestScore;
            }
        }
    }
}
