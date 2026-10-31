class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe tu Nombre");
        string nombre = Console.ReadLine()!;

        Console.WriteLine("Escribe tu edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe tu altura");
        double altura = Convert.ToDouble(Console.ReadLine());

        const int Año_Actual = 2026;

        int año_nacimiento = Año_Actual - edad;
        
        Console.WriteLine($"Tu nombre es: {nombre}, tu edad es: {edad}, tu altura es: {altura} y tu año de nacimiento es: {año_nacimiento}");

    }


}