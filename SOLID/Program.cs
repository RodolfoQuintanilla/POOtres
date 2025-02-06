public class AgregarProductos
{
    public void Validate(string nombre, decimal precio)
    {
        if (string.IsNullOrWhiteSpace(nombre) || precio <= 0)
        {
            throw new Exception("Nombre inválido o precio incorrecto");
        }
    }
}

public class GuardarDB
{
    public void SaveDB(string nombre, decimal precio)
    {
        Console.WriteLine($"Producto guardado en la base de datos: {nombre} - Precio: {precio}");
    }
}

public class Norificar
{
    public void Noticasion(string nombre)
    {
        Console.WriteLine($"Notificación: El producto '{nombre}' ha sido agregado.");
    }
}


class ProductService
{
    private readonly AgregarProductos _agregarProducto;
    private readonly GuardarDB _guardarDB;
    private readonly Norificar _notificar;
    public ProductService()
    {
        _agregarProducto = new AgregarProductos();
        _guardarDB = new GuardarDB();
        _notificar = new Norificar();
    }

    public void AgregarProductos(string nombre, decimal precio)
    {
        _agregarProducto.Validate(nombre, precio);
        _guardarDB.SaveDB(nombre, precio);
        _notificar.Noticasion(nombre);
    }

}

class Program
{
    static void Main(string[] args)
    {
        ProductService service = new ProductService();
        service.AgregarProductos("Laptop", 1000.00m);
        service.AgregarProductos("xxx", 20.000m);

    }
}