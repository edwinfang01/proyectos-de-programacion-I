namespace scripts
{
    internal class Gallina : Ave
    {
        internal Gallina()
        {
            this.nombreComun = "Gallina";
            this.puedeVolar = false;
            this.nombreCientifico = "Gallus gallus domesticus";


        }
        internal override void hacerSonido()
        {
            Console.WriteLine("Canto de gallina");
        }
    }
}