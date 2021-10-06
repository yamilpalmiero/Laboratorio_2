using System;

using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Aguante Banfield";
            int cantidadPalabras = texto.ContarPalabras();


            Console.WriteLine($"{texto} tiene {cantidadPalabras} palabras.");
        }
    }
}
