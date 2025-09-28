using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string entrada;
            Console.WriteLine("Ingrese el número");
            entrada = Console.ReadLine();
            num = int.Parse(entrada);

            if (num % 2 == 0)
            {
                double raiz = Math.Sqrt(num);
                Console.WriteLine($"el {num} es par");
                Console.WriteLine($"Su raíz cuadrada es : {raiz:F2} ");
            }
            else
            {
                double Potencia = Math.Pow(num, 3);
                Console.WriteLine($"El {num} es impar");
                Console.WriteLine($"La potencia al cubo del {num} es {Potencia:F2}");
            }
            Console.ReadKey();  
        }
    }
}
