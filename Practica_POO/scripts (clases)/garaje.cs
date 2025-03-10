using System;

namespace clases
{
    public class Garaje
    {
        private Random random = new Random();
        private double totalImporte = 0;

        internal void aceptarCoche(Coche coche, string averia)
        {
            double importe = random.NextDouble() * 100; // Importe aleatorio entre 0 y 100
            totalImporte += importe;

            if (averia.ToLower() == "aceite")
            {
                Motor motor = coche.GetMotor();
                motor.SetLitrosDeAceite(motor.GetLitrosDeAceite() + 10);
            }

            Console.WriteLine($"Coche {coche.GetMarca()} {coche.GetModelo()} atendido por {averia}. Importe: {importe:F2}");
        }

        public double TotalImporte()
        {
            return totalImporte;
        }
    }
}