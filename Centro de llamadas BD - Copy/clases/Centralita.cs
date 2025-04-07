using System;
using System.Data.SqlClient;
using clases;

public class Centralita
{
    int cont = 0;
    double acum = 0;

    // Ejemplo de conexión: reemplace con sus propios datos al probar 
    private string connectionString = "Server=servidor.database.windows.net;Database=CentralitaDB;User ID=usuario;Password=contraseña;";

    internal int getTotalLlamadas() { return cont; }
    internal double TotalFacturado() { return acum; }

    internal void registrarLlamada(Llamada llamada)
    {
        cont++;
        double costo = llamada.calcularPrecio();
        acum += costo;
        guardarLlamadaEnBD(llamada, costo);
    }

    private void guardarLlamadaEnBD(Llamada llamada, double costo)
    {
        using SqlConnection connection = new(connectionString);
        connection.Open();

        string query = "INSERT INTO Llamadas (NumeroOrigen, NumeroDestino, Duracion, Costo) VALUES (@origen, @destino, @duracion, @costo)";

        using SqlCommand cmd = new(query, connection);
        cmd.Parameters.AddWithValue("@origen", llamada.getNumOrigen());
        cmd.Parameters.AddWithValue("@destino", llamada.getNumDestino());
        cmd.Parameters.AddWithValue("@duracion", llamada.getDuracion());
        cmd.Parameters.AddWithValue("@costo", costo);

        cmd.ExecuteNonQuery();
    }
}