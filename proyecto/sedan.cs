using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class sedan : Vehiculobase
    {
        public bool Aireacondicionado { get; set; }
        public string Transmisiones { get; set; }
        public string Estilo { get; set; }
        public sedan(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, bool aireacondicionado, string transmisiones, string estilo) : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
            Aireacondicionado = aireacondicionado;
            Transmisiones = transmisiones;
            Estilo = estilo;
        }

        public void encenderaire()
        {
            if (encendido)
            {
                Console.WriteLine("El aire acondicionado se encendio");
            }
            else
            {
                Console.WriteLine("El vehiculo esta apagado, no se puede encender el aire acondicionado");
                Console.WriteLine("----- Encienda el vehiculo ------");
            }
        }
    }
}
