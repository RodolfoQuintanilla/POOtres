class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace sonido");
    }

    public virtual void Moverse()
    {
        Console.WriteLine("El animal se mueve");
    }

}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
    public override void Moverse()
    {
        Console.WriteLine("El perro Camina");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla");
    }
    public override void Moverse()
    {
        Console.WriteLine("El gato salta");
    }
}
class Vaca : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("La vaca muge");
    }
    public override void Moverse()
    {
        Console.WriteLine("El gato salta");
    }
}


class Program
{
    static void Main()
    {
        Perro perro = new Perro();
        perro.HacerSonido();
        perro.Moverse();

        Gato gato = new Gato();
        gato.HacerSonido();
        gato.Moverse();

        Vaca vaca = new Vaca();
        vaca.HacerSonido();
        vaca.Moverse();
    }
}