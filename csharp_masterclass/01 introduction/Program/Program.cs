using System;

namespace Program
{
    class Program
    {
        static int edad = 15;

        const double PI = 3.141516;
        static void Main(string[] args)
        {
            string name = "Fernando Valencia Acosta";
            Console.WriteLine("Hola Mundo "+ edad + " " + name);
            Console.WriteLine(edad);

            // Explicit conversion
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // Implicit conversion
            int num = 123456;
            long numG = num;
            Console.WriteLine(numG);

            // Type conversion
            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            // Parsing String to Integer
            string myNum1 = "15";
            string myNum2 = "10";
            string resultado = myNum1 + myNum2;

            int number;
            if (int.TryParse(resultado, out number))
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
