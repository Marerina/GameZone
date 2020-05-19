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
    
    public partial class Настройки : Form
    {
        Params par;
        public bool cancel = true;
        public Params ParamsForum { get { return par; } set { par = value; } }
        public Настройки()
        {
            InitializeComponent();
            ParamsForum = new Params();
        }
        public Настройки(Params p)
        {
            InitializeComponent();
            ParamsForum = p;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Настройки_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = ParamsForum.MinLogins;
            numericUpDown2.Value = ParamsForum.WritePosts;
            numericUpDown3.Value = ParamsForum.MinPostLength;
            numericUpDown4.Value = ParamsForum.RoleReverve;
            numericUpDown5.Value = ParamsForum.QuestionnaireMinDate;
            numericUpDown6.Value = ParamsForum.QuestionnaireEdit;
            numericUpDown7.Value = ParamsForum.FirstPost;
            textBox1.Text = ParamsForum.ForumName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParamsForum.MinLogins = (int)numericUpDown1.Value;
            ParamsForum.WritePosts = (int)numericUpDown2.Value;
            ParamsForum.MinPostLength = (int)numericUpDown3.Value;
            ParamsForum.RoleReverve = (int)numericUpDown4.Value;
            ParamsForum.QuestionnaireMinDate = (int)numericUpDown5.Value;
            ParamsForum.QuestionnaireEdit = (int)numericUpDown6.Value;
            ParamsForum.FirstPost = (int)numericUpDown7.Value;
            ParamsForum.ForumName = textBox1.Text;
            cancel = false;
            this.Close();
        }
    }
    public class Params
    {
        int login = 14;
        int writeposts = 30;
        int minpostLength = 1000;
        int roleReserve = 3;
        int questionnaireEdit = 5;
        int questionnaiteMinDate = 3;
        int firstPost = 7;
        string forumname = @"http://dgmwin.rusff.ru/";
        public int MinLogins { get { return login; } set { login = value; } }
        public int WritePosts { get { return writeposts; } set { writeposts = value; } }
        public int MinPostLength { get { return minpostLength; } set { minpostLength = value; } }
        public int RoleReverve { get { return roleReserve; } set { roleReserve = value; } }
        public int QuestionnaireEdit { get { return questionnaireEdit; } set { questionnaireEdit = value; } }
        public int QuestionnaireMinDate { get { return questionnaiteMinDate; } set { questionnaiteMinDate = value; } }
        public int FirstPost { get { return firstPost; } set { firstPost = value; } }
        public string ForumName { get { return forumname; } set { forumname = value; } }
        public Params(int login, int writeposts, int minpostLength, int rolereserve, int questionnaireEdit, int questionnaiteMinDate, 
            int firstPost, string forumname)
        {
            MinLogins = login;
            WritePosts = writeposts;
            MinPostLength = minpostLength;
            RoleReverve = rolereserve;
            QuestionnaireEdit = questionnaireEdit;
            QuestionnaireMinDate = questionnaiteMinDate;
            FirstPost = firstPost;
            ForumName = forumname;
        }
        public Params() { }
        public Params(string forumname)
        {
            ForumName = forumname;
        }
    }
}
