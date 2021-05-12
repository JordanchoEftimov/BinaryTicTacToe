using System;
using System.Windows.Forms;
using System.Media;

namespace BinaryTicTacToe
{
    public partial class Form1 : Form
    {
        bool is1or0turn = true;
        int player1 = 0;
        int player2 = 0;

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
            {
                this.Close();
            }
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

        private void field1_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field1.Text = "1";
            }
            else
            {
                field1.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field1.Enabled = false;
        }

        private void field2_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field2.Text = "1";
            }
            else
            {
                field2.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field2.Enabled = false;
        }

        private void field3_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field3.Text = "1";
            }
            else
            {
                field3.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field3.Enabled = false;
        }

        private void field4_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field4.Text = "1";
            }
            else
            {
                field4.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field4.Enabled = false;
        }

        private void field5_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field5.Text = "1";
            }
            else
            {
                field5.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field5.Enabled = false;
        }

        private void field6_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field6.Text = "1";
            }
            else
            {
                field6.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field6.Enabled = false;
        }

        private void field7_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field7.Text = "1";
            }
            else
            {
                field7.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field7.Enabled = false;
        }

        private void field8_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field8.Text = "1";
            }
            else
            {
                field8.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field8.Enabled = false;
        }

        private void field9_Click(object sender, EventArgs e)
        {
            if (is1or0turn == true)
            {
                field9.Text = "1";
            }
            else
            {
                field9.Text = "0";
            }
            is1or0turn = !is1or0turn;
            field9.Enabled = false;
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
                player1 = 0;
                player2 = 0;
                lblPlayer1Score.Text = "0";
                lblPlayer2Score.Text = "0";
            }
        }
    }
}
