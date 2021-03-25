using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Nerizza's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Remove Post",
                "Display All Posts", "Display Posts by Author",
                "Display Posts by Date", "Add Comment",
                "Like/Unlike Post", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1:
                        PostMessage();
                        break;
                    case 2:
                        PostImage();
                        break;
                    case 3:
                        RemovePost();
                        break;
                    case 4:
                        DisplayAll();
                        break;
                    case 5:
                        DisplayByAuthor();
                        break;
                    case 6:
                        DisplayByDate();
                        break;
                    case 7:
                        AddComment();
                        break;
                    case 8:
                        LikePosts();
                        break;
                    case 9:
                        wantToQuit = true;
                        break;
                }
            }
            while (!wantToQuit);
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OuputTitle("Posting an Message");
            string author = InputName();

            Console.WriteLine("Please enter your Message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OuputTitle("You have just posted this message:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OuputTitle("Posting an Image/Photo");
            string author = InputName();

            Console.WriteLine("Please enter your image file name > ");
            string filename = Console.ReadLine();

            Console.WriteLine("Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OuputTitle("You have just posted this image:");
            post.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OuputTitle("Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            news.RemovePost(id);
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByAuthor()
        {
            Console.WriteLine("Enter the name of user you want to display > ");
            string author = Console.ReadLine();
            ConsoleHelper.OuputTitle($"Posts by {author}");
            news.DisplayAuthorPost(author);
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByDate()
        {
            Console.WriteLine("Enter the date of post you want to display > ");
            string date = Console.ReadLine();
            ConsoleHelper.OuputTitle($"Posts from the {date}");
            news.FindDate(date);
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OuputTitle("Add a comment to a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());
            Console.WriteLine("Enter the comment you want to add > ");
            string comment = Console.ReadLine();
            news.AddPostComment(id, comment);
        }

        /// <summary>
        /// 
        /// </summary>
        private void LikePosts()
        {
            ConsoleHelper.OuputTitle("Like or Unlike a Post");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());
            Console.WriteLine("Do you want to [like] or [unlike] the post? > ");
            string choices = Console.ReadLine();
            switch(choices)
            {
                case "like":
                    Console.WriteLine("Like a Post\n");
                    news.LikePost(id);
                    break;
                case "unlike":
                    Console.WriteLine("Unlike a Post\n");
                    news.UnlikePost(id);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();
            return author;
        }
    }
}
