public class Calculadora
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    public static int Restar(int a, int b) => a - b;
    public static int Multiplicar(int a, int b) => a * b;

    public static int Dividir(int a, int b){
        if (b == 0) {
            throw new DivideByZeroException("No se puede dividir por cero");
        }else
        {
            return a / b;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Calculadora.Sumar(5, 5));
        Console.WriteLine(Calculadora.Restar(5, 9));
        Console.WriteLine(Calculadora.Multiplicar(5, 9));
        Console.WriteLine(Calculadora.Dividir(5, 9));
    }
}