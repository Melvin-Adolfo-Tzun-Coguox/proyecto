using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Pickup : Vehiculobase
    {
        public int Capacidadcarga{get; set;}
        public bool Tienetoldo { get; set;}
        public string Traccion { get; set;}

        public Pickup(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima,int capacidadcarga,bool tienetoldo,string traccion ) : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
            Capacidadcarga = capacidadcarga;
            Tienetoldo = tienetoldo;
            Traccion = traccion;
        }

        public void cargar(int cantidad)
        {
            Console.WriteLine($"Cargando {cantidad} kg de peso en la camioneta");
        }
    }
}
