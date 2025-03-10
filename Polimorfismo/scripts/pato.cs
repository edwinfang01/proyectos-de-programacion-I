namespace scripts
{
    internal class Pato: Ave
    {
        public Pato()
        {
            this.nombreComun = "Pato";
            this.puedeVolar = true;
            this.nombreCientifico = "Anas platyrhynchos";
        }
        internal override void hacerSonido()
        {
            Console.WriteLine("Canto de pato");
        }
    }
}