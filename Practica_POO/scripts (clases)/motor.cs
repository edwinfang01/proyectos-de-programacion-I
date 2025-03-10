using System.Runtime.CompilerServices;
namespace clases
{
    internal class Motor
    {
        private int litros_de_aceite = 0;
        private int potencia;

        // Getter para litros_de_aceite
        public int GetLitrosDeAceite()
        {
            return this.litros_de_aceite;
        }

        // Setter para litros_de_aceite
        public void SetLitrosDeAceite(int litros_de_aceite)
        {
            this.litros_de_aceite = litros_de_aceite;
        }

        // Getter para potencia
        public int GetPotencia()
        {
            return potencia;
        }

        // Setter para potencia
        public void SetPotencia(int potencia)
        {
            this.potencia = potencia;
        }

        public Motor(int potencia)
        {
            this.potencia = potencia;
        }
    }

}