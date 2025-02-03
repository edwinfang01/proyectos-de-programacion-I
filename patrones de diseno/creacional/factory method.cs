public abstract class Creador
{
    public abstract IProducto FactoryMethod();
}

public class CreadorConcreto : Creador
{
    public override IProducto FactoryMethod() => new ProductoConcreto();
}

public interface IProducto
{
    void Operacion();
}

public class ProductoConcreto : IProducto
{
    public void Operacion() => Console.WriteLine("Producto creado");
}

// Uso
class Program
{
    static void Main()
    {
        Creador creador = new CreadorConcreto();
        IProducto producto = creador.FactoryMethod();
        producto.Operacion();
    }
}
