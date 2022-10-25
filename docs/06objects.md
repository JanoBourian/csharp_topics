# Objects


## Objects :S

The Object

```cs
using System;

namespace AObjects
{
    class Human
    {
        // I'll create a set of vars
        private string first_name;
        private string last_name;
        private int age;

        // There is a default constructor
        public Human()
        {
            Console.WriteLine("Default constructor");
        }

        // There is the constructor
        public Human(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }

        // There is the constructor
        public Human(string first_name, string last_name, int age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
        }

        // First method salute
        public void salute()
        {
            Console.WriteLine("Hello, I'm {0} {1} and I'm {2} years old!", this.first_name, this.last_name, this.age);
        }

    }
}
```

Calling it

```cs
using System;

namespace AObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Human peter = new Human("Peter", "Smith", 27);
            Human sam = new Human();
            Human withOut = new Human("Calix", "Megan");
            peter.salute();
            sam.salute();
            withOut.salute();
            Console.ReadLine();
        }
    }
}
```

## Get and set inside of class

```cs
using System;

namespace AObjects
{
    class Box
    {
        // I'll create a first vars
        private float height;
        private float width;
        private float depth;
        private float volumen;
        private string box_name;

        // Basic constructor
        public Box(float height, float width, float depth)
        {
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.volumen = this.set_volumen();
        }

        private float set_volumen()
        {
            return this.height * this.width * this.depth;
        }

        public float get_volumen()
        {
            return this.volumen;
        }

        // Auto implemented property
        public string BoxName
        {
            get
            {
                return this.box_name;
            }
            set
            {
                this.box_name = value;
            }
        }
    }
}
```

Calling int

```cs
using System;

namespace AObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human part
            Human peter = new Human("Peter", "Smith", 27);
            Human sam = new Human();
            Human withOut = new Human("Calix", "Megan");
            peter.salute();
            sam.salute();
            withOut.salute();

            // Box part
            Box firstBox = new Box(1.35f, 5.4f, 1.98f);
            Console.WriteLine("The box volumen is {0}", firstBox.get_volumen());
            firstBox.BoxName = "Juice Box";
            Console.WriteLine("The name box is: {0}", firstBox.BoxName);
            Console.ReadLine();
        }
    }
}
```

Simplified the set/get process

```cs
public string BoxName
        {
            get
            {
                return this.box_name;
            }
            set
            {
                this.box_name = value;
            }
        }

// Instead of

public string BoxName
        {
            get => this.box_name;
            set => this.box_name = value;
        }

```
## Members

```cs
using System;

namespace AObjects
{
    class Members
    {
        // members can be private fields
        private string first_name;
        private string last_name;
        private float amount;

        // member can be public fields
        public int age;

        // members as properties
        public int MyProperty { get; set; }

        // members as private methods
        private void SharePrivateInfo(){}

        // members as public methods
        public void SharePublicInfo() {}

        // constructor
        public Members(){}

        // members finisher/destroyer
        ~Members()
        {
            Console.WriteLine("I had destroyed the class");
            Console.ReadLine();
        }


    }
}

```

## [Return to index](/README.md)