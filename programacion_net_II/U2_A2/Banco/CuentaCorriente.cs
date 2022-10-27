using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaCorriente: CuentaBancaria
    {
        private string fechaPago;
        private double comisionPago;

        public string FechaPago { 
            get => this.fechaPago; 
            set => this.fechaPago = value; 
        }

        public double ComisionPago { 
            get => this.comisionPago; 
            set => this.comisionPago = value; 
        }

        public CuentaCorriente(int numero, string tipo, double saldo, string fechaPago, double comisionPago) : base(numero, tipo, saldo)
        {
            FechaPago = fechaPago;
            ComisionPago = comisionPago;
        }

        public void informacionCuentaAhorro()
        {
            mostrarInformacion();
            Console.WriteLine("Fecha Pago: {0}\nComision Pago: {1}", FechaPago, ComisionPago);
        }
        
        public void comision()
        {
            Saldo -= ComisionPago;
        }
    }
}
