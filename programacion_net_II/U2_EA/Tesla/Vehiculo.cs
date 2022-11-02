using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesla
{
    abstract class Vehiculo
    {
        /*
         * La clase Vehículo es el núcleo de la Armadora Tesla ya aquí se centralizan los precios
         * o Costos de las piezas. Este método no le añado ni constructor ni métodos para heredar
         * ya que en la actividad se indican los nombres de diferentes métodos, según el tipo de clase que hereda
         * por lo que, al ser diferente el nombre de la función no es posible realizar polimorfismo.
         * 
         * Por otro lado aquí es posible venir a cambiar los costos y con ello las demás clases heredan.
         */ 
        protected double costoPanel = 1650.0;
        protected double costoBateria = 890.0;
        protected double costoCableado = 5890.0;
        protected double costoModulo = 2145.0;
        protected double costoMotor = 9874.0;
        protected double costoAcabado = 30000.0;

    }
}
