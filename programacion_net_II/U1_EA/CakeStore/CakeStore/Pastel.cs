using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    class Pastel
    {
        // Atributos
        public string[] secciones = { "Relleno", "Pan", "Cubierta superior", "Flan", "Dedicatoria" };
        public Ingrediente[] ingredientesRelleno;
        public double peso;
        public double rendimiento;
        public double costo; 

        /* Métodos set y get */
        

        /* Métodos multipropósito */
        // Para realizar el pedido
        public void RealizarPedido(Ingrediente[] listaIngredientes)
        {
            Console.Write("Ingresa por favor el peso del pastel: ");
            string aux = Console.ReadLine();
            this.peso = Convert.ToDouble(aux);

            Console.Write("Ingresa por favor el rendimiento del pastel: ");
            aux = Console.ReadLine();
            this.rendimiento = Convert.ToDouble(aux);

            Console.Write("Ingresa por favor el costo del pastel: ");
            aux = Console.ReadLine();
            this.costo = Convert.ToDouble(aux);

            // Se agregan la lista de ingredientes
            this.ingredientesRelleno = listaIngredientes;


            for(int i = 0; i < listaIngredientes.Length; i++)
            {
                Console.WriteLine("****\n");
                Console.WriteLine("Ingrese información para el ingrediente {0}: ", this.ingredientesRelleno[i].nombreIngrediente);
                Console.Write("Ingresa por favor la medida de rendimiento (recuerda 0.1 <= rendimiento <= 1): ");
                aux = Console.ReadLine();
                this.ingredientesRelleno[i].MedidaRendimiento = Convert.ToDouble(aux);

                Console.Write("Ingresa por favor las calorias: ");
                aux = Console.ReadLine();
                this.ingredientesRelleno[i].Calorias = Convert.ToDouble(aux);

                Console.Write("Ingresa por favor el precio: ");
                aux = Console.ReadLine();
                this.ingredientesRelleno[i].Precio = Convert.ToDouble(aux);

                this.ingredientesRelleno[i].informacion();
            }
            Console.WriteLine("****\n");
        }

        // Calorias totales
        public void caloriasTotalesPastel()
        {
            double caloriasTotales = 0.0;
            for (int i = 0; i < this.ingredientesRelleno.Length; i++)
            {
                caloriasTotales += this.ingredientesRelleno[i].Calorias;
            }
            Console.WriteLine("Las calorias que suman cada ingrediente en este pastel son: {0}", caloriasTotales);
        }

        // Costo total
        public void costoTotalPastel()
        {
            for (int i = 0; i < this.ingredientesRelleno.Length; i++)
            {
                this.costo += this.ingredientesRelleno[i].Precio;
            }
            Console.WriteLine("El costo total del pastel y los ingredientes es de: {0}", this.costo);
        }

        // Cantidad de ingredientes
        public void cantidadIngredientes()
        {
            Console.WriteLine("Lista de ingredientes: ");
            for (int i = 0; i < this.ingredientesRelleno.Length; i++)
            {
                Console.WriteLine("Ingrediente {0}: ", i + 1);
                this.ingredientesRelleno[i].informacion();
                Console.WriteLine("**********");
            }
        }
    }
}
