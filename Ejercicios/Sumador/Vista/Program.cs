using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumadorA = new Sumador();
            Sumador sumadorB = new Sumador();
            int cantidadSumasA;
            int cantidadSumasB;
            long suma;
            bool mismaCantidadSumas;

            Console.WriteLine($"450 + 500 = {sumadorA.Sumar(450, 500)}");//sumadorA=1
            Console.WriteLine($"Yamil + Palmiero = {sumadorA.Sumar("Yamil ", "Palmiero")}\n");//sumadorA=2

            cantidadSumasA = (int)sumadorA;
            cantidadSumasB = (int)sumadorB;
            Console.WriteLine($"Cantidad de sumas de A: {(int)sumadorA}");
            Console.WriteLine($"Cantidad de sumas de B: {cantidadSumasB}");

            suma = sumadorA + sumadorB;
            Console.WriteLine($"{cantidadSumasA} + {cantidadSumasB} = {suma}");

            mismaCantidadSumas = sumadorA | sumadorB;
            Console.WriteLine(mismaCantidadSumas);//False
        }
    }
}
