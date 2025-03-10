namespace scripts
{
    internal class Aguila : Ave
    {
        public Aguila()
        {
            this.nombreComun = "Águila";
            this.puedeVolar = true;
            this.nombreCientifico = "Aquila chrysaetos";
        }
        internal override void hacerSonido()
        {
            Console.WriteLine("Canto de águila");
        }
    }
}