using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje WonderWoman = new Personaje("Wonder Woman", "Princesa Diana de Temiscira", "William Moulton Marston", "Harry G. Peter");
            WonderWoman.saludar();
            // Probando insertar y mostrar el nombre real
            WonderWoman.NombreReal = "Princesa Diana de Temiscira";
            Console.WriteLine("Nombre real del personaje {0} es {1}", WonderWoman.NombreReal, WonderWoman.NombrePersonaje);
            // Probando insertar y mostrar 

            // Ficha técnica
            WonderWoman.fichaTecnica();

            // Estado Actual
            WonderWoman.estadoActual();

            Console.ReadLine();
        }
    }
}
