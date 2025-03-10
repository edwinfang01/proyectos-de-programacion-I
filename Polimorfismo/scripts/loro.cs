namespace scripts
{
    internal class Loro : Ave
    {
        public Loro()
        {
            this.nombreComun = "Loro";
            this.puedeVolar = true;
            this.nombreCientifico = "Psittacidae";
        }
        internal override void hacerSonido()
        {
            Console.WriteLine("Canto de loro");
        }
    }
}