using System;

namespace clases
{
    public class LlamadaLocal : Llamada
    {
        double precio = 15;
        public LlamadaLocal(string numOrigen, string numDestino, double duracion)
            : base(numOrigen, numDestino, duracion) { }

        public override double calcularPrecio()
        {
            return duracion * precio;
        }
    }
}