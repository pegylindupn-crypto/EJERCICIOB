using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo1.1");
            Console.WriteLine("Ingrese un número para calcular la suma de 1 a N:");
            string entrada = Console.ReadLine();
            
            int.TryParse(entrada, out int n);
            double resultado = n * (n + 1) / 2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();


        }
    }
}
