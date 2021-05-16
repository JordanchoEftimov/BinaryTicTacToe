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
    public partial class Difficulty : Form
    {
        public byte diff { get; set; }
        public Difficulty()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back?", "Back to homepage!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            diff = 0;
            DialogResult = DialogResult.OK;
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            diff = 1;
            DialogResult = DialogResult.OK;
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            diff = 2;
            DialogResult = DialogResult.OK;
        }
    }
}
