namespace Casting
{
class Casting
{
    static void Main(string[] args)
    {
        
        //  euryCheco
        // Convercion de tipos de datos
        Console.WriteLine("Escribe un decimal");
        double ddecimal = double.Parse(Console.ReadLine()!);
        int entero = (int)ddecimal; // Convercion explicita de double a int
        Console.WriteLine($"El numero entero seria:{entero}");


        Console.WriteLine("Escribe un numero entero");
        int entero2 = int.Parse(Console.ReadLine()!);
        double ddecimal2 = entero2;  // Convercion implicita de int a double
        Console.WriteLine($"El numero decimal seria:{ddecimal2}");



    }
}
}    