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

            // Probando insertar y mostrar primera aparación new 52
            WonderWoman.PrimeraAparicionNew52 = "Wonder Woman v4 #1 Sept. 2011";
            Console.WriteLine("Primera Aparición New 52: {0}", WonderWoman.PrimeraAparicionNew52);

            // Probando insertar y mostrar total poderes
            WonderWoman.TotalPoderes = new string [6] { "vuelo", "Super fuerza", "Inmortalidad", "Super velocidad", "Brazaletes indestructibles", "Lazo magico de la verdad"};

            // Probando insertar y mostrar artista
            WonderWoman.Artista = "William Moulton Marston";
            Console.WriteLine("Artista: {0}", WonderWoman.Artista);

            // Probando insertar y mostrar Creador
            WonderWoman.Creador = "Harry G. Peter";
            Console.WriteLine("Creador: {0}", WonderWoman.Creador);

            // Probando insertar y mostrar Es Humano
            WonderWoman.EsHumano = true;
            Console.WriteLine("El personaje es humano: {0}", WonderWoman.EsHumano);


            // Ficha técnica
            WonderWoman.fichaTecnica();

            // Estado Actual
            WonderWoman.estadoActual();

            // Primera Pelea
            WonderWoman.pelea();
            // Primer ataque
            WonderWoman.ataque();

            // Estado Actual después de la primer peleas
            WonderWoman.estadoActual();


            // Segunda Pelea
            WonderWoman.pelea();
            // Segundo ataque
            WonderWoman.ataque();

            // Estado Actual después de la segunda pelea
            WonderWoman.estadoActual();

            Console.ReadLine();
        }
    }
}
