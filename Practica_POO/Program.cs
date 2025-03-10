using System;
using clases;

internal class Program
{
    private static void Main(string[] args)
    {
        PracticaPOO practica = new PracticaPOO();
        practica.Ejecutar();
    }
}

public class PracticaPOO
{
    public void Ejecutar()
    {
        Garaje garaje = new Garaje();
        Coche toyota = new Coche("Toyota", "Corolla");
        Coche honda = new Coche("Honda", "Civic");

        // Los coches entran al garaje al menos 2 veces
        garaje.aceptarCoche(toyota, "aceite");
        garaje.aceptarCoche(honda, "aceite");
        garaje.aceptarCoche(toyota, "revisión general");
        garaje.aceptarCoche(honda, "revisión general");

        // Mostrar información de los coches
        toyota.MostrarAtributos();
        honda.MostrarAtributos();

        // Mostrar el importe total acumulado en el garaje
        Console.WriteLine($"Importe total acumulado en el garaje: {garaje.TotalImporte():F2}");
    }
}