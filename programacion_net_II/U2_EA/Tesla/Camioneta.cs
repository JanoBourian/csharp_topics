using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    class Camioneta: Vehiculo
    {
        private int numeroPanel = 10;
        private int numeroBateria = 15;
        private int numeroCableado = 5;
        private int numeroModulo = 3;
        private int numeroMotores = 3;
        private int numeroLaminados = 1;

        public double crearCamioneta(double presupuesto)
        {
            // Una vez que se crea se reduce el costo del presupuesto mensual
            return presupuesto - costoCamioneta();
        }

        public double costoCamioneta()
        {
            return numeroPanel * costoPanel + numeroBateria * costoBateria + numeroCableado * costoCableado + numeroModulo * costoModulo + numeroMotores * costoMotor + numeroLaminados * costoAcabado;
        }
    }
}
