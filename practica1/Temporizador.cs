

public class Temporizador
{
    public delegate void TemporizadorHandler();
    public event TemporizadorHandler TiempoCumplido;

    public void IniciarCuentaRegresiva(int num)
    {
        Console.WriteLine("Cronometro Iniciando");
        for (int i = num; i >= 0; i--)
        {
            Console.WriteLine($"El numero es {i}");
            Thread.Sleep(1000);
        }
        TiempoCumplido?.Invoke();
    }
}