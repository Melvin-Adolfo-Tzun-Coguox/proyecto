using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class suv : Vehiculobase
    {
        public int Capacidadpasajeros { get; set; }
        public bool Tienetraccionintegral { get; set; }
        public string Sistemasuspension { get; set; }
        public suv(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima, int capacidadpasajeros, bool tienetraccionintegral, string sistemasuspension) : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
            Capacidadpasajeros = capacidadpasajeros;
            Tienetraccionintegral = tienetraccionintegral;
            Sistemasuspension = sistemasuspension;
        }

        public void activarmodoOfroad()
        {
            if (encendido)
            {
                Console.WriteLine("--- Se activo el modo OFFRoad----");
            }
            else
            {
                Console.WriteLine("Encienda el vehiculo ");
            }
        }
    }
}
