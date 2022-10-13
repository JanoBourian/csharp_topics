using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("MENÚ INTERACTIVO PARA REALIZAR UN SÓLO PEDIDO!");
            Console.Write("Hola. Comencemos, indícame el número de ingredientes que ingresarás para esta preparación: ");
            string aux = Console.ReadLine();
            int size = Convert.ToInt32(aux);
            Ingrediente[] listaIngredientes = new Ingrediente[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Ingresa el nombre del ingrediente: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingresa el nombre del Tipo: ");
                string tipo = Console.ReadLine();
                listaIngredientes[i] = new Ingrediente(nombre, tipo);
                Console.WriteLine("*********");
            }

            Console.WriteLine("Vamos a realizar el pastel!");
            p.mostrarListaIngredientes(listaIngredientes);

            Pastel pastel = new Pastel();
            pastel.RealizarPedido(listaIngredientes);
            Console.WriteLine("Información del pedido:");
            pastel.caloriasTotalesPastel();
            pastel.costoTotalPastel();
            pastel.cantidadIngredientes();

            Console.Write("Deseas revisar los ingredientes (NO pulsa 1, Sí cualquier otra): ");
            string respuesta = Console.ReadLine();
            if(respuesta == "1")
            {
                for(int i = 0; i < listaIngredientes.Length; i++)
                {
                    p.RevisarIngrediente(listaIngredientes[i], pastel.peso);
                    p.RevisarIngrediente(listaIngredientes[i]);
                }
            }

            Console.WriteLine("SOLICITUD RECIBIDA CORRECTAMENTE!");
            Console.ReadLine();
        }

        public void mostrarListaIngredientes(Ingrediente[] listaIngredientes) 
        {
            int size = listaIngredientes.Length;
            Console.WriteLine("Recuerda que tenemos los siguientes {0} Ingredientes: ", size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}.- {1} DE TIPO {2}", i+1, listaIngredientes[i].nombreIngrediente, listaIngredientes[i].tipo);
            }
            Console.WriteLine("***********");
        }

        // Sobrecarga de métodos
        public void RevisarIngrediente(Ingrediente ingrediente, double peso)
        {
            Console.WriteLine("Las calorias aportadas por {0} son de {1}", ingrediente.nombreIngrediente, (ingrediente.MedidaRendimiento*ingrediente.Calorias*peso)/2);
        }
        public void RevisarIngrediente(Ingrediente ingrediente)
        {
            ingrediente.informacion();
        }
    }
}
