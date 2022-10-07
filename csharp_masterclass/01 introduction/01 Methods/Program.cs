using System;

namespace _01_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribirArgumento("Fernando Vallejo");
            int number = Sumar(3, 5);
            Console.WriteLine("This is a number with some method {0}", number);
            string value = ReturnString();
            Console.WriteLine(value);
            Test();
            EscribeAlgo();
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMétodo (Args)
        public static void EscribeAlgo()
        {
            Console.WriteLine("I'm writing something");
            Console.ReadLine();
        }

        public static void EscribirArgumento(string variable)
        {
            Console.WriteLine("Esto se escribio en otro momento {0}", variable);
        }

        // Method with interaction
        public static string ReturnString()
        {
            Console.Write("Dime una frase y la imprimo: ");
            string input = Console.ReadLine();
            return input;
        }

        // Try - Catch - Finally 
        public static void Test()
        {
            try
            {
                string value = "Hamon";
                int nuevo = int.Parse(value);
                Console.WriteLine(nuevo);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is a specific error!");
            }
            catch (Exception)
            {
                Console.WriteLine("You are bárbaro!");
            }
            finally
            {
                Console.WriteLine("Finally man");
            }
            
        }
    }
}
