using System;

namespace clases
{
    public class Practica2
    {
        public static void Main(string[] args)
        {
            Centralita centralita = new Centralita();

            // Registrando varios llamadas
            centralita.registrarLlamada(new Llamada("123", "456", 60));
            centralita.registrarLlamada(new LlamadaProvincial("789", "012", 120, 1));
            centralita.registrarLlamada(new LlamadaProvincial("345", "678", 180, 2));

            // Total de llamadas y total facturado
            Console.WriteLine($"Total de llamadas: {centralita.getTotalLlamadas()}");
            Console.WriteLine($"Facturación total: {centralita.TotalFacturado()}");
        }
    }
}
