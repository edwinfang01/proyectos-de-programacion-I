using System;

namespace MiProyecto.scripts
{
    internal class Adivinar
    {
        static void Run(string[] args)
        {
            int[] arreglo = {1,2,3,4,5,6,7,8,9};

            Random random = new Random();

            int indiceRandom = random.Next(arreglo.Length-1);

            int numeroSeleccionado = arreglo[indiceRandom];

            Console.Write("adivina un numero del 1 a 9: ");

            int numeroAdivinado;

            bool result = int.TryParse(Console.ReadLine(), out numeroAdivinado);

            if (numeroAdivinado == numeroSeleccionado) {
                Console.WriteLine("adivinaste el numero");
            }

        }
    }
}