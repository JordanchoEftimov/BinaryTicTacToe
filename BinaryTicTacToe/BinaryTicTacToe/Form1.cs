using System;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Collections.Generic;

namespace BinaryTicTacToe
{
    public partial class Form1 : Form
    {
        private Game Game { get; set; }
        private Button[] GameButtons { get; set; }
        /// <summary>
        /// Starts the music.
        /// Intialize the game and the buttons!
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            PlayBackgroundMusic();
            Game = new Game();
            GameButtons = new Button[9];
            int i = 8;
            foreach (Control c in pnlGameButtons.Controls)
            {
                if (c is Button)
                {
                    Button b = c as Button;
                    GameButtons[i--] = b; 
                }
            }
        }

        public void DisableMenuButtons()
        {
            btnPlayWithFriend.Enabled = false;
            btnPlayPC.Enabled = false;
            btnScoreboard.Enabled = false;
            btnExit.Enabled = false;
        }

        public void EnableMenuButtons()
        {
            btnPlayWithFriend.Enabled = true;
            btnPlayPC.Enabled = true;
            btnScoreboard.Enabled = true;
            btnExit.Enabled = true;
        }

        /// <summary>
        ///     Code for adding background music
        /// </summary>
        public void PlayBackgroundMusic()
        {
            SoundPlayer player = new
            SoundPlayer(Properties.Resources.background_music);
            player.PlayLooping();
        }


        /// <summary>
        ///     When clicking "Exit" the game should exit
        /// </summary>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        ///     Function to enable form to be movable without any form border
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        
        /// <summary>
        ///     Restarts the game and fields!
        /// </summary>
        private void ResetFields()
        {
            Game.ResetGame();
            ShowScore();
            foreach (Button b in GameButtons)
            {
                b.Text = "";
                b.Enabled = true;
                b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
        }

        /// <summary>
        ///     Disable fields on game end!
        /// </summary>
        private void DisableFields()
        {
            foreach (Button b in GameButtons)
            {
                b.Enabled = false;
            }
        }

        /// <summary>
        ///     Show updated scores!
        /// </summary>
        private void ShowScore()
        {
            lblPlayerName1.Text = Game.P1.Name;
            lblPlayerName2.Text = Game.P2.Name;
            lblPlayer1Score.Text = Game.P1.Wins.ToString();
            lblPlayer2Score.Text = Game.P2.Wins.ToString();
        }

        /// <summary>
        ///     Play with a friend actions!
        /// </summary>
        private void BtnPlayWithFriend_Click(object sender, EventArgs e)
        {
            PlayerNames form = new PlayerNames(Game.P1, Game.P2);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DisableMenuButtons();
                Game.P1 = new Player(form.player1Name);
                Game.P2 = new Player(form.player2Name);
                pnlGameWindow.Visible = true;
                pnlGameScore.Visible = true;
                ShowScore();
                ResetFields();
                Bot.botActive = false;

            }
            else
            {
                form.Close();
            }
        }

