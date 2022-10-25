using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Post
    {
        private static int postId;
        private int id;
        private string title;
        private string author;
        private string content;
        private bool isAvailable;

        // Properties
        protected int Id { get => this.id; set => this.id = value; }
        protected string Title { get => this.title; set => this.title = value; }
        protected string Author { get => this.author; set => this.author = value; }
        protected string Content { get => this.content; set => this.content = value; }
        protected bool IsAvailable { get => this.isAvailable; set => this.isAvailable = value; }

        // Constructor
        public Post()
        {
            Id = getId();
            Title = "Random";
            Author = "Guess";
            Content = "Random Content";
            IsAvailable = true;
        }

        public Post(string title, string author, string content, bool isAvailable)
        {
            Id = getId();
            Title = title;
            Author = author;
            Content = content;
            IsAvailable = isAvailable;
        }

        // Methods

        protected int getId()
        {
            return ++postId;
        }

        public void editPost(string title, string author, string content, bool isAvailable)
        {
            if (!String.IsNullOrEmpty(title))
            {
                Title = title;
            }

            if (!String.IsNullOrEmpty(author))
            {
                Author = author;
            }

            if (!String.IsNullOrEmpty(content))
            {
                Content = content;
            }

            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            // return base.ToString();
            return String.Format("{0} - {1} - Created by: {2}", Id, Title, Author);
        }

    }
}
