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
## We can implement our errors

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    class AgeOutRange : ApplicationException
    {
        public AgeOutRange() : base("You inserted a invalid value (out of range)")
        {

        }

        public AgeOutRange(string message): base(message)
        {

        }

        public AgeOutRange(string message, Exception es): base(message, es)
        {

        }
    }
}

```

Using our personal error:

```cs
if(age < 18 || age > 65){
    throw new AgeOutRange();
}
```

Second implementation:

```cs
if(age < 18 || age > 65){
    throw new AgeOutRange("Age out of range, my friend");
}
```

## [Return to index](/README.md)