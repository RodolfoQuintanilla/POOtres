class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Animal(string nom, int edad)
    {
        Nombre = nom;
        Edad = edad;
    }
    public virtual string HacerSonido() => $"El animal {Nombre}  con edad {Edad}";
}

class Perro : Animal
{
    public Perro(string nom, int edad) : base(nom, edad) { }

    public override string HacerSonido() => $"El animal {Nombre}  con edad {Edad} y su sonido es Guau Guau";
}

class Gato : Animal
{
    public Gato(string nom, int edad) : base(nom, edad) { }
    public override string HacerSonido() => $"El animal {Nombre}  con edad {Edad} y su sonido es Miau Miau";
}

class Pajaro : Animal
{
    public Pajaro(string nom, int edad) : base(nom, edad) { }

    public override string HacerSonido() => $"El animal {Nombre}  con edad {Edad} y su sonido es Pío Pío";
}


class Veterinaria<T> where T : Animal
{
    private List<T> animales = new List<T>();
    public void AgregarAnimal(T animal)
    {
        animales.Add(animal);
    }
    public void MostrarInformacion()
    {
        foreach (var animal in animales)
        {
            Console.WriteLine(animal.HacerSonido());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Veterinaria<Perro> perro = new Veterinaria<Perro>();
        perro.AgregarAnimal(new Perro("Taquito", 3));
        perro.MostrarInformacion();

        Veterinaria<Gato> gato = new Veterinaria<Gato>();
        gato.AgregarAnimal(new Gato("Chicharo", 2));
        gato.MostrarInformacion();

        Veterinaria<Pajaro> pajaro = new Veterinaria<Pajaro>();
        pajaro.AgregarAnimal(new Pajaro("Pirulí", 1));
        pajaro.MostrarInformacion();
    }
}