# Inheritance

## Some concepts
- protected: it is only available in its class and the classes that inheritance its.

## Base Class

```cs
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

```

## WebImage Class

```cs
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
        public string urlDirection;

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

```

## WebVideo Class

```cs
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

```

## Implementation

```cs
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

```

# Interfaces

The interfaces have the definition of methods that the child class must inheritance of them. Interface has the definiton and his child has the implementation and the information about the methods. 

## Interface: Notification

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface INotification
    {
        void showNotification();
        string showDateNow();
    }
}
```

## Unsing INotification as PushNotification

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PushNotification: INotification
    {

        private string sender;
        private string message;
        private string date;

        public string Sender { get => this.sender; set => this.sender = value; }
        public string Message { get => this.message; set => this.message = value; }
        public string Date { get => this.date; set => this.date = value; }

        public PushNotification(string sender, string message, string date)
        {
            Sender = sender;
            Message = message;
            Date = date; 
        }
        public void showNotification()
        {
            Console.WriteLine(Message);
        }

        public string showDateNow()
        {
            return Date;
        }
    }
}

```

## Implementating

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PushNotification message = new PushNotification("Janobourian", "Hello my friend, I need your help with a problem in GCP", "25/10/2022");
            Console.WriteLine("The date is: {0}", message.showDateNow());
            message.showNotification();
            Console.ReadLine();
        }
    }
}

```

# Abstract Class

An abstract class can't be instantiated.


## Abstract Class

```cs
abstract class Persona{
    protected string name;
    protected char sexo;
    protected int edad;

    public Persona(string nombre, char sexo, int edad){
        this.nombre = nombre;
        this.sexo = sexo;
        this.edad = edad;
    }

    public void Informacion(){
        Console.WriteLine("Information: ");
    }

    public abstract void Identificacion();
}
```

## Using Abstract Class

```cs
class Docente: Persona{
    private int tarjeta;

    public Docente(string nombre, char sexo, int edad, int tarjeta) : base(nombre, sexo, edad){
        this.tarjeta = tarjeta;
    }

    public void totalInformation(){
        Informacion();
        Console.WriteLine("Additional information!");
    }

    public override void Identificacion(){
        Console.WriteLine("Card: {0}", this.tarjeta);
    }

}
```

## Sealed classes

And now we are going to set a sealed class using the last class Docente

```cs
sealed class Jefe: Docente{
    private string departamento:

    public Jefe(string nombre, char sexo, int edad, int tarjeta, string departamento) : base(nombre, sexo, edad, tarjeta) {
        this.departamento = departamento;
    }

    new public void Informacion(){
        Console.WriteLine("New code for the Informacion() method!");
    }
}
```


## [Return to index](/README.md)