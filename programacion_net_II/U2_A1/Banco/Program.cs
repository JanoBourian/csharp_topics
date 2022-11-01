using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaCuentasAhorro = new List<CuentaAhorro>();
            var listaCuentasCorriente = new List<CuentaCorriente>();
            int opcion = 1;
            while (opcion >= 1 & opcion <= 9){
                Console.WriteLine("Digite la opcion necesaria: ");
                Console.WriteLine("1.- Crear Cuenta Ahorro");
                Console.WriteLine("2.- Crear Cuenta Corriente");
                Console.WriteLine("3.- Borrar Cuenta Ahorro");
                Console.WriteLine("4.- Borrar Cuenta Corriente");
                Console.WriteLine("5.- Mostrar Cuentas Ahorro Almacenadas");
                Console.WriteLine("6.- Mostrar Cuentas Corrientes Almacenadas");
                Console.WriteLine("7.- Aplicar fecha de Pago a Cuentas Ahorro");
                Console.WriteLine("8.- Aplicar fecha de Cobro a Cuentas Corrientes");
                Console.WriteLine("9.- Salir");
                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Crear Cuenta Ahorro");
                        crearCuentaAhorro(listaCuentasAhorro);
                        Console.WriteLine("******************");
                        break;
                    case 2:
                        Console.WriteLine("Crear Cuenta Corriente");
                        crearCuentaCorriente(listaCuentasCorriente);
                        Console.WriteLine("******************");
                        break;
                    case 3:
                        Console.WriteLine("Borrar Cuenta Ahorro");
                        borrarCuentaAhorro(listaCuentasAhorro);
                        Console.WriteLine("******************");
                        break;
                    case 4:
                        Console.WriteLine("Borrar Cuenta Corriente");
                        borrarCuentaCorriente(listaCuentasCorriente);
                        Console.WriteLine("******************");
                        break;
                    case 5:
                        Console.WriteLine("Mostrar Cuentas Ahorro Almacenadas");
                        mostrarCuentasAhorro(listaCuentasAhorro);
                        Console.WriteLine("******************");
                        break;
                    case 6:
                        Console.WriteLine("Mostrar Cuentas Ahorro Almacenadas");
                        mostrarCuentasCorriente(listaCuentasCorriente);
                        Console.WriteLine("******************");
                        break;
                    case 7:
                        Console.WriteLine("Aplicar fecha de Pago a Cuentas Ahorro");
                        aplicarPago(listaCuentasAhorro);
                        Console.WriteLine("******************");
                        break;
                    case 8:
                        Console.WriteLine("Aplicar fecha de Cobro a Cuentas Corrientes");
                        aplicarCobro(listaCuentasCorriente);
                        Console.WriteLine("******************");
                        break;
                    case 9:
                        Console.WriteLine("Salir");
                        opcion = 0;
                        Console.WriteLine("******************");
                        break;
                    default:
                        Console.WriteLine("Elija una opción numérica correcta");
                        break;
                }
            }
            Console.WriteLine("BYE!");
            Console.ReadLine();
        }

        public static void crearCuentaAhorro(List<CuentaAhorro> listaCuentas)
        {
            int id = listaCuentas.Count;
            string tipo = "Cuenta Ahorro";
            Console.Write("Ingresa el saldo de esta cuenta: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la fecha de Ahorro: ");
            string fechaAhorro = Console.ReadLine();
            Console.Write("Ingresa la ganancia mensual: ");
            double gananciaMensual = Convert.ToDouble(Console.ReadLine());

            CuentaAhorro cuenta = new CuentaAhorro(id + 1, tipo, saldo, fechaAhorro, gananciaMensual);
            listaCuentas.Add(cuenta);
        }

        public static void crearCuentaCorriente(List<CuentaCorriente> listaCuentas)
        {
            int id = listaCuentas.Count;
            string tipo = "Cuenta Corriente";
            Console.Write("Ingresa el saldo de esta cuenta: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa la fecha de Pago: ");
            string fechaPago = Console.ReadLine();
            Console.Write("Ingresa la comisión por Pago: ");
            double comisionPago = Convert.ToDouble(Console.ReadLine());

            CuentaCorriente cuenta = new CuentaCorriente(id + 1, tipo, saldo, fechaPago, comisionPago);
            listaCuentas.Add(cuenta);
        }

        public static void borrarCuentaAhorro(List<CuentaAhorro> listaCuentas)
        {
            int cuentasAlmacenadas = listaCuentas.Count;
            Console.WriteLine("Se tienene {0} cuentas almacenadas", cuentasAlmacenadas);
            if (cuentasAlmacenadas> 0)
            {
                Console.Write("Qué número de cuenta desea borrar: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int index = numero - 1;
                Console.WriteLine("1.- Sobregiro\n2.-Indicación del cuentahabiente\n3.-Defunción del cuentahabiente");
                Console.Write("Digite la opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                listaCuentas[index].cerrarCuenta(opcion-1);
                listaCuentas.RemoveAt(index);
                Console.WriteLine("Cuenta removida con éxito!");
            }
            else
            {
                Console.WriteLine("No hay cuentas almacenadas!");
            }
        }

        public static void borrarCuentaCorriente(List<CuentaCorriente> listaCuentas)
        {
            int cuentasAlmacenadas = listaCuentas.Count;
            Console.WriteLine("Se tienene {0} cuentas almacenadas", cuentasAlmacenadas);
            if (cuentasAlmacenadas > 0)
            {
                Console.Write("Qué número de cuenta desea borrar: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int index = numero - 1;
                Console.WriteLine("1.- Sobregiro\n2.-Indicación del cuentahabiente\n3.-Defunción del cuentahabiente");
                Console.Write("Digite la opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                listaCuentas[index].cerrarCuenta(opcion - 1);
                listaCuentas.RemoveAt(index);
                Console.WriteLine("Cuenta removida con éxito!");
            }
            else
            {
                Console.WriteLine("No hay cuentas almacenadas!");
            }
        }

        public static void mostrarCuentasAhorro(List<CuentaAhorro> listaCuentas)
        {
            for(int i = 0; i< listaCuentas.Count; i++)
            {
                listaCuentas[i].mostrarInformacion();
            }
        }

        public static void mostrarCuentasCorriente(List<CuentaCorriente> listaCuentas)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                listaCuentas[i].mostrarInformacion();
            }
        }

        public static void aplicarPago(List<CuentaAhorro> listaCuentas)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                listaCuentas[i].beneficios();
            }
        }

        public static void aplicarCobro(List<CuentaCorriente> listaCuentas)
        {
            for (int i = 0; i < listaCuentas.Count; i++)
            {
                listaCuentas[i].comision();
            }
        }
    }
}
