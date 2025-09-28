using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1.2");
            Console.WriteLine("Cálculo de circunferencia");
            Console.WriteLine("Ingrese el valor del radio:");
            Console.WriteLine("----------------------------");
            string entrada = Console.ReadLine();
            double radio = double.Parse(entrada);
            double perimetro = 2 * Math.PI * radio;
            double area = Math.PI * Math.Pow(perimetro, 2);
            Console.WriteLine($"El perímetro es: { perimetro:F2}");
            Console.WriteLine("El área es: " + area);
            Console.ReadKey();
        }
    }
}
