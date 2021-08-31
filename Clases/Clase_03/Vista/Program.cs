using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota felix = new Mascota("Felix", new DateTime(1920, 01, 01), "gato");
            Mascota papu = new Mascota("Papu", new DateTime(1998, 02, 02), "perro");
            Mascota salem = new Mascota("Salem", new DateTime(2010, 03, 03), "gato");

            Console.WriteLine($"{felix.Nombre} nacio el {felix.FechaNacimiento.ToShortDateString()} y es un {felix.Especie}");
            Console.WriteLine($"{papu.Nombre} nacio el {papu.FechaNacimiento.ToShortDateString()} y es un {papu.Especie}");
            Console.WriteLine($"{salem.Nombre} nacio el {salem.FechaNacimiento.ToShortDateString()} y es un {salem.Especie}");
        }
    }
}
