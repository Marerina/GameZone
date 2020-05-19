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
    public partial class Auth_form : Form
    {
        public Auth_form(string url)
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(url);
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.DocumentText += "<div id =\"PR_loginDiv\" style=\"display:none;\"><form id =\"form_login\" name=\"login\" method=\"post\" action=\"/login.php?action=in\" onsubmit=\"return check_form()\"><fieldset><input type =\"hidden\" name=\"form_sent\" value=\"1\"/>  <input type =\"text\" id=\"fld1\" name=\"req_username\" size=\"21\" maxlength=\"25\"/> <input type =\"text\" id=\"fld2\" name=\"req_password\" size=\"7\" maxlength=\"16\"/> <input type =\"submit\" class=\"button\" name=\"login\"/> </fieldset > </form ></div ><li id =\"navpiar\"><a href=\"#\" onclick=\"PiarIn();return false\"><span>Пиар-вход</span></a></li>"; 
            webBrowser1.Document.GetElementById("req_username").SetAttribute("value", "Логин");
            webBrowser1.Document.GetElementById("req_password").SetAttribute("value", "Пароль");
            foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("submit"))
            {
                if (he.GetAttribute("name").Equals("login"))
                {
                    he.InvokeMember("click");
                    break;
                }
            }
            
        }
    }
}
