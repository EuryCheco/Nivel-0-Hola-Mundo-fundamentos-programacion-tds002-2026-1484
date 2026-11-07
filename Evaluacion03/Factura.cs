namespace Factura
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Entrada de datos
            Console.Write("Ingrese el nombre del producto: ");
            string NombreProducto = Console.ReadLine()!;

            Console.Write("Ingrese la cantidad de productos: ");
            int Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio del producto: ");
            double Precio = Convert.ToDouble(Console.ReadLine());

            const double ITBIS = 0.18; // 18% de impuesto por ITBIS

            // Proceso de cálculo
            
            double Subtotal = Cantidad * Precio;
            double ImpuestoITBIS = Subtotal * ITBIS;
            double Total = Subtotal + ImpuestoITBIS;

            // Salida de datos

            Console.WriteLine($"Nombre del producto: {NombreProducto:10}\nCantidad: {Cantidad}\nPrecio: {Precio:N2}\nSubtotal: {Subtotal:N2}\nImpuesto ITBIS: {ImpuestoITBIS:N2}\nTotal a pagar: {Total:N2}");


        }
    }
}