using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    class Van : Vehiculo
    {
        private int numeroPanel = 8;
        private int numeroBateria = 14;
        private int numeroCableado = 4;
        private int numeroModulo = 3;
        private int numeroMotores = 3;
        private int numeroLaminados = 1;

        public double crearVan(double presupuesto)
        {
            // Una vez que se crea se reduce el costo del presupuesto mensual
            return presupuesto - costoVan();
        }

        public double costoVan()
        {
            return numeroPanel * costoPanel + numeroBateria * costoBateria + numeroCableado * costoCableado + numeroModulo * costoModulo + numeroMotores * costoMotor + numeroLaminados * costoAcabado;
        }
    }
}
