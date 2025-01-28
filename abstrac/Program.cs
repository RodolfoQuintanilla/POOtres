abstract class Empleado
{
    public abstract string Nombre { get; set; }
    public abstract double CalcularSalario();
}

interface IBeneficios
{
    void MostrarBeneficios();
}


class EmpleadoFijo : Empleado, IBeneficios
{
    public double SalarioMensual { get; set; }
    private string nombre;

    public override string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public EmpleadoFijo(string nombre, double salario)
    {
        Nombre = nombre;
        if (salario < 0)
        {
            throw new ArgumentException("El salario no puede ser negativo.");
        }
        SalarioMensual = salario;
    }

    public override double CalcularSalario()
    {
        return SalarioMensual;
    }

    public void MostrarBeneficios()
    {
        Console.WriteLine("Beneficios de Empleado Fijo");
    }
}



class EmpleadoPorHora : Empleado,IBeneficios
{
    public double HorasTrabajadas { get; set; }
    public double PagoPorHora { get; set; }
    private string nombre;

    public override string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public EmpleadoPorHora(string nombre, double horas, double pagoPorHora)
    {
        Nombre = nombre;

        if (horas < 0)
        {
            throw new ArgumentException("El número de horas trabajadas no puede ser negativo.");
        }

        if (pagoPorHora <= 0)
        {
            throw new ArgumentException("El pago por hora debe ser mayor a cero.");
        }
        HorasTrabajadas = horas;
        PagoPorHora = pagoPorHora;
    }

    public override double CalcularSalario()
    {
        return HorasTrabajadas * PagoPorHora;
    }

    public void MostrarBeneficios()
    {
        Console.WriteLine("Beneficios de Empleado por Hora");
    }
}


class Program
{
    static void Main(string[] args)
    {
        EmpleadoFijo empleado = new EmpleadoFijo("Rodolfo", 1000);
        

        // Mostrar información del empleado
        Console.WriteLine($"Nombre: {empleado.Nombre}");
        Console.WriteLine($"Salario: {empleado.CalcularSalario()}");

        EmpleadoPorHora empleadoPorHora = new EmpleadoPorHora("Lu", 50, 14.50);

        Console.WriteLine($"Nombre: {empleadoPorHora.Nombre}");
        Console.WriteLine($"Horas trabajadas: {empleadoPorHora.HorasTrabajadas}");
        Console.WriteLine($"Salario calculado: {empleadoPorHora.CalcularSalario()}");
    }
}