using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameZone
{
    public partial class Posts : Form
    {
        string forumname;
        public Posts(List<Episodes> epps, string forumn)
        {
            InitializeComponent();
            int i = 0;
            forumname = forumn;
            foreach(var item in epps)
            {
                dataGridView1.Rows.Add(new DataGridViewRow());
                dataGridView1.Rows[i].Cells[0].Value = item.TopicID;
                dataGridView1.Rows[i].Cells[1].Value = item.EpisodeName;
                dataGridView1.Rows[i].Cells[2].Value = item.Status.ToString();
                i++;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            richTextBox1.Text = forumname + "viewtopic.php?id=" + dataGridView1.Rows[(e).RowIndex].Cells[0].Value;


        }
    }
}
