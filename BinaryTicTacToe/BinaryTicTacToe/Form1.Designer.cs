
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
            this.btnPlayWithFriend.Location = new System.Drawing.Point(65, 254);
            this.btnPlayWithFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlayWithFriend.Name = "btnPlayWithFriend";
            this.btnPlayWithFriend.Size = new System.Drawing.Size(192, 45);
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
            this.btnPlayPC.Location = new System.Drawing.Point(65, 343);
            this.btnPlayPC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlayPC.Name = "btnPlayPC";
            this.btnPlayPC.Size = new System.Drawing.Size(192, 45);
            this.btnPlayPC.TabIndex = 100;
            this.btnPlayPC.TabStop = false;
            this.btnPlayPC.Text = "Play with a bot";
            this.btnPlayPC.UseVisualStyleBackColor = false;
            // 
            // btnScoreboard
            // 
            this.btnScoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnScoreboard.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreboard.Location = new System.Drawing.Point(65, 436);
            this.btnScoreboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScoreboard.Name = "btnScoreboard";
            this.btnScoreboard.Size = new System.Drawing.Size(192, 45);
            this.btnScoreboard.TabIndex = 100;
            this.btnScoreboard.TabStop = false;
            this.btnScoreboard.Text = "Scoreboard";
            this.btnScoreboard.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(65, 532);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 45);
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
            this.pnlTitle.Location = new System.Drawing.Point(154, 58);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(605, 76);
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
            this.loginScreen.Location = new System.Drawing.Point(-2, 41);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(2002, 983);
            this.loginScreen.TabIndex = 0;
            // 
            // pnlGameWindow
            // 
            this.pnlGameWindow.Controls.Add(this.pnlGameOptions);
            this.pnlGameWindow.Controls.Add(this.pnlGameButtons);
            this.pnlGameWindow.Controls.Add(this.pnlGameScore);
            this.pnlGameWindow.Location = new System.Drawing.Point(370, 151);
            this.pnlGameWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGameWindow.Name = "pnlGameWindow";
            this.pnlGameWindow.Size = new System.Drawing.Size(561, 444);
            this.pnlGameWindow.TabIndex = 5;
            this.pnlGameWindow.Visible = false;
            // 
            // pnlGameOptions
            // 
            this.pnlGameOptions.Controls.Add(this.btnNewGame);
            this.pnlGameOptions.Controls.Add(this.btnResetRound);
            this.pnlGameOptions.Controls.Add(this.btnExitGame);
            this.pnlGameOptions.Location = new System.Drawing.Point(404, 84);
            this.pnlGameOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGameOptions.Name = "pnlGameOptions";
            this.pnlGameOptions.Size = new System.Drawing.Size(155, 358);
            this.pnlGameOptions.TabIndex = 2;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(12, 99);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(124, 37);
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
            this.btnResetRound.Location = new System.Drawing.Point(12, 160);
            this.btnResetRound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetRound.Name = "btnResetRound";
            this.btnResetRound.Size = new System.Drawing.Size(124, 37);
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
            this.btnExitGame.Location = new System.Drawing.Point(12, 219);
            this.btnExitGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(125, 37);
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
            this.pnlGameButtons.Location = new System.Drawing.Point(2, 84);
            this.pnlGameButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGameButtons.Name = "pnlGameButtons";
            this.pnlGameButtons.Size = new System.Drawing.Size(397, 358);
            this.pnlGameButtons.TabIndex = 1;
            // 
            // field9
            // 
            this.field9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field9.Location = new System.Drawing.Point(275, 250);
            this.field9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(105, 106);
            this.field9.TabIndex = 100;
            this.field9.TabStop = false;
            this.field9.UseVisualStyleBackColor = false;
            this.field9.Click += new System.EventHandler(this.field_Click);
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field8.Location = new System.Drawing.Point(142, 250);
            this.field8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(105, 106);
            this.field8.TabIndex = 100;
            this.field8.TabStop = false;
            this.field8.UseVisualStyleBackColor = false;
            this.field8.Click += new System.EventHandler(this.field_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field7.Location = new System.Drawing.Point(9, 250);
            this.field7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(105, 106);
            this.field7.TabIndex = 100;
            this.field7.TabStop = false;
            this.field7.UseVisualStyleBackColor = false;
            this.field7.Click += new System.EventHandler(this.field_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field6.Location = new System.Drawing.Point(275, 131);
            this.field6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(105, 106);
            this.field6.TabIndex = 100;
            this.field6.TabStop = false;
            this.field6.UseVisualStyleBackColor = false;
            this.field6.Click += new System.EventHandler(this.field_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field5.Location = new System.Drawing.Point(142, 131);
            this.field5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(105, 106);
            this.field5.TabIndex = 100;
            this.field5.TabStop = false;
            this.field5.UseVisualStyleBackColor = false;
            this.field5.Click += new System.EventHandler(this.field_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field4.Location = new System.Drawing.Point(9, 131);
            this.field4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(105, 106);
            this.field4.TabIndex = 100;
            this.field4.TabStop = false;
            this.field4.UseVisualStyleBackColor = false;
            this.field4.Click += new System.EventHandler(this.field_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field3.Location = new System.Drawing.Point(275, 15);
            this.field3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(105, 106);
            this.field3.TabIndex = 100;
            this.field3.TabStop = false;
            this.field3.UseVisualStyleBackColor = false;
            this.field3.Click += new System.EventHandler(this.field_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field2.Location = new System.Drawing.Point(142, 15);
            this.field2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(105, 106);
            this.field2.TabIndex = 100;
            this.field2.TabStop = false;
            this.field2.UseVisualStyleBackColor = false;
            this.field2.Click += new System.EventHandler(this.field_Click);
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.field1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field1.Location = new System.Drawing.Point(9, 15);
            this.field1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(105, 106);
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
            this.pnlGameScore.Location = new System.Drawing.Point(2, 2);
            this.pnlGameScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGameScore.Name = "pnlGameScore";
            this.pnlGameScore.Size = new System.Drawing.Size(556, 76);
            this.pnlGameScore.TabIndex = 0;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayer2Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.Location = new System.Drawing.Point(315, 27);
            this.lblPlayer2Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(60, 32);
            this.lblPlayer2Score.TabIndex = 3;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayer1Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(233, 27);
            this.lblPlayer1Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(60, 32);
            this.lblPlayer1Score.TabIndex = 2;
            this.lblPlayer1Score.Text = "0";
            this.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName2
            // 
            this.lblPlayerName2.AutoSize = true;
            this.lblPlayerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayerName2.Location = new System.Drawing.Point(380, 27);
            this.lblPlayerName2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName2.Name = "lblPlayerName2";
            this.lblPlayerName2.Size = new System.Drawing.Size(29, 31);
            this.lblPlayerName2.TabIndex = 1;
            this.lblPlayerName2.Text = "2";
            this.lblPlayerName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayerName1
            // 
            this.lblPlayerName1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPlayerName1.Location = new System.Drawing.Point(38, 27);
            this.lblPlayerName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerName1.Name = "lblPlayerName1";
            this.lblPlayerName1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlayerName1.Size = new System.Drawing.Size(190, 32);
            this.lblPlayerName1.TabIndex = 0;
            this.lblPlayerName1.Text = "1";
            this.lblPlayerName1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BinaryTicTacToe.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(946, 640);
            this.Controls.Add(this.loginScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

