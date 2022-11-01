using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Menu
    {
        // Declaro una lista de cuentas
        private var listaCuentas = new List<CuentaBancaria>();

        public string menuOpciones()
        {
            Console.WriteLine("Digite la opcion necesaria: ");
            Console.WriteLine("1.- Crear Cuenta Ahorro");
            Console.WriteLine("2.- Crear Cuenta Corriente");
            Console.WriteLine("3.- Borrar Cuenta Ahorro");
            Console.WriteLine("4.- Borrar Cuenta Corriente");
            Console.WriteLine("5.- Mostrar Cuentas de Ahorro almacenadas");
            Console.WriteLine("6.- Mostrar Cuentas Corrientes almacenadas");
            Console.WriteLine("7.- Salir");
            Console.Write("Opcion: ");
            return Console.ReadLine();
        }

        public void validateOpcion(string opcion)
        {
            int number;
            if (int.TryParse(opcion, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Crear Cuenta Ahorro");
                        crearCuentaAhorro();
                        manejadorOpcionesMenu();
                        break;
                    case 2:
                        Console.WriteLine("Crear Cuenta Corriente");
                        manejadorOpcionesMenu();
                        break;
                    case 3:
                        Console.WriteLine("Borrar Cuenta Ahorro");
                        manejadorOpcionesMenu();
                        break;
                    case 4:
                        Console.WriteLine("Borrar Cuenta Corriente");
                        manejadorOpcionesMenu();
                        break;
                    case 5:
                        Console.WriteLine("Mostrar Información de todas las cuentas de Ahorro!");
                        mostrarCuentasAlmacenadas();
                        manejadorOpcionesMenu();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Opción no existe, intenta de nuevo!");
                        manejadorOpcionesMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida!");
                manejadorOpcionesMenu();
            }
        }

        public void manejadorOpcionesMenu()
        {
            string newOption = menuOpciones();
            validateOpcion(newOption);
        }

        // crearCuentaAhorro
        public void crearCuentaAhorro()
        {
            int id = this.listaCuentas.Count;
            string tipo = "Cuenta de Ahorro";
            Console.Write("Ingrese el Saldo: ");
            string valor = Console.ReadLine();
            double saldo = double.Parse(valor);
            Console.Write("Escriba la Fecha Ahorro: ");
            string fechaAhorro = Console.ReadLine();
            Console.Write("Escriba la ganancia mensual: ");
            string ganancia = Console.ReadLine();
            double gananciaMensual = double.Parse(ganancia);
            CuentaAhorro cuenta = new CuentaAhorro(id +1, tipo, saldo, fechaAhorro, gananciaMensual);
            listaCuentas.Add(cuenta);
        }
        // crearCuentaCorriente

        // borrarCuentaAhorro

        // borrarCuentaCorriente

        // mostratCuentasAlmacenadas
        public void mostrarCuentasAlmacenadas()
        {
            foreach (var cuenta in listaCuentas)
            {
                //Console.WriteLine(cuenta.mostrarInformacion());
                Console.WriteLine(cuenta.mostrarInformacion());
            }
        }
    }
}
