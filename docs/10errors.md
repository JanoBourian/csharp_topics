# Errors

Keywords: try, catch, finally. 

## Basic Try-Catch-Finally block

```cs
namespace Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string tmp;
            Console.WriteLine("Escribe un número entero: ");
            tmp = Console.ReadLine();
            try
            {
                a = Convert.ToInt16(tmp);
                Console.WriteLine("Usted escribió {0}", a);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("FormatException {0}", fe);
            }
            finally
            {
                Console.WriteLine("Finally statement");
            }
            Console.ReadLine();
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

## [Return to index](/README.md)