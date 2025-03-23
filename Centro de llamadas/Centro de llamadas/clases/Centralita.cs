using System;
using clases;

public class Centralita
{
	int cont = 0;
	double acum = 0;
	
	internal int getTotalLlamadas() { return cont; }
	internal double TotalFacturado() { return acum; }
	internal void registrarLlamada(Llamada llamada)
    {
        cont++;
        acum += llamada.calcularPrecio();
    }
}
