using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTicTacToe
{
    public class Game
    {
        public bool Is1or0turn { get; set; }
        public int TurnsTaken { get; set; }
        public Player P1 { get; set; }
        public Player P2 { get; set; }
        public int[] Plays { get; set; }
        /// <summary>
        ///     By default we initialize 2 Player names
        /// </summary>
        public Game()
        {
            this.P1 = new Player("Player 1");
            this.P2 = new Player("Player 2");
            ResetGame();
        }
        /// <summary>
        ///     Resets the game.
        /// </summary>
        public void ResetGame()
        {
            Plays = new int[9];
            TurnsTaken = 0;
            Is1or0turn = true;
            InitializePlays();
        }
        /// <summary>
        ///     The game state helping array initialization to empty
        /// </summary>
        private void InitializePlays()
        {
            for (int i = 0; i < 9; i++)
            {
                Plays[i] = -1;
            }
        }
        /// <summary>
        ///     Helps calling the correct function to generate Bot move position.
        /// </summary>
        /// <returns>The position where the bot will play!</returns>
        public int BotMove()
        {
            int ind = -1;
            switch (Bot.botDifficulty)
            {
                case 0:
                    ind = Bot.EasyMove(Plays);
                    break;
                case 1:
                    ind = Bot.MediumMove(Plays);
                    break;
                case 2:
                    ind = Bot.HardMove(Plays, TurnsTaken);
                    break;
            }
            Plays[ind] = 0;
            ++TurnsTaken;
            return ind;
        }
    }
}
