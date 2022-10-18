using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones;
            Console.Write("¿Cuántos elementos ingresarás?: ");
            int elementos = Int32.Parse(Console.ReadLine());
            calificaciones = new int[elementos];
            for(int i = 0; i < elementos; i++)
            {
                Console.Write("Ingresa la calificación para el alumno {0}: ", i + 1);
                int calificacion = Int32.Parse(Console.ReadLine());
                calificaciones[i] = calificacion;
            }
            Console.WriteLine("EL tamaño del arreglo es de {0}", calificaciones.Length);
            foreach(int k in calificaciones)
            {
                Console.WriteLine("Ingresa la calificación para el alumno es: {0}", k);
            }

            Console.ReadLine();
        }
    }
}