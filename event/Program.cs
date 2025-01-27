
public delegate void AlertaDeCalorHandler();
class Termometro
{
    public event AlertaDeCalorHandler AlertaDeCalor;

    public void MedirTemperatura()
    {
        for (int i = 0; i < 35; i++)
        {
            if (i < 29)
            {
                Console.WriteLine($"La temperatura es adecuada {i}°");
            }
            else
            {
                Console.WriteLine($"La temperatura es alta {i}°");
                AlertaDeCalor?.Invoke();
            }
        }
    }
}


class Program
{
    static void Main()
    {
        Termometro termo = new Termometro();

        termo.AlertaDeCalor += MensajeIncio;
        termo.AlertaDeCalor += MensajeAdvertencia;

        termo.MedirTemperatura();
    }

    public static void MensajeIncio()
    {
        Console.WriteLine("Bienvenido a la aplicación de termometro");
    }

    public static void MensajeAdvertencia()
    {
        Console.WriteLine("Cuidado temperatura muy alta");
    }
}