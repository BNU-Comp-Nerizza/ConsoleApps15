using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  modified by: Nerizza Flores 23/03/2021
    ///  version 0.2
    ///</author> 
    public class NewsFeed
    {
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            //sample post
            MessagePost post1 = new MessagePost("Nerizza", "Hi!!");
            AddMessagePost(post1);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine(); 
            }
        }

        /// <summary>
        /// Finding the post with the given id
        /// </summary>
        /// <returns>returns the matching post
        /// or null if there is none </returns>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }

            return null;
        }

        /// <summary>
        /// Remove Post based on the id post
        /// </summary>
        /// <param name="id"></param>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nThe following Post {id} has been removed!\n");

                if (post is MessagePost mp)
                {
                    mp.Display();
                }
                else if (post is PhotoPost pp)
                {
                    pp.Display();
                }

                posts.Remove(post);
                post.Display();
            }
        }

        /// <summary>
        /// Find the post based on the
        /// given author and output all the post
        /// </summary>
        public void DisplayAuthorPost(string author)
        {
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                }
            }
        }

        /// <summary>
        /// Add comments based on the post id
        /// then add text on the post
        /// </summary>
        public void AddPostComment(int id, string text)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nThe following comment have been added to post {id}!\n");
                post.AddComment(text);
                post.Display();
            }
        }

        /// <summary>
        /// Like post based on the given id post
        /// </summary>
        public void LikePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nYou have liked the the following post {id}!\n");
                post.Like();
                post.Display();
            }
        }

        /// <summary>
        /// Unlike a post based on the given id post
        /// </summary>
        public void UnlikePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID: {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\nYou have unliked the the following post {id}!\n");
                post.Unlike();
                post.Display();
            }
        }

        /// <summary>
        /// Ouput the post based on 
        /// the date of the post
        /// </summary>
        public void FindDate(string date)
        {
            foreach (Post post in posts)
            {
                if (post.Timestamp.ToLongDateString().Contains(date))
                {
                    post.Display();
                }
            }
        }
    }
}
