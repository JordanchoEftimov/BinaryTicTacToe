using System;
using System.Windows.Forms;
using System.Media;

namespace BinaryTicTacToe
{
    public partial class Form1 : Form
    {
        bool is1or0turn = true;
        byte botDifficulty = 0;
        bool botActive = false;
        int turnsTaken = 0;
        int[] plays;
        Button[] gameButtons;
        public Form1()
        {
            InitializeComponent();
            playBackgroundMusic();
            plays = new int[9];
            gameButtons = new Button[9];
            int i = 8;
            foreach (Control c in pnlGameButtons.Controls)
            {
                if (c is Button)
                {
                    Button b = c as Button;
                    gameButtons[i--] = b; 
                }
            }
        }
        private void initializePlays()
        {
            for (int i = 0; i < 9; i++) {
                plays[i] = -1;
            }
        }
        //code for adding background music
        public void playBackgroundMusic()
        {
            SoundPlayer player = new
            SoundPlayer(Properties.Resources.background_music);
            player.PlayLooping();
        }

        //when clicking "Exit" the game should exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the game?", "Quit the game!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        //function to enable form to be movable without any form border
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
        // Field Reset
        private void resetFields()
        {
            initializePlays();
            foreach (Button b in gameButtons)
            {
                b.Text = "";
                b.Enabled = true;
                b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            }
        }
        // Field Disable
        private void disableFields()
        {
            foreach (Button b in gameButtons)
            {
                b.Enabled = false;
            }
        }
        // Play with a friend show
        private void btnPlayWithFriend_Click(object sender, EventArgs e)
        {
            PlayerNames form = new PlayerNames();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lblPlayerName1.Text = form.player1Name;
                lblPlayerName2.Text = form.player2Name;
                pnlGameWindow.Visible = true;
                pnlGameScore.Visible = true;
                resetFields();
                lblPlayer1Score.Text = "0";
                lblPlayer2Score.Text = "0";
            }
            else
            {
                form.Close();
            }
        }
        // Close game Code
        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit this gameplay?", "Quit the gameplay!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                is1or0turn = true;
                resetFields();
                lblPlayer1Score.Text = "0";
                lblPlayer2Score.Text = "0";
                pnlGameWindow.Visible = false;
            }
        }


        //Reset Button game logic
        private void btnResetRound_Click(object sender, EventArgs e)
        {
            is1or0turn = true;
            turnsTaken = 0;
            resetFields();
        }

        // Start new game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to play a new game?", "Play a new game!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PlayerNames form = new PlayerNames();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    lblPlayerName1.Text = form.player1Name;
                    lblPlayerName2.Text = form.player2Name;
                    is1or0turn = true;
                    turnsTaken = 0;
                    resetFields();
                    lblPlayer1Score.Text = "0";
                    lblPlayer2Score.Text = "0";
                }
                else
                {
                    form.Close();
                }
            }
        }

        private void field_Click(object sender, EventArgs e)
        {
            Button field = (Button)sender;
            int index = int.Parse(field.Name[5] + "") - 1;
            if (is1or0turn == true)
            {
                plays[index] = 1;
                field.Text = "1";
            }
            else
            {
                plays[index] = 0;
                field.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field.Enabled = false;
            turnsTaken++;
            if (checkWinner().Equals("none") && botActive)
            {
                int ind = -1;
                switch(botDifficulty)
                {
                    case 0: ind = easyMove();
                        break;
                    case 1: ind = mediumMove();
                        break;
                    case 2: ind = hardMove();
                        break;
                }
                plays[ind] = 0;
                gameButtons[ind].Enabled = false;
                gameButtons[ind].Text = "0";
                turnsTaken++;
                is1or0turn = !is1or0turn;
                checkWinner();
            }
        }
        // Winner Check
        private string checkWinner()
        {
            string winner = "none";
            if (field1.Text == field2.Text && field2.Text == field3.Text && !field1.Enabled)
            {
                winner = field1.Text;
                field1.BackColor = System.Drawing.Color.LimeGreen;
                field2.BackColor = System.Drawing.Color.LimeGreen;
                field3.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field4.Text == field5.Text && field5.Text == field6.Text && !field6.Enabled)
            {
                winner = field4.Text;
                field4.BackColor = System.Drawing.Color.LimeGreen;
                field5.BackColor = System.Drawing.Color.LimeGreen;
                field6.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field7.Text == field8.Text && field8.Text == field9.Text && !field9.Enabled)
            {
                winner = field7.Text;
                field7.BackColor = System.Drawing.Color.LimeGreen;
                field8.BackColor = System.Drawing.Color.LimeGreen;
                field9.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field1.Text == field4.Text && field4.Text == field7.Text && !field7.Enabled)
            {
                winner = field1.Text;
                field1.BackColor = System.Drawing.Color.LimeGreen;
                field4.BackColor = System.Drawing.Color.LimeGreen;
                field7.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field2.Text == field5.Text && field5.Text == field8.Text && !field8.Enabled)
            {
                winner = field2.Text;
                field2.BackColor = System.Drawing.Color.LimeGreen;
                field5.BackColor = System.Drawing.Color.LimeGreen;
                field8.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field3.Text == field6.Text && field6.Text == field9.Text && !field9.Enabled)
            {
                winner = field3.Text;
                field3.BackColor = System.Drawing.Color.LimeGreen;
                field6.BackColor = System.Drawing.Color.LimeGreen;
                field9.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field1.Text == field5.Text && field5.Text == field9.Text && !field1.Enabled)
            {
                winner = field1.Text;
                field1.BackColor = System.Drawing.Color.LimeGreen;
                field5.BackColor = System.Drawing.Color.LimeGreen;
                field9.BackColor = System.Drawing.Color.LimeGreen;
            }
            else if (field3.Text == field5.Text && field5.Text == field7.Text && !field3.Enabled)
            {
                winner = field3.Text;
                field3.BackColor = System.Drawing.Color.LimeGreen;
                field5.BackColor = System.Drawing.Color.LimeGreen;
                field7.BackColor = System.Drawing.Color.LimeGreen;
            }
            if (!winner.Equals("none"))
            {
                string player = "";
                disableFields();
                if (winner == "1")
                    player = lblPlayerName1.Text;
                else
                    player = lblPlayerName2.Text;
                MessageBox.Show("Congratulations! " + player + " wins!", "Win!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                turnsTaken = 0;
                if (winner == "1")
                {
                    int score = Int32.Parse(lblPlayer1Score.Text);
                    score++;
                    lblPlayer1Score.Text = score.ToString();
                }
                else
                {
                    int score = Int32.Parse(lblPlayer2Score.Text);
                    score++;
                    lblPlayer2Score.Text = score.ToString();
                }
            }
            if (turnsTaken == 9)
            {
                MessageBox.Show("The game ended in a draw!", "Draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                winner = "draw";
                turnsTaken = 0;
            }
            return winner;
        }




        // Bot Section
        private int easyMove()
        {
            Random rand = new Random();
            while (true)
            {
                int ind = rand.Next(9);
                if (plays[ind] == -1)
                {
                    return ind;
                }
            }
        }
        private int mediumMove()
        {
            for (int i = 0; i < 9; i++)
            {
                if (plays[i] == -1)
                {
                    if (checkWinner().Equals("none"))
                    {
                        plays[i] = -1;
                    } else
                    {
                        plays[i] = -1;
                        return i;
                    }
                }
            }
            return easyMove();
        }
        private int hardMove()
        {
            // MinMax Algorithm

            return 0;
        }
        private void btnPlayPC_Click(object sender, EventArgs e)
        {
            Difficulty form = new Difficulty();
            if (form.ShowDialog() == DialogResult.OK)
            {
                pnlGameWindow.Visible = true;
                pnlGameScore.Visible = false;
                resetFields();
                botDifficulty = form.diff;
                botActive = true;
            }
            else
            {
                form.Close();
            }
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            
        }


    }
}
