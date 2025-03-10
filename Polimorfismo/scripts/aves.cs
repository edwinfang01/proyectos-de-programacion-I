using System.Runtime.CompilerServices;

namespace scripts
{
    internal class Ave
    {
        internal string? nombreComun { get; set; }
        internal string? nombreCientifico { get; set; }
        internal bool? puedeVolar { get; set; }

        internal virtual void hacerSonido()
        {
            Console.WriteLine("Canto de ave");
        }
    }
}