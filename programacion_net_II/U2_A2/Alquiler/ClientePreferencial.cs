﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    class ClientePreferencial: Cliente
    {
        public override void valorTotal(double kmRecorridos, double valorKm)
        {
            double valorTotal = kmRecorridos * valorKm * .85;
            Console.WriteLine("El pago para este Cliente Preferencial es de {0}", valorTotal);
        }
    }
}
