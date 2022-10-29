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
