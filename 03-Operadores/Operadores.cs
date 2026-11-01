class Operadores
{
    
    static void main(string[] args)
    {
        Console.WriteLine("Escribe un numero entero");
        int entero = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Escribe un segundo numero entero");
        int entero2 = int.Parse(Console.ReadLine()!);

        int suma = entero + entero2;    // suma de enteros
        int resta = entero - entero2;   // resta de enteros
        int division = entero / entero2; // Division Entera
        double Division = (double)entero / entero2; // Division Real
        double residuo = entero % entero2; // Residuo de la division
        bool esPar = entero % 2 == 0; // Verifica si el numero es par

        
        Console.WriteLine($"La suma de los numeros es: {suma}, la resta es: {resta}, la division entera es: {division}, la division real es: {Division}, el residuo es: {residuo} y el numero es par: {esPar}");

    }

}