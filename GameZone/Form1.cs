using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;
using AngleSharp.Extensions;
using AngleSharp.Parser.Html;
using AngleSharp;
using System.IO;



namespace GameZone
{
    public partial class Form1 : Form
    {
        static string getResponse(string uri)
        {
            //HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
            //request.Method = "POST";
            //request.ContentLength = 0;
            //var requestStream = request.GetRequestStream();
            //HttpWebResponse res = (HttpWebResponse)request.GetResponse();
            //res.Close();

            int a = 0, b=2;
            switch(a)
            {
                case (0): { if (b == 2) a = 5; break; }
            }

                StringBuilder sb = new StringBuilder();
                
                byte[] buf = new byte[8192];
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
                req.Method = "Post";
            
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream resStream = res.GetResponseStream();
                int count = 0;
                do
                {
                    count = resStream.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        sb.Append(Encoding.Default.GetString(buf, 0, count));
                    }
                }
                while (count > 0);
                resStream.Close();
                return sb.ToString();
            

        }
        string forumname = @"http://withounshadows.mybb.ru/";// @"http://whateversword.rusff.ru/";   //@"http://dgmwin.rusff.ru/";
        static CookieContainer submitForm()
        {
            CookieContainer myCookies = new CookieContainer();
            WebProxy pr = null;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://dgmwin.rusff.ru");
            req.Method = "Post";
            req.CookieContainer = new CookieContainer();
            string postData = "Action=login&Name=" + "Janosz Weiss" + "&Password=" + "liebemeinebroter";
            byte[] arrPostDAta = Encoding.GetEncoding("windows-1251").GetBytes(postData);
            req.ContentLength = arrPostDAta.Length;
            Stream strmPostData = req.GetRequestStream();
            strmPostData.Write(arrPostDAta, 0, arrPostDAta.Length);
            strmPostData.Close();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            if (res.Cookies.Count == 0)
            {

            }

            foreach (Cookie c in res.Cookies)
            {
                myCookies.Add(c);
            }
            res.Close();
            return myCookies;
        }
        

        List<User> ParseUserlist()
        {
            var config = Configuration.Default.WithJavaScript().WithCss();
            var parser = new HtmlParser(config);
            if (p!= null)
            forumname = p.ForumName;
              string str = getResponse(forumname + @"userlist.php");
            var document = parser.Parse(str);
            progressBar1.Value = 5;
            var blueListItemsLinq = document.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("usertable"));
            string s = "";
            foreach (var item in blueListItemsLinq)
            {
                //  sw.WriteLine(item.Html());
                s += item.InnerHtml;
                //break;
            }
            var usrs = parser.Parse(s);
            var userlist = usrs.All.Where(m => m.LocalName == "span" && m.ClassList.Contains("usersname"));
            progressBar1.Value = 10;
            List<User> users = new List<User>();

