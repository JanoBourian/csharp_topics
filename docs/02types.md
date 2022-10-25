# Types

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

## [Return to index](/README.md)