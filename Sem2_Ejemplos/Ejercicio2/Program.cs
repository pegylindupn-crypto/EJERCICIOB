using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string entrada;
            Console.WriteLine("Cálculos");
            Console.WriteLine("Ingrese primer número:");
            entrada = Console.ReadLine();
            num1 = int.Parse(entrada);

            Console.WriteLine("Ingrese segundo número:");
            entrada = Console.ReadLine();
            num2 = int.Parse(entrada);

            if (num1 > num2)
            {
                int suma, resta;
                suma = num1 + num2;
                resta = num1 - num2;
                Console.WriteLine("\nLa suma es:" + suma);
                Console.WriteLine("\nLa resta es:" + resta);
            }
            else
            {
                int multi, division; //comentario
                multi = num1 * num2;
                division = num1 / num2;
                Console.WriteLine("\nLa multiplicación es:" + multi);
                Console.WriteLine("\nLa división es:" + division);
            }
            Console.ReadKey();

        }
    }
}
