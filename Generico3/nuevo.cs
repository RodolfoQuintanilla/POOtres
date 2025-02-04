/*

class Empleado
{
    public string Nombre { get; set; }
    public decimal Salario { get; set; }

    public Empleado(string nom, decimal salario)
    {
        Nombre = nom;
        Salario = salario;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario: {Salario}");
    }
}

class Gerente : Empleado
{

    public decimal Bono { get; set; }
    public Gerente(string nom, decimal salario, decimal bono) : base(nom, salario)
    {
        Bono = bono;
    }
}

class Desarrollador : Empleado
{
    public string Lenguaje { get; set; }
    public Desarrollador(string nom, decimal salario, string lenguaje) : base(nom, salario)
    {
        Lenguaje = lenguaje;
    }
}

class GestorEmpleados<T> where T : Empleado
{
    private List<T> empleados = new List<T>();
    public void AgregarEmpleado(T empleado)
    {
        empleados.Add(empleado);
    }
    public void MostrarInformacion()
    {
        foreach (var empleado in empleados)
        {
            empleado.MostrarInformacion();
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        GestorEmpleados<Gerente> gestorGerentes = new GestorEmpleados<Gerente>();
        gestorGerentes.AgregarEmpleado(new Gerente("Carlos", 5000, 1000));
        gestorGerentes.MostrarInformacion();


        GestorEmpleados<Desarrollador> gestorDesarrolladores = new GestorEmpleados<Desarrollador>();
        gestorDesarrolladores.AgregarEmpleado(new Desarrollador("Ana", 4000, "C#"));
        gestorDesarrolladores.MostrarInformacion();


    }
}

*/