using System;

namespace clases
{
    public class LlamadaProvincial : Llamada
    {
        double precio1 = 20;
        double precio2 = 25;
        double precio3 = 30;
        int franja;

        public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja)
            : base(numOrigen, numDestino, duracion)
        {
            this.franja = franja;
        }

        public override double calcularPrecio()
        {
            return franja switch
            {
                1 => duracion * precio1,
                2 => duracion * precio2,
                3 => duracion * precio3,
                _ => 0
            };
        }
    }
}