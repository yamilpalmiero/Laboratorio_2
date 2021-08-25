using System;
using Biblioteca;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool esNumero;
            int acumulador = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Ingrese 10 numeros enteros");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}° numero: ", i);
                esNumero = int.TryParse(Console.ReadLine(), out numero);

                while (!Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Error. El numero entero debe estar entre -100 y 100");
                    Console.WriteLine("Reingrese:");
                    Console.Write("{0}° numero: ", i);
                    esNumero = int.TryParse(Console.ReadLine(), out numero);
                }

                acumulador += numero;

                if (numero > max)
                    max = numero;
                if (numero < min)
                    min = numero;
            }

            Console.WriteLine("\n\nEl maximo es {0}\nEl minimo es {1}\nEl promedio es {2}", max, min, acumulador / 10);
        }
    }
}
