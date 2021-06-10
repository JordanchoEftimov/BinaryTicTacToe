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
    public partial class Score : Form
    {
        public static int TotalRecords { get; set; }
        private const int pageSize = 10;
        public Score()
        {
            InitializeComponent();
            TotalRecords = Scoreboard.listPlayer.Count;
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(BindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)bindingSource1.Current;
            List<Player> players = new List<Player>();
            for (int i = offset; i < offset + pageSize && i < TotalRecords; i++)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                Player p = Scoreboard.listPlayer[i];
                row.Cells["Place"].Value = i + 1;
                row.Cells["PName"].Value = p.Name;
                row.Cells["Wins"].Value = p.Wins;
                row.Cells["Draws"].Value = p.Draws;
                row.Cells["Looses"].Value = p.Looses;
                row.Cells["Points"].Value = p.GetPoints();


            }
            //players.Add(Scoreboard.listPlayer[i]);
            //dataGridView1.DataSource = players;
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < TotalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }
        private void Score_Load(object sender, EventArgs e)
        {

        }
    }
}
