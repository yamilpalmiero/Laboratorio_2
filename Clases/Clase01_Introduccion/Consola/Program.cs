using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string placaDeVideo = "Nvidia RTX 3080";
            decimal precioPlacaVideo = 344663.36M;
            string procesador = "Ryzen 7 5800x";
            decimal precioProcesador = 63595M;
            string producto = "Producto";
            string precio = "Precio";

            Console.WriteLine("{0,-20} {1, 10}", producto, precio);
            Console.WriteLine("{0,-20} {1, 10:N1}", placaDeVideo, precioPlacaVideo);
            Console.WriteLine("{0,-20} {1, 10:N2}", procesador, precioProcesador);

            Console.WriteLine("\nIngrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese edad: ");
            string edadIngresada = Console.ReadLine();

            int edad = int.Parse(edadIngresada);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\nNombre: {0}\nEdad: {1}", nombre, edad);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
