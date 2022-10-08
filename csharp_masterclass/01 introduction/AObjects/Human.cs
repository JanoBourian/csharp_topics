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
