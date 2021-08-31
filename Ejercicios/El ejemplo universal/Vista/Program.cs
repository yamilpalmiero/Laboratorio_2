using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Palmiero", "108070", "Yamil");
            Estudiante e2 = new Estudiante("Palmiero", "125445", "Selene");
            Estudiante e3 = new Estudiante("Seib", "008040", "Mariana");

            e1.SetNotaPrimerParcial = 4;
            e1.SetNotaSegundoParcial = 5;

            e2.SetNotaPrimerParcial = 4;
            e2.SetNotaSegundoParcial = 3;

            e3.SetNotaPrimerParcial = 9;
            e3.SetNotaSegundoParcial = 7;

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}
