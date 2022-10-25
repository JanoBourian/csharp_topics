using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Direct implementation
            Post post_1 = new Post();
            Console.WriteLine(post_1);
            Post post_2 = new Post("Django Remembert", "Django Python", "It is about Frameworks", false);
            Console.WriteLine(post_2);
            WebImage post_3 = new WebImage();
            Console.WriteLine(post_3);
            WebImage post_4 = new WebImage("Ravens", "Lamar Jackson", "Lamar is the best QB in the Raven's story", true, "https://pixabay.com/es/photos/mariscal-de-campo-f%c3%batbol-americano-73614/");
            Console.WriteLine(post_4);
            WebVideo post_5 = new WebVideo();
            Console.WriteLine(post_5);
            WebVideo post_6 = new WebVideo("The best of Heroes del Silencion", "Heroes del silencio", "The best song part I", true, "https://www.youtube.com/watch?v=lXt110botJo", 18.0);
            Console.WriteLine(post_6);
            post_6.stopVideo();
            post_6.playVideo();
            post_6.playVideo();
            post_6.stopVideo();
            post_6.playVideo();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            post_6.stopVideo();
            Console.ReadLine();
        }
    }
}
