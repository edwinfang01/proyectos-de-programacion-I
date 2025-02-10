using System;
namespace MiProyecto
{
  class Program
  {
    static void Main(string[] args)
    {
        int[] notas = new int[5];
        Console.Write("Ingrese la primera nota: ");
        notas[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la segunda nota: ");
        notas[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la tercera nota: ");
        notas[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la cuarta nota: ");
        notas[3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese la quinta nota: ");
        notas[4] = Convert.ToInt32(Console.ReadLine());

        decimal calcularPromedio(int[] notas) {
            decimal sum = 0;
            foreach (int nota in notas) {
                sum += nota;
            }
            return sum / notas.Length;
        }

        Console.WriteLine(calcularPromedio(notas) < 70 ? "Se quemo": "paso");
    }
  }
}