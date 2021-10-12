using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //TORNEOS
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Primera A");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            //EQUIPOS
            EquipoFutbol ef1 = new EquipoFutbol("Banfield", new DateTime(1986/12/25));
            EquipoFutbol ef2 = new EquipoFutbol("Boca", new DateTime(02 / 04 / 1900));
            EquipoFutbol ef3 = new EquipoFutbol("River", new DateTime(23 / 08 / 1910));

            EquipoBasquet eb1 = new EquipoBasquet("LA Lakers", new DateTime(10 / 12 / 1945));
            EquipoBasquet eb2 = new EquipoBasquet("New York Knicks", new DateTime(05 / 05 / 1910));
            EquipoBasquet eb3 = new EquipoBasquet("Boston Celtics", new DateTime(25 / 10 / 1911));

            //SE AGREGAN LOS EQUIPOS A LOS TORNEOS CORRESPONDIENTES
            torneoFutbol += ef1;
            torneoFutbol += ef2;
            torneoFutbol += ef3;
            Console.WriteLine(torneoFutbol.Mostrar());

            torneoBasquet += eb1;
            torneoBasquet += eb2;
            torneoBasquet += eb3;
            Console.WriteLine(torneoBasquet.Mostrar());

            //SE JUEGAN LOS PARTIDOS
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
