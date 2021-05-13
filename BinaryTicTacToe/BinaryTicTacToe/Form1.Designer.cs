
namespace BinaryTicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlayWithFriend = new System.Windows.Forms.Button();
            this.btnPlayPC = new System.Windows.Forms.Button();
            this.btnScoreboard = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.loginScreen = new System.Windows.Forms.Panel();
            this.pnlGameWindow = new System.Windows.Forms.Panel();
            this.pnlGameOptions = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnResetRound = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.pnlGameButtons = new System.Windows.Forms.Panel();
            this.field9 = new System.Windows.Forms.Button();
            this.field8 = new System.Windows.Forms.Button();
            this.field7 = new System.Windows.Forms.Button();
            this.field6 = new System.Windows.Forms.Button();
            this.field5 = new System.Windows.Forms.Button();
            this.field4 = new System.Windows.Forms.Button();
            this.field3 = new System.Windows.Forms.Button();
            this.field2 = new System.Windows.Forms.Button();
            this.field1 = new System.Windows.Forms.Button();
            this.pnlGameScore = new System.Windows.Forms.Panel();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayerName2 = new System.Windows.Forms.Label();
            this.lblPlayerName1 = new System.Windows.Forms.Label();
            this.loginScreen.SuspendLayout();
            this.pnlGameWindow.SuspendLayout();
            this.pnlGameOptions.SuspendLayout();
            this.pnlGameButtons.SuspendLayout();
            this.pnlGameScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayWithFriend
            // 
            this.btnPlayWithFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlayWithFriend.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayWithFriend.Location = new System.Drawing.Point(87, 313);
            this.btnPlayWithFriend.Name = "btnPlayWithFriend";
            this.btnPlayWithFriend.Size = new System.Drawing.Size(256, 55);
            this.btnPlayWithFriend.TabIndex = 100;
            this.btnPlayWithFriend.TabStop = false;
            this.btnPlayWithFriend.Text = "Play with a friend";
            this.btnPlayWithFriend.UseVisualStyleBackColor = false;
            this.btnPlayWithFriend.Click += new System.EventHandler(this.btnPlayWithFriend_Click);
            // 
            // btnPlayPC
            // 
            this.btnPlayPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlayPC.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPC.Location = new System.Drawing.Point(87, 422);
            this.btnPlayPC.Name = "btnPlayPC";
            this.btnPlayPC.Size = new System.Drawing.Size(256, 55);
            this.btnPlayPC.TabIndex = 100;
            this.btnPlayPC.TabStop = false;
            this.btnPlayPC.Text = "Play with a bot";
            this.btnPlayPC.UseVisualStyleBackColor = false;
            // 
            // btnScoreboard
            // 
            this.btnScoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnScoreboard.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreboard.Location = new System.Drawing.Point(87, 536);
            this.btnScoreboard.Name = "btnScoreboard";
            this.btnScoreboard.Size = new System.Drawing.Size(256, 55);
            this.btnScoreboard.TabIndex = 100;
            this.btnScoreboard.TabStop = false;
            this.btnScoreboard.Text = "Scoreboard";
            this.btnScoreboard.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(87, 655);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(256, 55);
            this.btnExit.TabIndex = 100;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.BackgroundImage = global::BinaryTicTacToe.Properties.Resources.title;
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTitle.Location = new System.Drawing.Point(206, 71);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(807, 94);
            this.pnlTitle.TabIndex = 4;
            // 
            // loginScreen
            // 
            this.loginScreen.BackColor = System.Drawing.Color.Transparent;
            this.loginScreen.Controls.Add(this.pnlGameWindow);
            this.loginScreen.Controls.Add(this.pnlTitle);
            this.loginScreen.Controls.Add(this.btnExit);
            this.loginScreen.Controls.Add(this.btnScoreboard);
            this.loginScreen.Controls.Add(this.btnPlayPC);
            this.loginScreen.Controls.Add(this.btnPlayWithFriend);
            this.loginScreen.Location = new System.Drawing.Point(-3, 51);
            this.loginScreen.Margin = new System.Windows.Forms.Padding(4);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(2670, 1210);
            this.loginScreen.TabIndex = 0;
            // 
            // pnlGameWindow
            // 
            this.pnlGameWindow.Controls.Add(this.pnlGameOptions);
            this.pnlGameWindow.Controls.Add(this.pnlGameButtons);
            this.pnlGameWindow.Controls.Add(this.pnlGameScore);
            this.pnlGameWindow.Location = new System.Drawing.Point(494, 186);
            this.pnlGameWindow.Name = "pnlGameWindow";
            this.pnlGameWindow.Size = new System.Drawing.Size(748, 547);
            this.pnlGameWindow.TabIndex = 5;
            this.pnlGameWindow.Visible = false;
            // 
            // pnlGameOptions
            // 
            this.pnlGameOptions.Controls.Add(this.btnNewGame);
            this.pnlGameOptions.Controls.Add(this.btnResetRound);
            this.pnlGameOptions.Controls.Add(this.btnExitGame);
            this.pnlGameOptions.Location = new System.Drawing.Point(538, 103);
            this.pnlGameOptions.Name = "pnlGameOptions";
            this.pnlGameOptions.Size = new System.Drawing.Size(207, 441);
            this.pnlGameOptions.TabIndex = 2;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(16, 122);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(165, 46);
            this.btnNewGame.TabIndex = 103;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnResetRound
            // 
            this.btnResetRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResetRound.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetRound.Location = new System.Drawing.Point(16, 197);
            this.btnResetRound.Name = "btnResetRound";
            this.btnResetRound.Size = new System.Drawing.Size(165, 46);
            this.btnResetRound.TabIndex = 102;
            this.btnResetRound.TabStop = false;
            this.btnResetRound.Text = "Reset";
            this.btnResetRound.UseVisualStyleBackColor = false;
            this.btnResetRound.Click += new System.EventHandler(this.btnResetRound_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExitGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(16, 269);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(167, 46);
            this.btnExitGame.TabIndex = 101;
            this.btnExitGame.TabStop = false;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // pnlGameButtons
            // 
            this.pnlGameButtons.Controls.Add(this.field9);
            this.pnlGameButtons.Controls.Add(this.field8);
            this.pnlGameButtons.Controls.Add(this.field7);
            this.pnlGameButtons.Controls.Add(this.field6);
            this.pnlGameButtons.Controls.Add(this.field5);
            this.pnlGameButtons.Controls.Add(this.field4);
            this.pnlGameButtons.Controls.Add(this.field3);
            this.pnlGameButtons.Controls.Add(this.field2);
            this.pnlGameButtons.Controls.Add(this.field1);
            this.pnlGameButtons.Location = new System.Drawing.Point(3, 103);
            this.pnlGameButtons.Name = "pnlGameButtons";
            this.pnlGameButtons.Size = new System.Drawing.Size(529, 441);
            this.pnlGameButtons.TabIndex = 1;
            // 
            // field9
            // 
            this.field9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field9.Location = new System.Drawing.Point(367, 308);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(140, 130);
            this.field9.TabIndex = 100;
            this.field9.TabStop = false;
            this.field9.UseVisualStyleBackColor = false;
            this.field9.Click += new System.EventHandler(this.field_Click);
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field8.Location = new System.Drawing.Point(189, 308);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(140, 130);
            this.field8.TabIndex = 100;
            this.field8.TabStop = false;
            this.field8.UseVisualStyleBackColor = false;
            this.field8.Click += new System.EventHandler(this.field_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field7.Location = new System.Drawing.Point(12, 308);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(140, 130);
            this.field7.TabIndex = 100;
            this.field7.TabStop = false;
            this.field7.UseVisualStyleBackColor = false;
            this.field7.Click += new System.EventHandler(this.field_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field6.Location = new System.Drawing.Point(367, 161);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(140, 130);
            this.field6.TabIndex = 100;
            this.field6.TabStop = false;
            this.field6.UseVisualStyleBackColor = false;
            this.field6.Click += new System.EventHandler(this.field_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field5.Location = new System.Drawing.Point(189, 161);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(140, 130);
            this.field5.TabIndex = 100;
            this.field5.TabStop = false;
            this.field5.UseVisualStyleBackColor = false;
            this.field5.Click += new System.EventHandler(this.field_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field4.Location = new System.Drawing.Point(12, 161);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(140, 130);
            this.field4.TabIndex = 100;
            this.field4.TabStop = false;
            this.field4.UseVisualStyleBackColor = false;
            this.field4.Click += new System.EventHandler(this.field_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field3.Location = new System.Drawing.Point(367, 19);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(140, 130);
            this.field3.TabIndex = 100;
            this.field3.TabStop = false;
            this.field3.UseVisualStyleBackColor = false;
            this.field3.Click += new System.EventHandler(this.field_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field2.Location = new System.Drawing.Point(189, 19);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(140, 130);
            this.field2.TabIndex = 100;
            this.field2.TabStop = false;
            this.field2.UseVisualStyleBackColor = false;
            this.field2.Click += new System.EventHandler(this.field_Click);
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field1.Location = new System.Drawing.Point(12, 19);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(140, 130);
            this.field1.TabIndex = 100;
            this.field1.TabStop = false;
            this.field1.UseVisualStyleBackColor = false;
            this.field1.Click += new System.EventHandler(this.field_Click);
            // 
            // pnlGameScore
            // 
            this.pnlGameScore.Controls.Add(this.lblPlayer2Score);
            this.pnlGameScore.Controls.Add(this.lblPlayer1Score);
            this.pnlGameScore.Controls.Add(this.lblPlayerName2);
            this.pnlGameScore.Controls.Add(this.lblPlayerName1);
            this.pnlGameScore.Location = new System.Drawing.Point(3, 3);
            this.pnlGameScore.Name = "pnlGameScore";
            this.pnlGameScore.Size = new System.Drawing.Size(742, 94);
            this.pnlGameScore.TabIndex = 0;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayer2Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.Location = new System.Drawing.Point(420, 33);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(80, 39);
            this.lblPlayer2Score.TabIndex = 3;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayer1Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(311, 33);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(80, 39);
            this.lblPlayer1Score.TabIndex = 2;
            this.lblPlayer1Score.Text = "0";
            this.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName2
            // 
            this.lblPlayerName2.AutoSize = true;
            this.lblPlayerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayerName2.Location = new System.Drawing.Point(506, 33);
            this.lblPlayerName2.Name = "lblPlayerName2";
            this.lblPlayerName2.Size = new System.Drawing.Size(233, 39);
            this.lblPlayerName2.TabIndex = 1;
            this.lblPlayerName2.Text = "PlayerName 2";
            // 
            // lblPlayerName1
            // 
            this.lblPlayerName1.AutoSize = true;
            this.lblPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayerName1.Location = new System.Drawing.Point(59, 33);
            this.lblPlayerName1.Name = "lblPlayerName1";
            this.lblPlayerName1.Size = new System.Drawing.Size(233, 39);
            this.lblPlayerName1.TabIndex = 0;
            this.lblPlayerName1.Text = "PlayerName 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BinaryTicTacToe.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1262, 863);
            this.Controls.Add(this.loginScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BinaryTicTacToe";
            this.loginScreen.ResumeLayout(false);
            this.pnlGameWindow.ResumeLayout(false);
            this.pnlGameOptions.ResumeLayout(false);
            this.pnlGameButtons.ResumeLayout(false);
            this.pnlGameScore.ResumeLayout(false);
            this.pnlGameScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayWithFriend;
        private System.Windows.Forms.Button btnPlayPC;
        private System.Windows.Forms.Button btnScoreboard;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel loginScreen;
        private System.Windows.Forms.Panel pnlGameWindow;
        private System.Windows.Forms.Panel pnlGameOptions;
        private System.Windows.Forms.Panel pnlGameButtons;
        private System.Windows.Forms.Button field9;
        private System.Windows.Forms.Button field8;
        private System.Windows.Forms.Button field7;
        private System.Windows.Forms.Button field6;
        private System.Windows.Forms.Button field5;
        private System.Windows.Forms.Button field4;
        private System.Windows.Forms.Button field3;
        private System.Windows.Forms.Button field2;
        private System.Windows.Forms.Button field1;
        private System.Windows.Forms.Panel pnlGameScore;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnResetRound;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayerName2;
        private System.Windows.Forms.Label lblPlayerName1;
    }
}

