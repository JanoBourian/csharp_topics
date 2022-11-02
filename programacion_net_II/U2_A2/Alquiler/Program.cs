using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clientes 
            ClientePreferencial cliente_1 = new ClientePreferencial();
            ClienteOcasional cliente_2 = new ClienteOcasional();

            cliente_1.valorTotal(350, 2);
            cliente_2.valorTotal(25, 8);

            Console.ReadLine();

        }
    }
}
