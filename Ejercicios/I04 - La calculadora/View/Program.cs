using System;
using Biblioteca;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            bool numValido1;
            float num2;
            bool numValido2;
            string operacion;
            float resultado;
            string salir;

            do
            {
                Console.Write("\nPrimer operando: ");
                numValido1 = float.TryParse(Console.ReadLine(), out num1);
                Console.Write("Segundo operando: ");
                numValido2 = float.TryParse(Console.ReadLine(), out num2);
                Console.Write("Operacion: ");
                operacion = Console.ReadLine();

                if (num2 == 0 && operacion == "/")
                    Console.WriteLine("\nNo se puede dividir por cero.");

                Console.WriteLine($"\nResultado = {resultado = Calculadora.Calcular(num1, num2, operacion)}\n");

                Console.Write("Seguir? S/N: ");
                salir = Console.ReadLine().ToLower();

            } while (salir == "s");

            Console.WriteLine("SALIO!");
        }
    }
}
