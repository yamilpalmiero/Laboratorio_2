using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8, 2, Colores.Rojo, 6, 15600);
            Automovil auto = new Automovil(4, 4, Colores.Blanco, 5, 5);
            Moto moto = new Moto(2, 0, Colores.Azul, 600);

            Console.WriteLine(camion.MostrarCamion());
            Console.WriteLine(auto.MostrarAutomovil());
            Console.WriteLine(moto.MostrarMoto());
        }
    }
}