            foreach (var item in userlist)
            {
                User user = new User();
                string Text = item.Html();
                int removes = forumname.Length + 24;
                Text = Text.Remove(0, removes);
                string index = "";
                int a = 0;
                while (Char.IsDigit(Text[a])) { index += Text[a]; a++; }
                user.Username = item.Text();
                user.ID = int.Parse(index);
                users.Add(user);
                if (progressBar1.Value < 150)
                {
                    progressBar1.Value += 10;
                } 
            }
            return users;
        }
        
        void ParseEpisodeInTopicmorepages(string link, ref List<Episodes> epss)
        //List<Episodes> ParseEpisodeInTopic(string link)
        {
           // List<Episodes>  = new List<Episodes>();
            var config = Configuration.Default.WithJavaScript().WithCss().WithCookies();
            
            var parser = new HtmlParser(config);
            string str = /*forParse();//*/ getResponse(link);
            var document = parser.Parse(str);

            var blueListItemsLinq = document.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("main"));
            string s = "";
            
            foreach (var item in blueListItemsLinq)
            {
                s += item.InnerHtml;
            }
            var posts = parser.Parse(s);
            var list = posts.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("container"));
            s = "";
            foreach (var item in list)
            {
                s += item.InnerHtml;
            }
            posts = parser.Parse(s);
            list = posts.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("tclcon"));
            s = "";
            
            foreach (var item in list)
            {

                s += item.InnerHtml;
                var post = parser.Parse(item.InnerHtml);
                var post1 = post.All.Where(m => m.LocalName == "a");
                foreach (var v in post1)
                {
                    string id = v.OuterHtml.Remove(0, (26 + forumname.Length));
                    if (id.IndexOf("acchide") < 0)
                    {
                        id = id.Remove(id.Length - 6 - v.InnerHtml.Length, id.Length - 6 - v.InnerHtml.Length);
                        string index = "";
                        int a = 0;
                        while (Char.IsDigit(id[a])) { index += id[a]; a++; }
                        Episodes ep = new Episodes(int.Parse(index));
                        ep.EpisodeName = v.InnerHtml;
                        ep.Status = EpisodeStatuses.Active;
                        epss.Add(ep);
                    }
                }
            }
            int azaza = 0;
            string asdasa = parseLinks(link);
            if (asdasa.Length > 0)
                ParseEpisodeInTopicmorepages(asdasa, ref epss);
        }
        string parseLinks(string link)
        {
            var config = Configuration.Default.WithJavaScript().WithCss();
            var parser = new HtmlParser(config);
            string str = getResponse(link);
            var document = parser.Parse(str);

            var blueListItemsLinq = document.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("pagelink"));
            string s = "";
            foreach (var item in blueListItemsLinq)
            {
                s += item.InnerHtml;
                break;
            }
            var links = parser.Parse(s);
            var next = document.All.Where(m => m.LocalName == "a" && m.ClassList.Contains("next"));
            s = "";
            foreach (var item in next)
            {
                s += item.OuterHtml;
                break;
            }
            if (s.Length > 0)
            {
                s = s.Remove(0, 22).Remove(forumname.Length + 27, 7);
                int astrts = s.IndexOf("amp;");
                s = s.Remove(astrts, 4);
            }
            return s;
        }
        public bool UserProfile(ref User user)
        {
            //try
            //{
                var config = Configuration.Default.WithJavaScript().WithCss();
                var parser = new HtmlParser(config);
                string str = getResponse(forumname + "profile.php?id=" + user.ID);
                var document = parser.Parse(str);
                var blueListItemsLinq = document.All.Where(m => m.LocalName == "td" && m.HasAttribute("id") && m.GetAttribute("id").Contains("profile-right"));

                //сравниваем данные с данными БД по users. если id отсутствует в БД, то запускаем парсинг forumname + "profile.php?id=" + users[i].ID 


                string s = "";
                foreach (var item in blueListItemsLinq)
                {
                    //  sw.WriteLine(item.Html());
                    s += item.InnerHtml;
                    //break;
                }
                var pinfo = parser.Parse(s);
               var profile_info = pinfo.All.Where(m => m.LocalName == "li");
                foreach (var item in profile_info)
                {
                    var strings = parser.Parse(item.Html());
                    var strongs = strings.All.Where(m => m.LocalName == "strong");
                    var spans = strings.All.Where(m => m.LocalName == "span");
                    string st = strongs.First().Text(), sp = spans.First().Text();
                //sw.WriteLine(item.Html());
                switch (sp)
                {
                    case "Зарегистрирован:":
                        {
                            DateTime proba;
                            if (DateTime.TryParse(st, out proba))
                                user.RegistrationDate = proba;
                            else
                            {
                                if (sp == "Сегодня") { user.RegistrationDate = DateTime.Today; }
                                else { user.RegistrationDate = DateTime.Today.AddDays(-1); }
                            }
                            break;
                        }
                
                    case "Последнее сообщение:":
                        {
                            DateTime proba;
                            if (DateTime.TryParse(st, out proba))
                                user.TimeofLastMessage = proba;
                            else
                            {
                                string[] tmp = st.Split(' ');
                                if (tmp[0] == "Сегодня")
                                { user.TimeofLastMessage = DateTime.Today.AddHours(DateTime.Parse(tmp[1]).Hour).AddMinutes(DateTime.Parse(tmp[1]).Minute).AddSeconds(DateTime.Parse(tmp[1]).Second); }
                                else if (tmp[0] == "Вчера") { user.TimeofLastMessage = DateTime.Today.AddDays(-1).AddHours(DateTime.Parse(tmp[1]).Hour).AddMinutes(DateTime.Parse(tmp[1]).Minute).AddSeconds(DateTime.Parse(tmp[1]).Second); }
                                else if (tmp[0] == "Никогда") { break; }
                                else
                                {
                                    switch (tmp[2])
                                    {
                                        case "Янв": tmp[2] = "1"; break;
                                        case "Фев": tmp[2] = "2"; break;
                                        case "Мар": tmp[2] = "3"; break;
                                        case "Апр": tmp[2] = "4"; break;
                                        case "Май": tmp[2] = "5"; break;
                                        case "Июн": tmp[2] = "6"; break;
                                        case "Июл": tmp[2] = "7"; break;
                                        case "Авг": tmp[2] = "8"; break;
                                        case "Сен": tmp[2] = "9"; break;
                                        case "Окт": tmp[2] = "10"; break;
                                        case "Ноя": tmp[2] = "11"; break;
                                        case "Дек": tmp[2] = "12"; break;
                                        default: break;
                                    }
                                    //DateTime dt1 = 

                                    user.TimeofLastMessage = new DateTime(int.Parse(tmp[3]), int.Parse(tmp[2]), int.Parse(tmp[1]));
                                    //DateTime.Parse(tmp[4]).
                                    //AddDays(DateTime.Parse(tmp[1]).Day).
                                    //AddMonths(DateTime.Parse(tmp[2]).Month).
                                    //AddYears(DateTime.Parse(tmp[3]).Year); }
                                }
                            }
                            break;
                        }
                    case "Последний визит:":
                            {
                                DateTime proba;
                                if (DateTime.TryParse(st, out proba))
                                    user.TimeofLastVisit = proba;
                                else
                                {
                                    string[] tmp = st.Split(' ');
                                    if (tmp[0] == "Сегодня") { user.TimeofLastVisit = DateTime.Today.AddHours(DateTime.Parse(tmp[1]).Hour).AddMinutes(DateTime.Parse(tmp[1]).Minute).AddSeconds(DateTime.Parse(tmp[1]).Second); }
                                    else { user.TimeofLastVisit = DateTime.Today.AddDays(-1).AddHours(DateTime.Parse(tmp[1]).Hour).AddMinutes(DateTime.Parse(tmp[1]).Minute).AddSeconds(DateTime.Parse(tmp[1]).Second); }
                                }
                                break;
                            }
                        case "Сообщений:":
                            {

                                string index = "";
                                int a = 0;
                                while (Char.IsDigit(st[a])) { index += st[a]; a++; }
                                user.MessageCount = int.Parse(index);
                                break;
                            }
                        case "Уважение:":
                            {
                                try
                                {
                                    user.RespectsPositive = int.Parse(st);
                                }
                                catch
                                {
                                    string[] a = st.Split('/');
                                    user.RespectsPositive = int.Parse(a[0]);
                                    user.RespectsNegative = int.Parse(a[1]);
                                }
                                break;
                            }
                        case "Провел на форуме:":
                            {
                                user.TimeInForum = st;
                                break;
                            }
                        default: break;
                    }
                }
                return true;
            }
            //catch
            //{
            //    return false;
            //}
       // }
        struct postdate { public User user; public DateTime time; }

        bool IndexOfUser(List<postdate> PostDateUse, IElement ieuser)
        {
            foreach (var item in PostDateUse)
                if (item.user.Username == ieuser.InnerHtml)
                    return true;
            return false;
        }
        //List<postdate> PostDateUser (IEnumerable<IElement> userlist, IEnumerable<IElement> datelist)
        //{
        //    List<postdate> lpd = new List<postdate>();
        //    for (int i = 0; i < userlist.Count(); i++)
        //    {
        //        IElement ieuser = userlist.Last();
        //        if (!IndexOfUser(lpd, ieuser))
        //        {
        //            postdate pd = new postdate();
        //            pd.user = userlist.Find(ieuser.InnerHtml);
        //    }
        //    }
        //}
        public Episodes ParseEpisodeInside(Episodes epis)
        {
            var config = Configuration.Default.WithJavaScript().WithCss().WithCookies();

            var parser = new HtmlParser(config);
            string str =  getResponse(forumname);
            var document = parser.Parse(str);
            Episodes episode = new Episodes(epis.TopicID);
            episode.Status = epis.Status;
            episode.EpisodeName = epis.EpisodeName;
            
            //episode.Posts = new Post[12];
            var link = document.All.Where(m => m.LocalName == "span" && m.ClassName.Contains("item2"));
            var blueListItemsLinq = document.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("main"));
            string s = "";

            foreach (var item in blueListItemsLinq)
            {
                s += item.InnerHtml;
            }
            var posts = parser.Parse(s);
            var list = posts.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("container"));
            var list2 = posts.All.Where(m => m.LocalName == "a" && m.ClassList.Contains("permalink"));
            s = "";
            foreach (var item in list)
            {
                s += item.InnerHtml;
            }
            posts = parser.Parse(s);
            var list1 = posts.All.Where(m => m.LocalName == "div" && m.ClassList.Contains("post-author"));
            s = "";
            string s2 = "";
            foreach (var item in list1)
            {
                s += item.InnerHtml;
            }
            foreach (var item in list2)
            {
                s2 += item.InnerHtml;
            }
            posts = parser.Parse(s);
            var list3 = posts.All.Where(m => m.LocalName == "li" && m.ClassList.Contains("pa-author"));
            s = "";
            foreach (var item in list3)
            {
                s += item.InnerHtml;
            }
            posts = parser.Parse(s);
            var list4 = posts.All.Where(m => m.LocalName == "a");
            s = "";
            foreach (var item in list4)
            {
                s += item.InnerHtml + " ";
            }
            StreamWriter ws = new StreamWriter("testc.txt");
            ws.WriteLine(s2);
            ws.Close();
            return episode;
        }

        public Form1()
        {
            InitializeComponent();
            Episodes e = new Episodes(561);
            ParseEpisodeInside(e);

        }
        List<User> userlist1;
        Episodes[] eps;
        void NewLoading()
        {
            progressBar1.Value = 0;
            List<User> usr = ParseUserlist();
            progressBar1.Value = 160;
            List<User> users = new List<User>();
            for (int i = 0; i < usr.Count; i++)
            {
                User u = usr[i];
                UserProfile(ref u);
                users.Add(u);
                if (progressBar1.Value < 190)
                    progressBar1.Value += 5;
            }

            if (p == null) p = new Params();
            userlist1 = users;
            progressBar1.Value = 200;
            progressBar1.Value = 0;
        }
        List<User> Search()
        {
            List<User> users = new List<User>();
            foreach(var item in userlist1)
            {
                if (item.TimeofLastVisit < DateTime.Today.AddDays(-p.MinLogins))
                    users.Add(item);
            }
            return users;
        }
        List<User> SearchPosts()
        {
            List<User> users = new List<User>();
            foreach (var item in userlist1)
            {
                if (item.TimeofLastMessage < DateTime.Today.AddDays(-p.WritePosts))
                    users.Add(item);
            }
            return users;
        }
        Params p;

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Params();
            p.ForumName = forumname;
            NewLoading();
            Userlist usrlist = new Userlist(userlist1);

            
        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Настройки n;
            if (p == null)
            {
                n = new Настройки();

            }
            else
            {
                n = new Настройки(p);
            }
            n.ShowDialog();
            if (!n.cancel)
            {
                p = n.ParamsForum;
                NewLoading();
            }
        }

        private void всеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List < Episodes > epps = new List<Episodes>();
            ParseEpisodeInTopicmorepages(@"http://dgmwin.rusff.ru/viewforum.php?id=4", ref epps);
            Posts p = new Posts(epps, forumname);
            p.Show();
        }

        private void отсутствиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userlist usrlist = new Userlist(Search());
            usrlist.Show();
            usrlist.Text = "Не появлялись на форуме последние " + p.MinLogins + " дней";
        }

        private void списокПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userlist usrlist = new Userlist(userlist1);
            usrlist.Show();
            usrlist.Text = "Список пользователей";
        }

        private void активностьВПостахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userlist usrlist = new Userlist(SearchPosts());
            usrlist.Show();
            usrlist.Text = "Не были активны последние " + p.WritePosts + " дней";
        }
        List<EpisodeForum> abc;
        private void ссылкиНаЭпизодыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            episodelinks elinks = new episodelinks();
            elinks.ShowDialog();
            if(elinks.episodes !=null)
            {
                abc = elinks.episodes;

            }
        }

        private void эпизодыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
