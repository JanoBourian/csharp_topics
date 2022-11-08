# Arrays

## Arrays

```cs
int [] calificaciones;
int [] calificaciones = new int[5];
int [] calificaciones = new int[] { 1, 2, 3, 4};
int [] calificaciones = { 1, 2, 3, 4};
string[,,,] multidimensional;
int[,] data = new int[5,4];
int[][] data = new int[3][];
Alumno[] listAlumnos = new Alumno[4];
ArrayList miArray = new ArrayList();
ArrayList miSecondArray = new ArrayList(100);
var numeros = new List<int>();
var randomValues = new List<object>();
List<string> lista = new List<string>();
lista.FindIndex(x => x == "Pedro");
// Colas
Queue<string> cola = new Queue<string>();
cola.Enqueue(value);
cola.Dequeue();
// Pilas
Stack<string> pila = new Stack<string>();
pila.Push(value);
pila.Pop();
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


## [Return to index](/README.md)