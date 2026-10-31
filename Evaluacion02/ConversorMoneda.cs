namespace ConversorMoneda
{
class ConversorMoneda
{
    static void Main(string[] args)
    {
        //euryCheco

        const double Dolar = 60.54;
        Console.WriteLine("Escribe la cantidad en dólares que deseas convertir:");
        double cantidadDolares = double.Parse(Console.ReadLine()!);
        double cantidadPesos = cantidadDolares * Dolar;
        Console.WriteLine($"La cantidad en pesos es: {cantidadPesos}");


    }
}
}    