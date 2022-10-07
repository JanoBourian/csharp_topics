# csharp_topics
Scholar and job topics about that language

# Fast commands

Input/output info:
```cs
Console.WriteLine("Hola mundo!");
Console.ReadLine();
```

First general and basic structure:
```cs
namespace Program
{
    class Program
    {
        static int edad = 15;
        public static void Main(string[] args)
        {
            string name = "Fernando Valencia Acosta";
            Console.WriteLine("Hola Mundo "+ edad + " " + name);
            Console.WriteLine(edad);
            Console.ReadLine();
        }
    }
}

```

Conversions:
```cs
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
```

Some methods for strings:

```cs
SubSubstring(int32)
ToLower()
ToUpper()
Trim()
IndexOf(string)
IsNullOrWhitSpace()
string.Concat("", nombre, apellido, "")
String.Format()
var nombre = "Federico"
Strinf.Format("Mi nombre es{0}", nombre)
```

Constants:
```cs
const double PI = 3.141516;
```

## Methods and Try-Catch-Finally

```cs
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

```

## Operators

```cs
num3 = -num1;

bool haySol = true;
!haySol //False

num++; //next statment
++num; //same statment

num--; //next statment
--num; //same statmen

num1&num2 //mod

"""
<
<=
== 
>=
>
&& -> Y
|| -> O
"""
```

## Control with if else

```cs
using System;

namespace _02Control
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = InsertName();
            if (Validate(value))
            {
                Console.WriteLine("Fue posible");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No fue posible");
                Console.ReadLine();
            }


            /*
             
            if(){
            }
            else if(){
            } 
            else{
            }

             */
        }

        public static string InsertName()
        {
            Console.WriteLine("Ingresa un numero: ");
            string number = Console.ReadLine();
            return number;
        }

        public static bool Validate(string value)
        {
            int numero;
            return int.TryParse(value, out numero);
        }
    }
}

```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```
```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```
```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```
```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```

```cs
```