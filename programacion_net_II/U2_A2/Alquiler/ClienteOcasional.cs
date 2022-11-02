using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    class ClienteOcasional: Cliente
    {
        public override void valorTotal(double kmRecorridos, double valorKm)
        {
            double valorTotal = kmRecorridos * valorKm;
            Console.WriteLine("El pago para este Cliente Ocasional es de {0}", valorTotal);
        }
    }
}
