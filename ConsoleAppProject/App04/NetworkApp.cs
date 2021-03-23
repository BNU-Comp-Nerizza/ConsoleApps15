using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

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

        private void RemovePost()
        {
            ConsoleHelper.OuputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ", 1, Post.GetNumberOfPosts());

            news.RemovePost(id);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void DisplayByAuthor()
        {
            Console.WriteLine("Enter the name of user you want to display > ");
            string author = Console.ReadLine();
            ConsoleHelper.OuputTitle($"Display post by {author}");
            news.DisplayAuthorPost(author);
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();
            return author;
        }
    }
}
