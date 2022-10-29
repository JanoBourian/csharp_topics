# Polymorphism

## First Implementation

The derivate class should has a override statement and the class superior should has a virtual statement. 
We only can close override methods. 
Keywords: virtual, sealed, override, new

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Auto
    {
        private int hp;
        private string color;

        public int Hp { 
            get => this.hp; 
            set => this.hp = value; 
        }

        public string Color { 
            get => this.color; 
            set => this.color = value; 
        }

        public Auto( int hp, string color)
        {
            Hp = hp;
            Color = color; 
        }

        // Methods

        public virtual void mostrarDetalles()
        {
            Console.WriteLine("HP: {0}\nColor: {1}", Hp, Color);
        }

        public virtual void reparar()
        {
            Console.WriteLine("Auto Reparado");
        }

    }
}

```

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    sealed class Audi : Auto
    {
        private string modelo;
        private string marca = "Audi";

        public string Modelo
        {
            get => this.modelo;
            set => this.modelo = value;
        }

        public string Marca
        {
            get => this.marca;
            // set => this.marca = value; 
        }

        public Audi(int hp, string color, string modelo) : base(hp, color)
        {
            Modelo = modelo;
        }

        // Methods

        public override void mostrarDetalles()
        {
            Console.WriteLine("Marca: {0}\nModelo: {1}\nHP: {2}\nColor: {3}", Marca, Modelo, Hp, Color);
        }

        public override void reparar()
        {
            Console.WriteLine("Auto {0} Reparado", Modelo);
        }
    }
}

```

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    sealed class BMW: Auto
    {
        private string modelo;
        private string marca = "BMW";

        public string Modelo { 
            get => this.modelo; 
            set => this.modelo = value;  
        }

        public string Marca { 
            get => this.marca; 
            // set => this.marca = value; 
        }

        public BMW(int hp, string color, string modelo) : base(hp, color)
        {
            Modelo = modelo; 
        }

        // Methods

        public new void mostrarDetalles()
        {
            Console.WriteLine("Marca: {0}\nModelo: {1}\nHP: {2}\nColor: {3}",Marca, Modelo, Hp, Color);
        }

        public override void reparar()
        {
            Console.WriteLine("Auto {0} Reparado", Modelo);
        }
    }
}

```

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // var listaAutos = new List<Auto>();
            // Auto bmw = new BMW(250, "Rojo", "M3");
            // Auto audi = new Audi(200, "Blanco", "A3");
            // bmw.mostrarDetalles();
            // audi.mostrarDetalles();
            var listaAutos = new List<Auto>
            {
                new BMW(250, "Rojo", "M3"),
                new Audi(200, "Blanco", "A3")
            };

            foreach(var auto in listaAutos)
            {
                auto.mostrarDetalles();
                auto.reparar();
            }
            
            Console.WriteLine("+++++++++++++");
            BMW bmw = new BMW(250, "Verde", "Z3");
            Auto audi = new Audi(100, "Azul", "A1");
            bmw.mostrarDetalles();
            audi.mostrarDetalles();

            Console.WriteLine("+++++++++++++");
            Auto autoB = (Auto)bmw;
            autoB.mostrarDetalles();

            Console.ReadLine();
        }
    }
}

```

## [Return to index](/README.md)