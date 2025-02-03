using System;

public interface IProducto
{
    decimal PrecioProducto();
    string NombreProducto();
}

public class Electronico : IProducto
{
    public decimal PrecioProducto() => 355.55m; // ✅ 'm' indica que es un decimal
    public string NombreProducto() => "TV";
}

public class Ropa : IProducto
{
    public decimal PrecioProducto() => 55.55m; // ✅ 'm' indica decimal
    public string NombreProducto() => "Pantalón de mujer";
}

public class Carrito<T> where T : IProducto
{
    public void Imprimir(T item)
    {
        Console.WriteLine($"Producto: {item.NombreProducto()} - Precio: ${item.PrecioProducto()}");
    }
}

class Program
{
    static void Main()
    {
        Carrito<Electronico> carritoElectronico = new Carrito<Electronico>();
        carritoElectronico.Imprimir(new Electronico());

        Carrito<Ropa> carritoRopa = new Carrito<Ropa>();
        carritoRopa.Imprimir(new Ropa());
    }
}
