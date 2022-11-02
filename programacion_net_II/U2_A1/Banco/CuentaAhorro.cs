using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaAhorro : CuentaBancaria
    {
        private string fechaAhorro;
        private double gananciaMensual;

        public string FechaAhorro
        {
            get => this.fechaAhorro;
            set => this.fechaAhorro = value;
        }
        public double GananciaMensual
        {
            get => this.gananciaMensual;
            set => this.gananciaMensual = value;
        }
        public CuentaAhorro(int numero, string tipo, double saldo, string fechaAhorro, double gananciaMensual) : base(numero, tipo, saldo)
        {
            FechaAhorro = fechaAhorro;
            GananciaMensual = gananciaMensual;
        }

        public void beneficios()
        {
            Saldo += GananciaMensual;
        }

        new public void mostrarInformacion() // Método mostrar información
        {
            Console.WriteLine("Numero: {0}\nTipo: {1}\nSaldo: {2}", Numero, Tipo, Saldo);
            Console.WriteLine("Fecha Ahorro: {0}\nGanancia Mensual: {1}", FechaAhorro, GananciaMensual);
        }
    }
}
