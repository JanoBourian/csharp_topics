using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{
    class WebVideo: Post
    {
        // Attributes
        private string urlVideo;
        private double duration;
        private bool isPlaying = false;
        private double currentDuration = 0.0;
        Timer clock;

        // Properties
        public string URLVideo { get => this.urlVideo; set => this.urlVideo = value; }
        public double Duration { get => this.duration; set => this.duration = value; }

        // Constructors
        public WebVideo()
        {

        }

        public WebVideo(string title, string author, string content, bool isAvailable, string urlDuration, double duration)
        {
            Id = getId();
            Title = title;
            Author = author;
            Content = content;
            IsAvailable = isAvailable;
            URLVideo = urlDuration;
            Duration = duration;
        }

        // Methods
        public override string ToString()
        {
            // return base.ToString();
            return String.Format("{0} - {1} - Created by: {2}. Available in {3} with duration {4}", Id, Title, Author, URLVideo, Duration);
        }

        public void playVideo()
        {
            if (!this.isPlaying)
            {
                Console.WriteLine("Playing... ");
                this.clock = new Timer(Playing, null, 0, 1000);
                this.isPlaying = true;
            }
            else
            {
                Console.WriteLine("Dennied Operation!");
            }
        }

        public void stopVideo()
        {
            if (this.isPlaying)
            {
                Console.WriteLine("Stopping in {0} seconds", currentDuration);
                this.clock.Dispose();
                this.isPlaying = false;
            }
            else
            {
                Console.WriteLine("Dennied Operation!");
            }

        }

        private void Playing(Object o)
        {
            if(currentDuration < Duration)
            {
                currentDuration++;
                Console.WriteLine("Video en {0} seconds", currentDuration);
                GC.Collect();
            }
            else
            {
                stopVideo();
            }
        }
    }
}
