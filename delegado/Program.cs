class Notificador
{
    public delegate void Mensaje(string msj);
    public event Mensaje EventoOcurriendo;

    public void EnviarNotificacion(string Mensaje)
    {
        EventoOcurriendo?.Invoke($"El evento ha sido disparado. {Mensaje}");
    }
}

public class Suscriptor
{
    public void ManejarEvento(string mensaje)
    {
        Console.WriteLine($"Mensaje recibido: {mensaje}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Notificador notificador = new Notificador();
        Suscriptor suscriptor = new Suscriptor();

        // Suscripción al evento
        notificador.EventoOcurriendo += suscriptor.ManejarEvento;

        // Enviar notificación
        notificador.EnviarNotificacion("¡Hola mundo!");

        // Desuscripción del evento
        notificador.EventoOcurriendo -= suscriptor.ManejarEvento;

        // Esta notificación no se mostrará porque el suscriptor ya no está registrado
        notificador.EnviarNotificacion("Esto no debería aparecer.");
    }
}