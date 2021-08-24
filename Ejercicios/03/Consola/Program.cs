using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esEntero = false;
            string respuesta = string.Empty;
            char respuestaFinal;

            Console.WriteLine("Ingrese un numero:");
            esEntero = int.TryParse(Console.ReadLine(), out numero);
            Console.WriteLine("Desea salir?");
            respuesta = Console.ReadLine();

            if (respuesta != "salir")
            {
                while (!esEntero)
                {
                    Console.WriteLine("ERROR. Debe ser un numero!");
                    esEntero = int.TryParse(Console.ReadLine(), out numero);
                }

                for (int i = 0; i < numero; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Desea volver a operar? S/N");
                respuestaFinal = Console.ReadLine();

                if (respuestaFinal == 's')
                {

                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
