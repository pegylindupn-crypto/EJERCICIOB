using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso Sueldo");
            double sueldo;
            string entrada;

            Console.WriteLine("Ingrese el sueldo:");
            entrada = Console.ReadLine();
            sueldo = Convert.ToDouble(entrada);

            if (sueldo > 3000)
            {
                Console.WriteLine("\nEsta persona debe abonar impuestos");
            }
            Console.ReadKey();

        }
    }
}
