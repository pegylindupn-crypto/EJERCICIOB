using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCampo_Caso1
{
    internal class PracCampo4_Caso1
    {

        public static double CelsiusFahrenheit()
        {
            double C, F;//declaración de variables (C)Celsius, (F)Fahrenheit

            Console.WriteLine("CONVERTIR GRADOS CELSIUS A GRADOS FAHRENHEIT");
            Console.WriteLine("--------------------------------------------");

            //solicitar al usuario ingresar la temperatura a grados celsius
            Console.WriteLine("Ingrese la temperatura en grados Celsius: ");

            //lee la entrada del usuario y convertir a double
            if (!double.TryParse(Console.ReadLine(), out C) || C < -273.15)
            {
                // -273.15 valor mínimo de la temperatura celsius, cero absoluto

                Console.WriteLine("Temperatura no válida.Se considerará como 0°");
                C = 0;
            }
            //Formula
            F = (C * 9 / 5) + 32;

            return F;

        }
        static void Main(string[] args)
        {
            //LLamada al método o función 
            double F = CelsiusFahrenheit();

            //Muestra resultado
            Console.WriteLine($"La temperatura en Fahrenheit es: {F}");
            Console.ReadKey();
        }
    }
}
