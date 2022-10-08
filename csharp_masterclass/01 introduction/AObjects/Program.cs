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
