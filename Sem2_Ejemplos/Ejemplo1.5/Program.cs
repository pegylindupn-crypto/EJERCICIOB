using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad;
            string entrada;
            Console.WriteLine("Ejemplo: 1.5");
            Console.WriteLine("Ingresar precio de compra");
            entrada = Console.ReadLine();
            precio = int.Parse(entrada);

            Console.WriteLine("Ingresar cantidad");
            entrada = Console.ReadLine();
            cantidad = int.Parse(entrada);

            float PrecioTotal;
            PrecioTotal = precio * cantidad;
            Console.WriteLine("\nEl precio total de la compra es: " + PrecioTotal);

            Console.ReadKey();

        }
    }
}
