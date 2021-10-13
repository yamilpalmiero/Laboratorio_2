using System;
using Biblioteca;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo r1 = new Recibo();
            Factura f1 = new Factura(1001);
            Factura f2 = new Factura(2002);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += r1;
            contabilidad += f1;
            contabilidad += f2;

            foreach (Factura item in contabilidad.egresos)
            {
                Console.WriteLine(item.Numero);
            }
        }
    }
}
