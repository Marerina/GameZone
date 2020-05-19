using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZone
{
    class Ban
    {
        int id;
        int description;
        DateTime startBan;
        DateTime finishBan;
    }
    public class Post
    {
        int post_in_topicId;
        int userID;
        public int PostID { get { return post_in_topicId; } private set { post_in_topicId = value; } }
        public int UserID { get { return userID; } private set { userID = value; } }
        public Post(int ID, User user)
        {
            PostID = ID;
            UserID = user.ID;
        }
    }
   public enum EpisodeStatuses {Frosted, Active, Finished}
    public enum EpisodeType { Archive, Canon, NonCanon }
    public class EpisodeForum
    {
        string link;
        string name;
        List<Episodes> episodelist;
        EpisodeType etype;
        public string Link { get { return link; } set { link = value; } }
        public string Name { get { return name; } set { name = value; } }
        public List<Episodes> EpisodeList { get { return episodelist; } set { episodelist = value; } }
        public EpisodeType EType { get { return etype; } set { etype = value; } }
    }
   public class Episodes
    {
        int topicID;
        string episodeName;
        Post[] posts;
        EpisodeStatuses status;
        
        public string EpisodeName { get { return episodeName; } set { episodeName = value; } }
        public int TopicID { get { return topicID; } private set { topicID = value; } }
        public Post[] Posts { get { return Posts; } set { Posts = value; } }
        public EpisodeStatuses Status { get { return status; } set { status = value; } }
        public Episodes(int id)
        {
            TopicID = id;
            posts = new Post[0];
            Status = EpisodeStatuses.Active;
        }
        public void AddPost(Post post)
        {
            Post[] posts1 = new Post[posts.Length + 1];
            for(int i = 0; i< posts.Length; i++)
            {
                posts1[i] = posts[i];
            }
            posts1[posts.Length] = post;
            posts = posts1;
        }
        public bool RemovePost(int PostID)
        {
            int id = -1;
            for(int i = 0; i< Posts.Length; i++)
            {
                if (Posts[i].PostID == PostID) id = i;
            }
            if (id < 0) return false;
            else
            {
                Post[] posts1 = new Post[posts.Length-1];
                for (int i = 0; i < id; i++)
                {
                    posts1[i] = posts[i];
                }
                for (int i = id+1; i < posts.Length; i++)
                {
                    posts1[i] = posts[i];
                }
                posts = posts1;
                return true;
            }
        }
    }
    public class User
    {
        int iD;
        string time_in_forum;
        string username;
        DateTime registrationDate;
        int respectsPositive;
        int respectsNegative;
        int positive;
        int messageCount;
        DateTime timeofLastMessage;
        DateTime timeofLastVisit;
        Ban[] bans;
        DateTime birthday;
        DateTime realBirthday;
        int groupID;
        public int ID { get { return iD; } set { iD = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string TimeInForum { get { return time_in_forum; } set { time_in_forum = value; } }
        public int RespectsPositive { get { return respectsPositive; }  set { respectsPositive = value; } }
        public int RespectsNegative { get { return respectsNegative; }  set { respectsNegative = value; } }
        public int Positive { get { return positive; } set { positive = value; } }
        public int MessageCount { get { return messageCount; }  set { messageCount = value; } }
        public int GroupID { get { return groupID; }  set { groupID = value; } }
        public DateTime RegistrationDate { get { return registrationDate; }  set { registrationDate = value; } }
        public DateTime TimeofLastMessage { get { return timeofLastMessage; }  set { timeofLastMessage = value; } }
        public DateTime TimeofLastVisit { get { return timeofLastVisit; }  set { timeofLastVisit = value; } }
        public DateTime Birthday { get { return birthday; }  set { birthday = value; } }
        public DateTime RealBirthday { get { return realBirthday; } private set { realBirthday = value; } }
    }
}
