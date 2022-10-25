# Loops 

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

## [Return to index](/README.md)