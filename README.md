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

If you want throw a new Exception you can use "throw new Exception("Some text about the exception");"

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

## Control with switch statment

```cs
using System;

namespace Switch{

    static void Main(string[] args){
        int autos = 1;
        
        switch(autos){
            case 0:
                Consolde.WriteLine("Caso de 0");
                break;
            case 1:
                Consolde.WriteLine("Caso de 1");
                break;
            default:
                Consolde.WriteLine("Usted paga bastantes impuestos");
                break;
        }
    }
}
```

## Ternary Operator

```cs
// condition ? first_statement : second_statment
result = temperatura < 0 ? "Cold" : "Warm";
result = temperatura >= 100 ? "Gas" : temperatura <= 0 ? "Ice" : "Liquid";
```

## Loops

- for
- do / while
- while
- foreach

```cs
using System;

namespace _03Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For statment
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Contador {0}", contador);
            }

            // do-while
            int count = 0;
            do
            {
                Console.WriteLine("El valor del contador en do-while es: {0}", count);
                count++;
            } while (count < 0);

            // while
            count = 0;
            while(count < 10)
            {
                Console.WriteLine("Dentro del while tenemos el contador con valor {0}", count);
                if (count == 9)
                {
                    Console.WriteLine("We are inside of break statment");
                    break;
                }
                count++;
            }

            Console.ReadLine();
        }
    }
}
```

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
## Arrays

```cs
int [] calificaciones;
int [] calificaciones = new int[5];
```

### Initialize arrays and Length

```cs
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones;
            Console.Write("¿Cuántos elementos ingresarás?: ");
            int elementos = Int32.Parse(Console.ReadLine());
            calificaciones = new int[elementos];
            for(int i = 0; i < elementos; i++)
            {
                Console.Write("Ingresa la calificación para el alumno {0}: ", i + 1);
                int calificacion = Int32.Parse(Console.ReadLine());
                calificaciones[i] = calificacion;
            }
            Console.WriteLine("EL tamaño del arreglo es de {0}", calificaciones.Length);

            Console.ReadLine();
        }
    }
}
```

### ForEach Loop

```cs
foreach(int k in calificaciones)
    {
        Console.WriteLine("Ingresa la calificación para el alumno es: {0}", k);
    }
```

### Multidimentional arrays

```cs
string[,,,] multidimensional;
```

### Irregular Arrays

```cs
using System;

namespace IrregularArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] irregular = new int[3][];
            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[9];

            irregular[0] = new int[] { 1, 2, 3, 4, 5};
            irregular[1] = new int[] { 0, 3, 5};
            irregular[2] = new int[] { 1, 9, 8, 7, 8, 9, 7, 9, 9 };

            int[][] irregular2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5},
                new int[] { 0, 3, 5 },
                new int[] { 1, 9, 8, 7, 8, 9, 7, 9, 9 }
             };

        }
    }
}
```

### Arrays as parameters

```cs
static void printArray(int[] arrayToPrint)
{
    for(int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.WriteLine("{0}", arrayToPrint[i]);
    }
}
```

### ArraysList

```cs
static void arrayAsAList()
{
    ArrayList miArray = new ArrayList();
    ArrayList miSecondArray = new ArrayList(100);

    for(int i = 0; i < 10; i++)
    {
        Console.Write("Escribe una palabra: ");
        String name = Console.ReadLine();
        miArray.Add(name);
    }

            /* 
             * Add()
             * Remove() <- tho show
             * RemoveAt() <- position
             * Count
             */
}
```

```cs
foreach(object obj in miArray)
{
    Console.WriteLine(obj);
}
```

### List

```cs
static void workWithList()
{
    var numeros = new List<int>();
    var randomValues = new List<object>();

    //Clear() <- put our array empty
    //Sort()
    //RemoveRange()
}
```

### ArrayList vs Arrays vs Lists

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