// hamburguesas_billy.cs
using System;
using System.Collections.Generic;

class Hamburguesa
{
    protected string TipoPan;
    protected string TipoCarne;
    protected double PrecioBase;
    protected List<(string Nombre, double Precio)> Ingredientes;
    protected int MaxIngredientes;

    public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
    {
        TipoPan = tipoPan;
        TipoCarne = tipoCarne;
        PrecioBase = precioBase;
        Ingredientes = new List<(string, double)>();
        MaxIngredientes = 4;
    }

    public virtual void AgregarIngrediente(string nombre, double precio)
    {
        if (Ingredientes.Count < MaxIngredientes)
        {
            Ingredientes.Add((nombre, precio));
        }
        else
        {
            Console.WriteLine("No se pueden agregar más ingredientes adicionales.");
        }
    }

    public virtual void MostrarDetalle()
    {
        Console.WriteLine($"Hamburguesa con pan {TipoPan}, carne {TipoCarne}");
        Console.WriteLine($"Precio base: ${PrecioBase:F2}");
        double total = PrecioBase;
        foreach (var (nombre, precio) in Ingredientes)
        {
            Console.WriteLine($" + {nombre}: ${precio:F2}");
            total += precio;
        }
        Console.WriteLine($"Total: ${total:F2}\n");
    }
}

class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string tipoCarne, double precioBase)
        : base("integral", tipoCarne, precioBase)
    {
        MaxIngredientes = 6;
    }
}

class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoPan, string tipoCarne, double precioBase)
        : base(tipoPan, tipoCarne, precioBase)
    {
        Ingredientes.Add(("Papitas", 3.00));
        Ingredientes.Add(("Bebida", 2.00));
        MaxIngredientes = 2;
    }

    public override void AgregarIngrediente(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar más ingredientes en la hamburguesa Premium.");
    }
}

class Programa
{
    static void Main()
    {
        var clasica = new Hamburguesa("blanco", "res", 5.00);
        clasica.AgregarIngrediente("Tomate", 0.50);
        clasica.AgregarIngrediente("Lechuga", 0.50);
        clasica.AgregarIngrediente("Bacon", 1.00);
        clasica.MostrarDetalle();

        var saludable = new HamburguesaSaludable("pollo", 6.00);
        saludable.AgregarIngrediente("Aguacate", 1.50);
        saludable.AgregarIngrediente("Brotes de soya", 1.00);
        saludable.MostrarDetalle();

        var premium = new HamburguesaPremium("ajonjolí", "angus", 8.00);
        premium.MostrarDetalle();
        premium.AgregarIngrediente("Queso", 1.00); // Debería rechazarlo
    }
}
