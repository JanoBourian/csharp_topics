using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    abstract class CuentaBancaria
    {
        // Propiedades protegidas para ser accesadas
        protected int numero;
        protected string tipo;
        protected double saldo;

        // Accesos a las propiedades
        public int Numero
        {
            get => this.numero;
            set => this.numero = value;
        }
        public string Tipo
        {
            get => this.tipo;
            set => this.tipo = value;
        }
        public double Saldo
        {
            get => this.saldo;
            set => this.saldo = value;
        }

        public CuentaBancaria(int numero, string tipo, double saldo) // Constructor
        {
            Numero = numero;
            Tipo = tipo;
            Saldo = saldo;
        }

        public void mostrarInformacion() // Método mostrar información
        {
            Console.WriteLine("Numero: {0}\nTipo: {1}\nSaldo: {2}", Numero, Tipo, Saldo);
        }

        public void cerrarCuenta(int opcion) // Cerrar cuenta con parámetro
        {
            string[] motivos = new string[] { "Sobregiro", "Indicación del cuentahabiente", "Defunción del cuentahabiente" };
            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Opcion {0}", motivos[opcion]);
                    break;
                case 1:
                    Console.WriteLine("Opcion {0}", motivos[opcion]);
                    break;
                case 2:
                    Console.WriteLine("Opcion {0}", motivos[opcion]);
                    break;
                default:
                    Console.WriteLine("Incorrect option!");
                    break;
            }
        }

    }
}