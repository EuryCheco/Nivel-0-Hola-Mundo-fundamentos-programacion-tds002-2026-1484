namespace Geometria
{
   using System;

public class Program
{
    static void Main()
    {
        // Pedir el radio del círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Calcular el área y la circunferencia
        double area = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;

        // Mostrar resultados del círculo
        Console.WriteLine("\n--- CÍRCULO ---");
        Console.WriteLine($"Área: {area:F2}");
        Console.WriteLine($"Circunferencia: {circunferencia:F2}");

        // Pedir los catetos del triángulo
        Console.Write("\nIngrese el primer cateto: ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo cateto: ");
        double cateto2 = Convert.ToDouble(Console.ReadLine());

        // Calcular la hipotenusa
        double hipotenusa = Math.Sqrt(
            Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2)
        );

        // Mostrar resultado
        Console.WriteLine("\n--- TRIÁNGULO RECTÁNGULO ---");
        Console.WriteLine($"Hipotenusa: {hipotenusa:F2}");
    }
}
}