using System;

namespace post
{
    class Program
    {


        static Post postObj = new Post();
        static void Main(string[] args)
        {

            Console.WriteLine("Type \"post\" if you want to post something, or type \"show posts\" if you want to see the posts!");
            string userInput = Console.ReadLine();
            if (userInput == "post")
            {
                PostMethod();
            }
            else if(userInput =="show posts")
            {
                if (postObj.GetPostField()=="")
                {
                    Console.WriteLine("No posts yet.");
                }
                else
                {
                    ShowPosts();
                }
            }
            Console.WriteLine("Now type \"post\" if you want to post something again, or type \"show posts\" if you wanna see the posts!");
            userInput = Console.ReadLine();
            if (userInput == "post")
            {
                PostMethod();
            }
            else if (userInput == "show posts")
            {
                if (postObj.GetPostField() == "")
                {
                    Console.WriteLine("No posts yet.");
                }
                else
                {
                    ShowPosts();
                }
            }


        }

        public static void PostMethod()
        {
            Console.WriteLine("Hi! Before post, enter your name: ");
            string name = Console.ReadLine();
            postObj.SetUser(name);
            Console.WriteLine("Now enter the title of the post: ");
            string title = Console.ReadLine();
            postObj.SetTitle(title);
            Console.WriteLine("Now type in your post...");
            string posttext = Console.ReadLine();
            postObj.SetPostField(posttext);
            Console.WriteLine("Your post is sent.");
        }

        public static void ShowPosts()
        {
            Console.WriteLine("Title: " + postObj.GetTitle());
            Console.WriteLine("Sent by: " + postObj.GetUser());
            Console.WriteLine("Post text: " + postObj.GetPostField());
        }

    }
}
