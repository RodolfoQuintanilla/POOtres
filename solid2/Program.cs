

class ProductValidator
{
    public void Validate(string nombre, decimal precio)
    {
        if (string.IsNullOrWhiteSpace(nombre) || precio <= 0)
        {
            throw new Exception("Lista o el numero de cliente no coincide ");
        }
    }
}

public class ProductRepository
{
    public void Save(string nombre, decimal precio)
    {
        Console.WriteLine($"Producto guardado en la base de datos: {nombre} - Precio: {precio}");
    }
}

public class NotificationService
{
    public void Notify(string nombre)
    {
        Console.WriteLine($"Notificación: El producto '{nombre}' ha sido agregado.");
    }
}

class ProductService
{
    private readonly ProductValidator _validator;
    private readonly ProductRepository _repository;
    private readonly NotificationService _notifier;

    public ProductService()
    {
        _validator = new ProductValidator();
        _repository = new ProductRepository();
        _notifier = new NotificationService();
    }

    public void AddProduct(string nombre, decimal precio)
    {
        _validator.Validate(nombre, precio);   // Validar el producto
        _repository.Save(nombre, precio);      // Guardarlo en la base de datos
        _notifier.Notify(nombre);              // Notificar que se agregó
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductService service = new ProductService();
        service.AddProduct("Laptop", 1200);
        Console.WriteLine("________________________________________________________");
        service.AddProduct("Xbox", 600);
    }
}