using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo 1.3");

            Console.WriteLine("Calculadora de sueldo");

            Console.WriteLine("Ingrese el numero de horas de trabajo:");

            string entrada = Console.ReadLine();

            int.TryParse(entrada, out int horatrabajo);

            Console.WriteLine("Ingrese el costo de horas de trabajo:");

            string entrada1 = Console.ReadLine();

            int.TryParse(entrada1, out int costohorastrabajo);

            double totalsueldo = horatrabajo * costohorastrabajo;

            Console.WriteLine($"El sueldo total es: {totalsueldo}");

            Console.ReadKey();
        }
    }
}
