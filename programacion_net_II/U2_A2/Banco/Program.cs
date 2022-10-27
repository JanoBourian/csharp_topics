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
            // Little test
            CuentaAhorro cuenta_bancaria = new CuentaAhorro(1, "padre", 300.0, "26/10/2022", 30.5);
            cuenta_bancaria.mostrarInformacion();
            cuenta_bancaria.informacionCuentaAhorro();
            simularBorrado(cuenta_bancaria);
            Console.ReadLine();

            /* En qué consiste esta prueba:
             * Sabemos que CuentaBancaria no es posible instanciarla porque es abstract,
             * esto me deja con CuentaBancaria y CuentaCorriente para probar. A continuación indico los pasos
             * a seguir para realizar las pruebas de las clases.
             *
             *  - Crear CuentaAhorro
             *  - Mostrar Información de la Cuenta creada desde el método Heredado
             *  - Mostrar Información de la Cuenta creada desde el método implementado en la clase 
             *  - Agregar un Beneficio (como si hubiese pasado el periodo correspondiente)
             *  - Mostrar la información del Saldo
             *  - Agregar otro beneficio 
             *  - Mostrar la información del Saldo
             *  - Simular la terminacion de la cuenta con base en la opción solicitada, 
             *      para ello programé una clase aquí que pregunta la opción de cerrar cuenta.
             *      
             *  - Crear CuentaCorriente
             *  - Mostrar Información de la Cuenta creada desde el método Heredado
             *  - Mostrar Información de la Cuenta creada desde el método implementado en la clase 
             *  - Agregar una Comisión (como si hubiese pasado el periodo correspondiente)
             *  - Mostrar la información del Saldo
             *  - Agregar otra Comisión
             *  - Mostrar la información del Saldo
             *  - Simular la terminacion de la cuenta con base en la opción solicitada, 
             *      para ello programé una clase aquí que pregunta la opción de cerrar cuenta.
             * */

        }

        public static void simularBorrado(CuentaBancaria ahorro)
        {
            Console.WriteLine("Vas a borrar tu cuenta {0}", ahorro.Numero);
            Console.WriteLine("1.- SobreGiro\n2.- Indicación del cuentahabiente\n3.- Defunción del cuenta habiente");
            Console.Write("Ingresa la opción numérica correspondiente: ");
            string opcion = Console.ReadLine();
            ahorro.cerrarCuenta(Int32.Parse(opcion)-1);

        }
    }
}
