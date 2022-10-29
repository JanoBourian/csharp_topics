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
