using System;
using System.Windows.Forms;
using System.Media;

namespace BinaryTicTacToe
{
    public partial class Form1 : Form
    {
        bool is1or0turn = true;
        int turnsTaken = 0;
        public Form1()
        {
            InitializeComponent();
            playBackgroundMusic();
        }

        //code for adding background music
        public void playBackgroundMusic()
        {
            SoundPlayer player = new
            SoundPlayer(BinaryTicTacToe.Properties.Resources.background_music);
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

        private void resetFields()
        {
            field1.Text = "";
            field1.Enabled = true;
            field2.Text = "";
            field2.Enabled = true;
            field3.Text = "";
            field3.Enabled = true;
            field4.Text = "";
            field4.Enabled = true;
            field5.Text = "";
            field5.Enabled = true;
            field6.Text = "";
            field6.Enabled = true;
            field7.Text = "";
            field7.Enabled = true;
            field8.Text = "";
            field8.Enabled = true;
            field9.Text = "";
            field9.Enabled = true;
        }

        private void disableFields()
        {
            field1.Enabled = false;
            field2.Enabled = false;
            field3.Enabled = false;
            field4.Enabled = false;
            field5.Enabled = false;
            field6.Enabled = false;
            field7.Enabled = false;
            field8.Enabled = false;
            field9.Enabled = false;
        }

        private void btnPlayWithFriend_Click(object sender, EventArgs e)
        {
            pnlGameWindow.Visible = true;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit this gameplay?", "Quit the gameplay!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                is1or0turn = true;
                resetFields();
                pnlGameWindow.Visible = false;
            }
        }

        private void btnResetRound_Click(object sender, EventArgs e)
        {
            is1or0turn = true;
            resetFields();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to play a new game?", "Play a new game!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                is1or0turn = true;
                resetFields();
                lblPlayer1Score.Text = "0";
                lblPlayer2Score.Text = "0";
            }
        }

        private void field_Click(object sender, EventArgs e)
        {
            Button field = (Button)sender;
            if (is1or0turn == true)
                field.Text = "1";
            else
                field.Text = "0";
            is1or0turn = !is1or0turn;
            field.Enabled = false;
            turnsTaken++;
            checkWinner();
        }

        private void checkWinner()
        {
            string winner = "none";
            if (field1.Text == field2.Text && field2.Text == field3.Text && !field1.Enabled)
                winner = field1.Text;
            else if (field4.Text == field5.Text && field5.Text == field6.Text && !field6.Enabled)
                winner = field4.Text;
            else if (field7.Text == field8.Text && field8.Text == field9.Text && !field9.Enabled)
                winner = field7.Text;
            else if (field1.Text == field4.Text && field4.Text == field7.Text && !field7.Enabled)
                winner = field1.Text;
            else if (field2.Text == field5.Text && field5.Text == field8.Text && !field8.Enabled)
                winner = field2.Text;
            else if (field3.Text == field6.Text && field6.Text == field9.Text && !field9.Enabled)
                winner = field3.Text;
            else if (field1.Text == field5.Text && field5.Text == field9.Text && !field1.Enabled)
                winner = field1.Text;
            else if (field3.Text == field5.Text && field5.Text == field7.Text && !field3.Enabled)
                winner = field3.Text;
            if (!winner.Equals("none"))
            {
                disableFields();
                MessageBox.Show("Congratulations! Player " + winner + " wins!");
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
                MessageBox.Show("The game ended in a draw!");
                turnsTaken = 0;
            }
        }
    }
}
