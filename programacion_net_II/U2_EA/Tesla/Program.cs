using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos una Armadora
            Armadora armadora_1 = new Armadora(950000);

            // Verificamos los presupuestos desde Enero (1) hasta Diciembre (12)
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine("El presupuesto para el mes {0} es de {1}", i, armadora_1.presupuestoMes(i));
            }

            // Ahora vemos cuántos de cada uno por mes
            for(int i = 1; i <= 12; i++)
            {
                armadora_1.piezas(i);
                Console.WriteLine("*****************");
            }

            Console.ReadLine();
        }
    }
}
