namespace Nomina
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos
            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine()!;

            Console.WriteLine("Ingrese su salario por hora: ");
            double Salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese sus horas trabajadas: ");
            double HorasTrabajadas = Convert.ToDouble(Console.ReadLine());

            const double AFP = 2.87; // 2.87% de impuesto por AFP
            const double SFS = 3.04; // 3.04% de impuesto por SFS


            // Proceso de cálculo

            double SalarioBruto = Salario * HorasTrabajadas;
            double DescuentoAFP = SalarioBruto / AFP;
            double DescuentoSFS = SalarioBruto / SFS;
            double SalarioNeto = SalarioBruto - DescuentoAFP - DescuentoSFS;

            // Salida de resultados
            
            Console.WriteLine($"Nombre:{Nombre}\nsu salario neto es: {SalarioNeto:N2}\ndescuento AFP: {DescuentoAFP:N2}\ndescuento SFS: {DescuentoSFS:N2}\nsu salirio neto es: {SalarioBruto:N2}" );
        }
    }
}