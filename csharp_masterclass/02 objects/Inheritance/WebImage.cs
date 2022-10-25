using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class WebImage: Post
    {
        // Attributes
        private string urlDirection;

        // Properties
        public string URLDirection { get => this.urlDirection; set => this.urlDirection = value; }

        // Construtctor
        public WebImage()
        {

        }

        public WebImage(string title, string author, string content, bool isAvailable, string urlDirection)
        {
            Id = getId();
            Title = title;
            Author = author;
            Content = content;
            IsAvailable = isAvailable;
            URLDirection = urlDirection;
        }

        public override string ToString()
        {
            // return base.ToString();
            return String.Format("{0} - {1} - Created by: {2}. Available in {3}", Id, Title, Author, URLDirection);
        }
    }
}
