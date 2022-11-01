using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declaro una lista de cuentas
            private var listaCuentas = new List<CuentaBancaria>();
            mostrarOpciones();
            string captura = Console.ReadLine();
            int number;
            if (int.TryParse(captura, out number))
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
            Console.WriteLine("BYE!");
            Console.ReadLine();
        }

    public static void mostrarOpciones()
    {
        Console.WriteLine("Digite la opcion necesaria: ");
        Console.WriteLine("1.- Crear Cuenta Ahorro");
        Console.WriteLine("2.- Crear Cuenta Corriente");
        Console.WriteLine("3.- Borrar Cuenta Ahorro");
        Console.WriteLine("4.- Borrar Cuenta Corriente");
        Console.WriteLine("5.- Mostrar Cuentas Almacenadas");
        Console.WriteLine("6.- Salir");
        Console.Write("Opcion: ");
    }

    }
}
