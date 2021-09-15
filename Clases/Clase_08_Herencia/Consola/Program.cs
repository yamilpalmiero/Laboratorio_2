using System;
using System.Collections.Generic;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Yamil", "Palmiero", 33782264);
            Profesor profe1 = new Profesor("Labo II", "Cerizza", 30211456, "Mauricio");

            Persona p2 = profe1;

            List<Persona> personas = new List<Persona>();
            personas.Add(p1);
            personas.Add(profe1);
            personas.Add(p2);

            foreach (Persona item in personas)
            {
                if (item is Profesor)
                {
                    Console.WriteLine(((Profesor)item).MostrarPersona());
                    Console.WriteLine(((Profesor)item).Corregir());
                }

                else
                    Console.WriteLine(item.MostrarPersona());
            }
        }
    }
}
