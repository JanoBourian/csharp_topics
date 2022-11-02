using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    class Armadora
    {
        private double presupuestoBase;

        public double PresupuestoBase { 
            get => this.presupuestoBase; 
            set => this.presupuestoBase = value; 
        }

        public Armadora(double presupuesto)
        {
            PresupuestoBase = presupuesto;
        }

        public double presupuestoMes(int mes)
        {
            return PresupuestoBase  + PresupuestoBase* (0.15) * (mes - 1);
        }

        public void piezas(int mes)
        {
            double presupuestoMensual = presupuestoMes(mes);
            int totalAutos = 0;
            int totalCamionetas = 0;
            int totalVan = 0;
            // Debido a que no hay restricciones de cuántos vehículos de cada tipo se deben 
            // construir por mes, supondré la construcción de uno de cada unos en la siguiente Secuencia
            // Auto - Camioneta - Van. Además la siguiente condición es que el presupuesto no se puede 
            // guardar para el siguiente mes. 
            int tipo = 1; 
            while (presupuestoMensual > 0)
            {
                switch (tipo)
                {
                    case 1:
                        Auto autoActual = new Auto();
                        if(esPosible(presupuestoMensual, autoActual.costo()))
                        {
                            presupuestoMensual = autoActual.crearAuto(presupuestoMensual);
                            totalAutos += 1;
                        }
                        else
                        {
                            presupuestoMensual = 0; // Se da por hecho que se agotó porque vamos creando en secuencia
                        }
                        tipo = 2; 
                        break;
                    case 2:
                        Camioneta camionetaActual = new Camioneta();
                        if (esPosible(presupuestoMensual, camionetaActual.costo()))
                        {
                            presupuestoMensual = camionetaActual.crearCamioneta(presupuestoMensual);
                            totalCamionetas += 1;
                        }
                        else
                        {
                            presupuestoMensual = 0; // Se da por hecho que se agotó porque vamos creando en secuencia
                        }
                        tipo = 3; 
                        break;
                    default:
                        Van vanActual = new Van();
                        if (esPosible(presupuestoMensual, vanActual.costo()))
                        {
                            presupuestoMensual = vanActual.crearVan(presupuestoMensual);
                            totalVan += 1;
                        }
                        else
                        {
                            presupuestoMensual = 0; // Se da por hecho que se agotó porque vamos creando en secuencia
                        }
                        tipo = 1;
                        break;
                }
            }
            Console.WriteLine("Para el mes {0} se crearon \nAutos: {1}\nCamionetas: {2}\nVan: {3}", mes, totalAutos, totalCamionetas, totalVan);
        }

        private bool esPosible(double presupuesto, double costo)
        {
            // Nos indica si es posible realizar la operación de creación de dicho auto, 
            // con base en el presupuesto y el costo del vehículo actual
            return presupuesto >= costo;
        }
    }
}
