using System;

class CostoTotal
{
    // Método para calcular el costo total
    static double CalcularCostoTotal(double baseCosto, double porcentajeImpuesto)
    {
        return baseCosto + (baseCosto * (porcentajeImpuesto / 100));
    }

    // Método para imprimir el reporte
    static void ReportePresupuesto(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    static void Main(string[] args)
    {
        // Func para calcular el costo total
        Func<double, double, double> calcularCosto = CalcularCostoTotal;

        // Action para imprimir mensajes
        Action<string> imprimir = ReportePresupuesto;

        // Valores de entrada
        double costoBase = 10000;
        double porcentajeImpuesto = 15;

        // Calcular el costo total usando Func
        double costoTotal = calcularCosto(costoBase, porcentajeImpuesto);

        // Mostrar los resultados usando Action
        imprimir($"El costo base es: ${costoBase}");
        imprimir($"El porcentaje de impuestos es: {porcentajeImpuesto}%");
        imprimir($"El costo total del proyecto es: ${costoTotal}");
    }
}
