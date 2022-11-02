using System;


namespace Ejemplo
{
    class Paquete
    {
        public string tipo;
        public string nombre;

        public Paquete(string nombre)
        {
            this.nombre = nombre;
            this.tipo = "caja";
        }

        public Paquete(string nombre, string tipo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
        }

        public void DeterminarDestino(string[] rutas)
        {
            Console.Write("Pasará por: ");
            for(int i = 0; i < rutas.Length; i++)
            {
                Console.Write("{0} ", rutas[i]);
            }
        }

        public void DeterminarDestino(string rutas)
        {
            Console.Write("Pasará por: {0}", rutas);
        }

    }
}
