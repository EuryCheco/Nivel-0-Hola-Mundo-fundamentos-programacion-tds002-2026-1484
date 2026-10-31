namespace FichaPersonal
{
class FichaPersonal
{
    static void Main(string[] args)
    {
        //euryCheco

        Console.WriteLine("Escribe tu Nombre");
        string nombre = Console.ReadLine()!;
        
        Console.WriteLine("Escribe tu edad");
        int edad = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Escribe tu altura");
        double altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Estas trabajando");
        bool trabajando = bool.Parse(Console.ReadLine()!);

    }
}
}    