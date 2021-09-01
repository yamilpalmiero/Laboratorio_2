using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiempo t1 = new Tiempo(21, 45, 59);
            Tiempo t2 = new Tiempo(21, 45, 59);
            Tiempo t3 = new Tiempo(12, 20, 17);

            Console.WriteLine(t1 == t2);
            Console.WriteLine(t1 != t2);
            Console.WriteLine(t2 == t3);

            int segundos = t1;
            int b = segundos;

            Tiempo tiempo = (Tiempo)"20:18:35";

            Console.WriteLine($"Hora: {tiempo.hora}  Minutos: {tiempo.minutos}");
        }
    }
}
