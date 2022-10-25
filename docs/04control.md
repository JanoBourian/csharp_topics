# Control

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

## [Return to index](/README.md)