        /// <summary>
        ///     GamePlay exit button action!
        /// </summary>
        private void BtnExitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit this gameplay?", "Quit the gameplay!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!Bot.botActive)
                {
                    Scoreboard.AddStats(Game.P1);
                    Scoreboard.AddStats(Game.P2);
                }
                ResetFields();
                pnlGameWindow.Visible = false;
                EnableMenuButtons();
            }
        }

        /// <summary>
        ///     Game Reset button action!
        /// </summary>
        private void BtnResetRound_Click(object sender, EventArgs e)
        {
            ResetFields();
        }


        /// <summary>
        ///     GamePlay New Game button action depending on which one is active!
        /// </summary>
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to play a new game?", "Play a new game!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Bot.botActive)
                {
                    BtnPlayPC_Click(sender, e);
                } else
                {
                    BtnPlayWithFriend_Click(sender, e);
                    Scoreboard.AddStats(Game.P1);
                    Scoreboard.AddStats(Game.P2);
                }
            }
        }
        

        /// <summary>
        ///     It updates the clicked cell and marks it as played!
        /// </summary>
        private void Field_Click(object sender, EventArgs e)
        {
            // Field and Game Update start
            Button field = (Button) sender;
            int index = int.Parse(field.Name[5] + "") - 1;
            if (Game.Is1or0turn == true)
            {
                Game.Plays[index] = 1;
                field.Text = "1";
            }
            else
            {
                Game.Plays[index] = 0;
                field.Text = "0";
            }
            
            field.Enabled = false;
            Game.TurnsTaken++;
            // Field and Game Update end

            String result = WinCheck(index); // Check winner and disable fileds if end
            Game.Is1or0turn = !Game.Is1or0turn; // Change the turn to next player
            /*
             *  The next part is used to make imediately a bot move if the game didn't finished 
             *  with the last move of the player (depending on the selected mode at the begining).
             */
            if (Bot.botActive && result.Equals("None") && Game.TurnsTaken != 9)
            {
                index = Game.BotMove();
                GameButtons[index].Text = "0";
                GameButtons[index].Enabled = false;

                WinCheck(index);

                Game.Is1or0turn = !Game.Is1or0turn;
            }
        }
        /// <summary>
        ///     Determines the state of the game with the help of CheckWin function from 
        ///     the helper class WinnerCheck!
        /// </summary>
        /// <param name="index">The index of last clicked field</param>
        /// <returns>None if no one won and Win:win fields indexes if theres a win</returns>
        private String WinCheck(int index)
        {
            String result = WinnerCheck.CheckWin(Game.Plays, index, Game.Is1or0turn ? 1 : 0);
            if (result.StartsWith("Win"))
            {
                ColorWin(result.Substring(4));
                if (Game.Is1or0turn)
                {
                    EndMessage(Bot.botActive ? "User" : Game.P1.Name);
                    if (!Bot.botActive)
                    {
                        Game.P1.Wins++;
                        Game.P2.Looses++;
                    }
                }
                else
                {
                    EndMessage(Bot.botActive ? "Bot" : Game.P2.Name);
                    if (!Bot.botActive)
                    {
                        Game.P2.Wins++;
                        Game.P1.Looses++;
                    }
                }
                DisableFields();
                if (!Bot.botActive)
                    ShowScore();
            }
            else if (Game.TurnsTaken == 9) // If 9 moves are made then its a Draw
            {
                EndMessage("Draw");
                DisableFields();
            }
            return result;
        }

        /// <summary>
        ///     In case of win tis function helps to color the fields of the win!
        /// </summary>
        /// <param name="pattern">The field indexs seperated by comma.</param>
        private void ColorWin(String pattern)
        {
            String[] pieces = pattern.Split(',');
            for (int i = 0; i < 3; i++)
            {
                GameButtons[Convert.ToInt32(pieces[i])].BackColor = System.Drawing.Color.LimeGreen;
            }
        }

        /// <summary>
        ///     Shows a message box when the game ends.
        /// </summary>
        /// <param name="player">The name of the player who won or Draw in case of draw.</param>
        private void EndMessage(String player)
        {
            if (player.Equals("Draw"))
            {
                DialogResult = MessageBox.Show("The game ended in a draw!", "Draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!Bot.botActive)
                {
                    Game.P1.Draws++;
                    Game.P2.Draws++;
                }
            } else
            {
                MessageBox.Show("Congratulations! " + player + " wins!", "Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        /// <summary>
        ///     Opens a form to pick the difficulty of the bot!
        /// </summary>
        private void BtnPlayPC_Click(object sender, EventArgs e)
        {
            Difficulty form = new Difficulty();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DisableMenuButtons();
                pnlGameWindow.Visible = true;
                pnlGameScore.Visible = false;
                ResetFields();
                Bot.botActive = true;
                Bot.botDifficulty = form.diff;
            }
            else
            {
                form.Close();
            }
        }
        /// <summary>
        ///     Opens a form where the scoreboard of players will be shown!
        /// </summary>
        private void BtnScoreboard_Click(object sender, EventArgs e)
        {
            Score scoreboard = new Score();
            scoreboard.Show();
        }
        // Gets the base folder of the app
        private static string GetDataFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName.Replace("\\bin\\Debug", "\\data");
        }
        private void Save()
        {
            string currentFolder = GetDataFolder();
            if (!Directory.Exists(currentFolder))
            {
                Directory.CreateDirectory(currentFolder);
            }
            // path where the data should be saved
            string fileName = currentFolder + @"\scores.dat";
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, Scoreboard.listPlayer);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Save();
        }
        private void LoadData(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                Scoreboard.listPlayer = (List<Player>)formatter.Deserialize(fileStream);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = GetDataFolder() + @"\scores.dat";
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Hi");
                Save();
            }
            LoadData(fileName);
        }
    }
}
