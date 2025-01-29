abstract class Vehiculo
{
    public abstract string Marca { get; set; }
    public abstract string Modelo { get; set; }

    public abstract double CalcularCostoMantenimiento();
}

class Auto : Vehiculo
{
    public int Kilometraje { get; set; }
    private string marca;
    private string modelo;


    public override string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public override string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }


    public Auto(string marca, string modelo, int kilometro)
    {
        Marca = marca;
        Modelo = modelo;
        Kilometraje = kilometro;
    }

    public override double CalcularCostoMantenimiento()
    {
        Console.WriteLine($"La {Marca} modelo {Modelo} y {Kilometraje}");
        // 10 dólares por cada 1000 km
        return (Kilometraje / 1000) * 10;
    }
}

class Moto : Vehiculo
{
    public int Cilindrada { get; set; }
    private string marca;
    private string modelo;

    public override string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
    public override string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public Moto(string modelo, string marca, int cilindraje)
    {
        // 
        Marca = marca;
        Modelo = modelo;
        Cilindrada = cilindraje;
    }
    public override double CalcularCostoMantenimiento()
    {
        return (Cilindrada / 100) * 5;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Auto auto = new Auto("Toyota", "Corolla", 100000);
        Console.WriteLine($"Auto: {auto.Marca} {auto.Modelo}");
        Console.WriteLine($"Kilometraje: {auto.Kilometraje} km");
        Console.WriteLine($"Costo de mantenimiento: {auto.CalcularCostoMantenimiento()} dólares\n");
        Console.WriteLine($"Costo de mantenimiento: {auto.CalcularCostoMantenimiento()} dólares\n");

        Moto moto = new Moto("Yamaha", "R3", 300);
        Console.WriteLine($"Moto: {moto.Marca} {moto.Modelo}");
        Console.WriteLine($"Cilindrada: {moto.Cilindrada}cc");
        Console.WriteLine($"Costo de mantenimiento: {moto.CalcularCostoMantenimiento()} dólares");
        Console.WriteLine($"Costo de mantenimiento: {moto.CalcularCostoMantenimiento()} dólares");
    }
}