interface IVehiculo
{
    void Arrancar();
    void Detener();
    void Acelerar(int velocidad);
}

class Coche : IVehiculo
{
    public void Acelerar(int velocidad)
    {
        if (velocidad <= 0)
        {
            Console.WriteLine($"El carro  esta deteno 0");
        }
        else
        {
            Console.WriteLine($"El carro esta acelerando a {velocidad} km/h");
        }
    }

    public void Arrancar()
    {
        Console.WriteLine("El Carro esta arrancando");
    }

    public void Detener()
    {
        Console.WriteLine("El Carro esta apagado");
    }
}


class Moto : IVehiculo
{
    public void Acelerar(int velocidad)
    {
        if (velocidad <= 0)
        {
            Console.WriteLine($"El carro  esta deteno 0");
        }
        else
        {
            Console.WriteLine($"El carro esta acelerando a {velocidad} km/h");
        }
    }

    public void Arrancar()
    {
        Console.WriteLine("El Carro esta arrancando");
    }

    public void Detener()
    {
        Console.WriteLine("El Carro esta apagado");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IVehiculo vehiculo = new Coche();
        IVehiculo vehiculo1 = new Moto();

        vehiculo.Arrancar();
        vehiculo.Acelerar(100);
        vehiculo.Detener();

        vehiculo1.Arrancar();
        vehiculo1.Acelerar(80);
        vehiculo1.Detener();
    }
}