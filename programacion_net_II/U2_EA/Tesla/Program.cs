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
            double presupuesto = 1000000.0;
            Console.WriteLine("Presupuesto incial {0}", presupuesto);
            // creación de un Auto
            Auto auto = new Auto();
            presupuesto  = auto.crearAuto(presupuesto);

            // creación de una Camioneta
            Camioneta camioneta = new Camioneta();
            presupuesto = camioneta.crearCamioneta(presupuesto);

            // creación de una Van
            Van van = new Van();
            presupuesto = van.crearVan(presupuesto);

            Console.WriteLine("Presupuesto Final {0}", presupuesto);

            // Creamos una Armadora
            Armadora armadora_1 = new Armadora(950000);

            // Verificamos los presupuestos desde Enero (1) hasta Diciembre (12)
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine("El presupuesto para el mes {0} es de {1}", i, armadora_1.presupuestoMes(i));
            }

            Console.WriteLine("Piezas para Abril");
            armadora_1.piezas(4);
            Console.WriteLine("*****************");

            // Ahora vemos cuántos de cada uno por mes
            for (int i = 1; i <= 12; i++)
            {
                armadora_1.piezas(i);
                Console.WriteLine("*****************");
            }

            Console.ReadLine();
        }
    }
}
