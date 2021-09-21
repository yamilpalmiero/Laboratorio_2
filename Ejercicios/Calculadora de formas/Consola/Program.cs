using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Rectangulo(2, 4));
            figuras.Add(new Cuadrado(2));

            StringBuilder sb = new StringBuilder();

            foreach(Figura item in figuras)
            {
                sb.AppendLine()
            }
        }
    }
}
