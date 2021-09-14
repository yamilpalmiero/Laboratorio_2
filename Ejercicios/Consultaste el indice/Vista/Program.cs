using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            libro[0] = "Pagina Uno";
            libro[1] = "Pagina Dos";
            libro[2] = "Pagina Tres";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
