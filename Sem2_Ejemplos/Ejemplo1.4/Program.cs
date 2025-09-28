using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            string entrada;
            Console.WriteLine("Ejemplo 1.4");
            Console.WriteLine("Ingresar primer número");
            entrada = Console.ReadLine();
            num1 = int.Parse(entrada);

            Console.WriteLine("Ingresar segundo número");
            entrada = Console.ReadLine();
            num2 = int.Parse(entrada);

            Console.WriteLine("Ingresar tercer número");
            entrada = Console.ReadLine();
            num3 = int.Parse(entrada);

            Console.WriteLine("Ingresar cuarto número");
            entrada = Console.ReadLine();
            num4 = int.Parse(entrada);

            int suma, promedio;
            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;
            Console.WriteLine("\nLa suma es: " + suma);

            Console.WriteLine("\nEl promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}
