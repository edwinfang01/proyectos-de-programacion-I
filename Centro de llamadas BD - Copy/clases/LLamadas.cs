using System;

namespace clases
{
    public class Llamada
    {
        internal string numOrigen;
        internal string numDestino;
        internal double duracion; // en segundos

        public Llamada(string numOrigen, string numDestino, double duracion)
        {
            this.numOrigen = numOrigen;
            this.numDestino = numDestino;
            this.duracion = duracion;
        }

        public string getNumOrigen() { return numOrigen; }
        public string getNumDestino() { return numDestino; }
        public double getDuracion() { return duracion; }
        public virtual double calcularPrecio() { return 0; }
    }
}