using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingresar un numero positivo:");
            numero = int.Parse(Console.ReadLine());

            while (numero <= 0)
            {
                Console.WriteLine("ERROR. Reingresar número!");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado es: {0} y el cubo es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
        }
    }
}
