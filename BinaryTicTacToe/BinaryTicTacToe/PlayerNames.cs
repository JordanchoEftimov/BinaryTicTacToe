using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTicTacToe
{
    public partial class PlayerNames : Form
    {
        public string player1Name;
        public string player2Name;
        public PlayerNames()
        {
            InitializeComponent();
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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Please insert your name in the following field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Please insert your name in the following field!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                player1Name = textBox1.Text;
                player2Name = textBox2.Text;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Please insert your name in the following fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
