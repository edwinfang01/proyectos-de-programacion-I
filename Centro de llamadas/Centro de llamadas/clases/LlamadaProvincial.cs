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
            switch (franja)
            {
                case 1:
                    return duracion * precio1;
                case 2:
                    return duracion * precio2;
                case 3:
                    return duracion * precio3;
                default:
                    return 0;
            }
        }
    }
}