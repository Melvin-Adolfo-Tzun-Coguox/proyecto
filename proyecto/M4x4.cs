using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class M4x4 : Vehiculobase
    {
        public int Alturadelsuelo { get; set; }
        public bool Tienereductora { get; set; }
        public string Tienetraccion { get; set; }
        public M4x4(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima,int alturadelsuelo,bool tienereductora,string traccion ) : base(marca, modelo, color, anio, placa, tipo, velocidadMaxima)
        {
            Alturadelsuelo= alturadelsuelo;
            Tienereductora = tienereductora;
            Tienetraccion= traccion;

        }
        public void encenderequipo()
        {
            if (encendido)
            {
                Console.WriteLine("     EQUIPO DE SONIDO ACTIVADO");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("        DISFRUTA LA MUSICA");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Enciende la 4x4.....");
            }
        }
        
    }
}
