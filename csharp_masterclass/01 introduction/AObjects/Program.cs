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

            Members miembro = new Members();

            Console.ReadLine();
        }
    }
}
