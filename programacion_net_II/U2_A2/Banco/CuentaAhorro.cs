using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaAhorro: CuentaBancaria
    {
        private string fechaAhorro;
        private double gananciaMensual;

        public string FechaAhorro { 
            get => this.fechaAhorro; 
            set => this.fechaAhorro = value; 
        }
        public double GananciaMensual { 
            get => this.gananciaMensual; 
            set => this.gananciaMensual = value; 
        }
        public CuentaAhorro(int numero, string tipo, double saldo, string fechaAhorro, double gananciaMensual): base(numero, tipo, saldo)
        {
            FechaAhorro = fechaAhorro;
            GananciaMensual = gananciaMensual;
        }

        public void beneficios()
        {
            Saldo += GananciaMensual;
        }

        public void informacionCuentaAhorro()
        {
            mostrarInformacion();
            Console.WriteLine("Fecha Ahorro: {0}\nGanancia Mensual: {1}", FechaAhorro, GananciaMensual);
        }
    }
}
