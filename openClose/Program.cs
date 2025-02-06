

public interface IFiguasGeometricas
{
    void AreaFigura();
    void PerimetroFigura();
}
class Circulo : IFiguasGeometricas
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }
    public void AreaFigura()
    {
        Console.WriteLine($"La Area del Circulo es {Math.PI * radio * radio}");
    }

    public void PerimetroFigura()
    {
        Console.WriteLine($"La Base del Circulo es: {2 * Math.PI * radio}");
    }
}

class Cuadrado : IFiguasGeometricas
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public void AreaFigura()
    {
        Console.WriteLine($"La Area del cuadrado es: {lado * lado}");
    }

    public void PerimetroFigura()
    {
        Console.WriteLine($"La Base del cuadrado es: {lado * 4}");
    }
}


class Rectangulo : IFiguasGeometricas
{
    private double largo;
    private double ancho;
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }
    public void AreaFigura()
    {
        Console.WriteLine($"El Area del cuadrado: {largo * ancho}");
    }

    public void PerimetroFigura()
    {
        Console.WriteLine($"El Perimetro del cuadrado: {2 * (largo + ancho)}");
    }
}

public class GenerarInformacion
{
    private IFiguasGeometricas _info;

    public GenerarInformacion(IFiguasGeometricas info)
    {
        _info = info;
    }

    public void CalcularDatos()
    {
        _info.AreaFigura();
        _info.PerimetroFigura();
    }

}



class Program
{
    static void Main()
    {
        IFiguasGeometricas figura = new Circulo(5); // Inyección de Circulo
        GenerarInformacion info = new GenerarInformacion(figura);
        info.CalcularDatos();

        info = new GenerarInformacion(new Cuadrado(4)); // Inyectamos un Cuadrado
        info.CalcularDatos();

        info = new GenerarInformacion(new Rectangulo(5, 6));
        info.CalcularDatos();
    }
}