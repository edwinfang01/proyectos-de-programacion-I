using System;

class Animal
{
    // Método virtual que puede ser sobrescrito
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

class Perro : Animal
{
    // Sobrescribimos el método para perros
    public override void HacerSonido()
    {
        Console.WriteLine("Guau guau");
    }
}

class Gato : Animal
{
    // Sobrescribimos el método para gatos
    public override void HacerSonido()
    {
        Console.WriteLine("Miau miau");
    }
}

/* class Program
{
    static void Main()
    {
        Animal miAnimal = new Animal();

        miAnimal = new Perro();
        miAnimal.HacerSonido(); // output "Guau guau"

        miAnimal = new Gato();
        miAnimal.HacerSonido(); // output "Miau Miau"
    }
}
 */