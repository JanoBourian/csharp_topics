using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    class Auto: Vehiculo
    {
        private int numeroPanel = 6;
        private int numeroBateria = 9;
        private int numeroCableado = 2;
        private int numeroModulo = 1;
        private int numeroMotores = 2;
        private int numeroLaminados = 1;

        public double crearAuto(double presupuesto)
        {
            // Una vez que se crea se reduce el costo del presupuesto mensual
            return presupuesto - costoAuto();
        }

        public double costoAuto()
        {
            return numeroPanel * costoPanel + numeroBateria * costoBateria + numeroCableado * costoCableado + numeroModulo * costoModulo + numeroMotores * costoMotor + numeroLaminados * costoAcabado;
        }
    }
}
