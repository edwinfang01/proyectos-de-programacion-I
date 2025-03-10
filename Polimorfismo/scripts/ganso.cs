namespace scripts
{
    internal class Ganso : Ave
    {
        public Ganso()
        {
            this.nombreComun = "Ganso";
            this.puedeVolar = true;
            this.nombreCientifico = "Anser anser";
        }
        internal override void hacerSonido()
        {
            Console.WriteLine("Canto de ganso");
        }
    }
}