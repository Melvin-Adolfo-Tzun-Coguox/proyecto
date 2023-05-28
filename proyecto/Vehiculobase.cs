using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Vehiculobase:Ivehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; private set; }
        public int VelocidadActual { get; private set; }
        public bool encendido=false;

        public Vehiculobase(string marca, string modelo, string color, int anio, string placa, string tipo, int velocidadMaxima)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Anio = anio;
            Placa = placa;
            Tipo = tipo;
            VelocidadMaxima = velocidadMaxima;
            VelocidadActual = 0;
            encendido = false;
        }
        public void Bocina()
        {
            if (encendido)
            {
                Console.WriteLine("Bocina sonando..");
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep();
                }
            }
            else
            {
                Console.WriteLine("El vehículo está apagado");
                Console.WriteLine(" No se puede hacer sonar la bocina");
            }
        }

        public void Acelerar(int cuanto)
        {
            if (encendido)
            {
                VelocidadActual += cuanto;
                if (VelocidadActual > VelocidadMaxima)
                {
                    VelocidadActual = VelocidadMaxima;
                }
                Console.WriteLine("---- El vehículo aceleró ------ ");
                Console.WriteLine($"Ahora la velocidad actual es de: {VelocidadActual} km/h");
            }
            else
            {
                Console.WriteLine("El vehículo está apagado.");
                Console.WriteLine("No se puede acelerar.");
            }
        }

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("El vehículo se encendió.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }

        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                VelocidadActual = 0;
                Console.WriteLine("El vehículo se apagó.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está apagado.");
            }
        }

        public void Frenar(int cuanto)
        {
            if (encendido)
            {
                VelocidadActual -= cuanto;
                if (VelocidadActual < 0)
                {
                    VelocidadActual = 0;
                }
                Console.WriteLine("----   El vehículo frenó.   ------");
                Console.WriteLine($"Velocidad actual: {VelocidadActual}  km/h");
            }
            else
            {
                Console.WriteLine("El vehículo está apagado");

            }
    
        }

    }
}
