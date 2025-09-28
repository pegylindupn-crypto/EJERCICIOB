using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCampo_Caso2
{
    internal class PracCampo4_Caso2
    {
        //Funcion para verificar número primo,
        public static bool VerifNumPrimo(bool NumPrimo = true)
        {
            Console.WriteLine("VERIFICAR SI UN NUMERO ES PRIMO");
            Console.WriteLine("-------------------------------");

            //solicitar al usuario ingresar un número
            Console.WriteLine("Ingresar un número:");

            //Lee y valida que el numero sea entero y menor,igual a 1
            if (!int.TryParse(Console.ReadLine(), out int num) || num <= 1)
            {
                NumPrimo = false;
            }
            else
            {   //con 'Math.Sqrt' calcula la raíz cuadrada para mejorar el bucle de verificación
                for (int i = 2; i <= Math.Sqrt(num); i++) //si el número es divisible por "i" no es primo
                {
                    if (num % i == 0)
                    {
                        NumPrimo = false;
                        break;
                    }
                }
            }
            return NumPrimo; //devuelve el resultado
        }

        static void Main(string[] args)
        {
            bool resultado = VerifNumPrimo();

            //estructura condicional para mostral el mensaje final
            if (resultado)
            {
                Console.WriteLine("El número es primo");

            }
            else
            {
                Console.WriteLine($"El número no es primo");
            }
            Console.ReadKey();
        }
    }
}
