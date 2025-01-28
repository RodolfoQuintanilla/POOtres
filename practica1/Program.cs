public class Program
{
    static void Main()
    {
        Temporizador tempo = new Temporizador();

        
        tempo.TiempoCumplido += TerminaCronometro;

        tempo.IniciarCuentaRegresiva(20);

    }

    public static void TerminaCronometro()
    {
        Console.WriteLine("Cronometro terminado");
    }

}