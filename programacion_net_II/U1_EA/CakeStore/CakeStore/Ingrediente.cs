using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    class Ingrediente
    {
        
        // Atributos 
        public string nombreIngrediente;
        public string tipo;
        public double medidaRendimiento;
        public double calorias;
        public double precio;

        // Constructor con los datos mínimos del Ingrediente
        public Ingrediente(string nombreIngrediente, string tipo)
        {
            this.nombreIngrediente = nombreIngrediente;
            this.tipo = tipo;
        }

        /* Métodos set y get */

        public double MedidaRendimiento
        {
            get => this.medidaRendimiento;
            set
            {
                if (value >= 0.1 && value <= 1 )
                {
                    this.medidaRendimiento = value;
                }
                else
                {
                    Console.WriteLine("Valor Inválido para la medida de rendimiento, se asignará el rendimiento menor posible");
                    this.medidaRendimiento = 0.1;
                }
            }
        }

        public double Calorias
        {
            get => this.calorias;
            set => this.calorias = value;
        }

        public double Precio
        {
            get => this.precio;
            set => this.precio = value;
        }

        /* Métodos multipropósito */

        // Informacion del Ingrediente
        public void informacion()
        {
            Console.WriteLine("\nNombre: {0}\nTipo: {1}\nRendimiento: {2}\nCalorias: {3}\nPrecio: {4}\n********\n", this.nombreIngrediente, this.tipo, this.MedidaRendimiento, this.Calorias, this.Precio);
        }
    }
}
