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
    public partial class episodelinks : Form
    {
        public List<EpisodeForum> episodes;
        public episodelinks()
        {
            InitializeComponent();
        }
        public episodelinks(List<EpisodeForum> episodes)
        {
            InitializeComponent();
            this.episodes = episodes;
            episodeForumBindingSource.DataSource = episodes;
        }
        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            episodes = (List<EpisodeForum>)(episodeForumBindingSource.DataSource);
        }
    }
}
