
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
            this.loginScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Quit = new System.Windows.Forms.Button();
            this.playWithComputer = new System.Windows.Forms.Button();
            this.playWithFriend = new System.Windows.Forms.Button();
            this.loginScreen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginScreen
            // 
            this.loginScreen.BackColor = System.Drawing.Color.Wheat;
            this.loginScreen.Controls.Add(this.panel1);
            this.loginScreen.Location = new System.Drawing.Point(0, 1);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(2000, 1024);
            this.loginScreen.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.playWithComputer);
            this.panel1.Controls.Add(this.playWithFriend);
            this.panel1.Location = new System.Drawing.Point(160, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 288);
            this.panel1.TabIndex = 0;
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.LightBlue;
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(65, 204);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(318, 65);
            this.Quit.TabIndex = 8;
            this.Quit.Text = "Затвори игра";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // playWithComputer
            // 
            this.playWithComputer.BackColor = System.Drawing.Color.LightBlue;
            this.playWithComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playWithComputer.Location = new System.Drawing.Point(65, 115);
            this.playWithComputer.Name = "playWithComputer";
            this.playWithComputer.Size = new System.Drawing.Size(318, 65);
            this.playWithComputer.TabIndex = 7;
            this.playWithComputer.Text = "Играј со компјутер";
            this.playWithComputer.UseVisualStyleBackColor = false;
            // 
            // playWithFriend
            // 
            this.playWithFriend.BackColor = System.Drawing.Color.LightBlue;
            this.playWithFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playWithFriend.Location = new System.Drawing.Point(65, 26);
            this.playWithFriend.Name = "playWithFriend";
            this.playWithFriend.Size = new System.Drawing.Size(318, 65);
            this.playWithFriend.TabIndex = 6;
            this.playWithFriend.Text = "Играј со пријател";
            this.playWithFriend.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.loginScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.loginScreen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button playWithComputer;
        private System.Windows.Forms.Button playWithFriend;
    }
}

