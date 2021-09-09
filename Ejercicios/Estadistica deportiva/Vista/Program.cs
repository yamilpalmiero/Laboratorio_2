using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(2, "Banfield");
            Jugador j1 = new Jugador(33752265, "Martin Payero", 40, 30);
            Jugador j2 = new Jugador(35144565, "Lionel Messi", 65, 30);
            Jugador j3 = new Jugador(33566871, "Nicolas Tagliafico", 1, 51);


            //Agrego al 1er jugador
            if (e + j1)
                Console.WriteLine(j1.MostrarDatos());
            else
                Console.WriteLine("No se pudo agregar al jugador.");

            //Intento agregar otra vez al 1er jugador
            if (e + j1)
                Console.WriteLine(j1.MostrarDatos());
            else
                Console.WriteLine("No se pudo agregar al jugador. Ya pertenece al equipo.\n");

            //Agrego al 2do jugador
            if (e + j2)
                Console.WriteLine(j2.MostrarDatos());
            else
                Console.WriteLine("No se pudo agregar al jugador.");

            //Intento agregar al 3er jugador pero no puedo porque el equipo es de 2  
            if (e + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("No se pudo agregar al jugador. Supera la cantidad permitida.\n");
        }
    }
}
