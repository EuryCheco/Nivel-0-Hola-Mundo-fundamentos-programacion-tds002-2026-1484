namespace Conversor_Unidad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            Console.Write("Ponga su peso en libra: ");
            double peso = double.Parse(Console.ReadLine()!);

            Console.Write("Ponga una temporatura F: ");
            double temperatura = double.Parse(Console.ReadLine()!);

            
            const double lb = 0.453592;
            const double Conversion = 5.0 / 9.0;
            const double Dif = 32;

            double Kilogramo = peso * lb;
            double Celsius = (temperatura - Dif) * Conversion;

            double resultado_Peso = Math.Round(Kilogramo);
            double resultado_temp = Math.Round(Celsius);

            Console.WriteLine($"Tu peso en kilogramo  es: {resultado_Peso}\nTu temperatura en Celsius es: {resultado_temp} ");
            






        }
    }
}
