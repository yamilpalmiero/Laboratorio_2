using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Empresa S.A.", 100);

            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(50);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(-50);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(160);
            Console.WriteLine(cuenta.Mostrar());
        }
    }
}
