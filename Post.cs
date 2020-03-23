using System;
using System.Collections.Generic;
using System.Text;

namespace post
{
    class Post
    {

        private string Title;
        private string User;

        private int Vote;
        private string PostField;
        
        public void SetTitle(string title)
        {
            Title = title;
        }
        public string GetTitle()
        {
            return Title;
        }
        ////
        public void SetUser(string user)
        {
            User = user;
        }
        public string GetUser()
        {
            return User;
        }
        //////
        public void SetVote(int vote)
        {
            Vote = vote;
        }
        public int GetVote()
        {
            return Vote;
        }

        ///////////
        public void SetPostField(string postField)
        {
            PostField = postField;
        }
        public string GetPostField()
        {
            return PostField;
        }







    }
}
