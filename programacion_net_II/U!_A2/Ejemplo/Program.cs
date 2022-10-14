using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Paquete paquete_basico = new Paquete("Teclado");
            Paquete paquete_complejo = new Paquete("Televisión", "Contenedor");

            string[] destinos = { "Valladolid", "Mérida", "Plata del Carmen" };
            paquete_basico.DeterminarDestino(destinos);
            Console.WriteLine();
            paquete_complejo.DeterminarDestino("CDMX");
            Console.ReadLine();
        }
    }
}
