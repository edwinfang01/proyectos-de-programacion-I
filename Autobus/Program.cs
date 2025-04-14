using System;

namespace VentaPasajes
{
    class Bus
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public int Pasajeros { get; private set; }
        public int PrecioPasaje { get; set; }

        public int VentasTotales => Pasajeros * PrecioPasaje;
        public int AsientosDisponibles => Capacidad - Pasajeros;

        public Bus(string nombre, int capacidad, int precioPasaje)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            PrecioPasaje = precioPasaje;
            Pasajeros = 0;
        }

        public void VenderPasajes(int cantidad)
        {
            if (cantidad <= AsientosDisponibles)
            {
                Pasajeros += cantidad;
            }
            else
            {
                Console.WriteLine($"No hay suficientes asientos disponibles en el bus {Nombre}.");
            }
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Auto Bus {Nombre} {Pasajeros} Pasajeros Ventas {VentasTotales}, quedan {AsientosDisponibles} asientos disponibles");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bus platinum = new Bus("Platinum", 22, 1000);
            platinum.VenderPasajes(5);

            Bus gold = new Bus("Gold", 15, 1333);
            gold.VenderPasajes(3);

            platinum.MostrarResumen();
            gold.MostrarResumen();
        }
    }
}
