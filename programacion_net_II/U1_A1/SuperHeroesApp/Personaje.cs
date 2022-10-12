using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    class Personaje
    {
        /*
        Clase Personaje que abstrae la información que, con base en los cuatro personajes mostrados
        es común para ellos sin afectar sus diversas funcionalidades.
         */

        /* Atributos */

        // Atributos abstracción
        private string nombrePersonaje;
        private string nombreReal;
        private string primeraAparicionNew52;
        private string[] totalPoderes;
        private int numeroTotalPoderes;
        private string artista;
        private string creador;


        // Atributos indicados en la actividad
        private bool esHumano;
        private double puntosDeExperiencia = 1.0;
        private double nivelFisico = 10.0;
        private double nivelCansancio = 0.0;
        private int peleasHoy = 0;


        /* Constructor */
        public Personaje(string nombrePersonaje, string nombreReal, string artista, string creador)
        {
            this.nombrePersonaje = nombrePersonaje;
        }


        /* Encapsulamiento */
        public string NombrePersonaje
        {
            get => this.nombrePersonaje;
        }
        public string NombreReal
        {
            get => this.nombreReal;
            set => this.nombreReal = value;
        }
        public string PrimeraAparicionNew52
        {
            get => this.primeraAparicionNew52;
            set => this.primeraAparicionNew52 = value;
        }
        public int NumeroTotalPoderes
        {
            get => this.numeroTotalPoderes;
            set => this.numeroTotalPoderes = value;
        }
        public string Artista
        {
            get => this.artista;
            set => this.artista = value;
        }
        public string Creador
        {
            get => this.creador;
            set => this.creador = value;
        }
        public bool EsHumano
        {
            get => this.esHumano;
            set => this.esHumano = value;
        }
        public string[] TotalPoderes
        {
            set => this.totalPoderes = value;
        }

        /* Métodos generales */
        
        // Saludo para después de la inicialización
        public void saludar()
        {
            Console.WriteLine("Soy {0}", this.nombrePersonaje);
        }

        // Retorna la Ficha Técnica
        public void fichaTecnica()
        {
            // Regresa los datos técnicos del personaje con base en la información proporcionada en la actividad
            Console.WriteLine(
                "Nombre Personaje: {0}\nNombre Real: {1}\nPrimera Aparicion New 52: {2}\nArtista: {3}\nCreador: {4}\nEs humano: {5}\n",
                this.nombrePersonaje, this.nombreReal, this.primeraAparicionNew52, this.artista, this.creador, this.esHumano
                );
        }

        public void estadoActual()
        {
            // Regresa los valores relevantes a la pelea.
            Console.WriteLine(
                "Puntos de Experiencia: {0}\nNivel Fisico: {1}\nNivel Cansancio: {2}\nPeleas Hoy: {3}\n",
                this.puntosDeExperiencia, this.nivelFisico, this.nivelCansancio, this.peleasHoy
                );
        }

        // Modificar los puntos de experiencia
        public void pelea()
        {
            // Aquí se modifican todos los valores cada vez que se pelea
            if (this.peleasHoy < 10)
            {
                this.peleasHoy++;
                this.puntosDeExperiencia += 0.02;
                this.nivelCansancio += 0.3;
                this.nivelFisico -= 0.3;

            }
            else
            {
                Console.WriteLine("No es posible que {0} siga peleando", this.nombrePersonaje);
            }
        }

        // Método Ataque
        public void ataque()
        {
            string currentPower = this.returnPoder();
            double realDamage = (this.puntosDeExperiencia*this.nivelFisico*0.8) - this.nivelCansancio;
            Console.WriteLine("Se Ataca con {0} con un Daño Real de {1}", currentPower, realDamage);
        }

        // Seleccionar de manera aleatoria un poder
        public string returnPoder()
        {
            /* para este método se toma el valor del tamaño del array de poderes y con ello
             * se selecciona un número aleatorio entre 0 y (tamaño - 1) para seleccionar un 
             * poder al azar*/
            Random random = new Random();
            int indice = random.Next(0, this.totalPoderes.Length - 1);
            return totalPoderes[indice];
        }



    }
}
