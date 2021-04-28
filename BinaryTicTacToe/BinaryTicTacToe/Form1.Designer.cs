
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
            this.loginScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScoreboard = new System.Windows.Forms.Button();
            this.btnPlayPC = new System.Windows.Forms.Button();
            this.btnPlayWithFriend = new System.Windows.Forms.Button();
            this.loginScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginScreen
            // 
            this.loginScreen.BackColor = System.Drawing.Color.Transparent;
            this.loginScreen.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BinaryTicTacToe.Properties.Resources.title;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(206, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 94);
            this.panel1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(87, 655);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(256, 55);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScoreboard
            // 
            this.btnScoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnScoreboard.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScoreboard.Location = new System.Drawing.Point(87, 536);
            this.btnScoreboard.Name = "btnScoreboard";
            this.btnScoreboard.Size = new System.Drawing.Size(256, 55);
            this.btnScoreboard.TabIndex = 2;
            this.btnScoreboard.Text = "Scoreboard";
            this.btnScoreboard.UseVisualStyleBackColor = false;
            // 
            // btnPlayPC
            // 
            this.btnPlayPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlayPC.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPC.Location = new System.Drawing.Point(87, 422);
            this.btnPlayPC.Name = "btnPlayPC";
            this.btnPlayPC.Size = new System.Drawing.Size(256, 55);
            this.btnPlayPC.TabIndex = 1;
            this.btnPlayPC.Text = "Play with a bot";
            this.btnPlayPC.UseVisualStyleBackColor = false;
            // 
            // btnPlayWithFriend
            // 
            this.btnPlayWithFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPlayWithFriend.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayWithFriend.Location = new System.Drawing.Point(87, 313);
            this.btnPlayWithFriend.Name = "btnPlayWithFriend";
            this.btnPlayWithFriend.Size = new System.Drawing.Size(256, 55);
            this.btnPlayWithFriend.TabIndex = 0;
            this.btnPlayWithFriend.Text = "Play with a friend";
            this.btnPlayWithFriend.UseVisualStyleBackColor = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginScreen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScoreboard;
        private System.Windows.Forms.Button btnPlayPC;
        private System.Windows.Forms.Button btnPlayWithFriend;
        private System.Windows.Forms.Panel panel1;
    }
}

