using System;
using System.Collections.Generic;

public interface IObservador
{
    void Actualizar(string mensaje);
}

public class ObservadorConcreto : IObservador
{
    private string _nombre;
    public ObservadorConcreto(string nombre) => _nombre = nombre;

    public void Actualizar(string mensaje) => Console.WriteLine($"{_nombre} recibió: {mensaje}");
}

public class Sujeto
{
    private List<IObservador> _observadores = new List<IObservador>();

    public void AgregarObservador(IObservador observador) => _observadores.Add(observador);
    public void Notificar(string mensaje)
    {
        foreach (var observador in _observadores)
        {
            observador.Actualizar(mensaje);
        }
    }
}

// Uso
class Program
{
    static void Main()
    {
        Sujeto sujeto = new Sujeto();
        IObservador obs1 = new ObservadorConcreto("Observador 1");
        IObservador obs2 = new ObservadorConcreto("Observador 2");

        sujeto.AgregarObservador(obs1);
        sujeto.AgregarObservador(obs2);

        sujeto.Notificar("Nuevo evento disponible");
    }
}
