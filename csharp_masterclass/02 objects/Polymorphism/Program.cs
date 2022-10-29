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
