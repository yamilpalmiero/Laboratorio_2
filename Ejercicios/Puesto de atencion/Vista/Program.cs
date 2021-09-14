using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio = new Negocio("Pago Facil");

            Cliente cliente1 = new Cliente("Yamil Palmiero", 1);
            Cliente cliente2 = new Cliente("Mariana Seib", 2);
            Cliente cliente3 = new Cliente("Maria Martuccio", 3);



            //AGREGO 3 CLIENTES DIFERENTES
            if (negocio + cliente1)
                Console.WriteLine($"Se agrego al cliente {cliente1.Numero}: {cliente1.Nombre}");

            if (negocio + cliente2)
                Console.WriteLine($"Se agrego al cliente {cliente2.Numero}: {cliente2.Nombre}");

            if (negocio + cliente3)
                Console.WriteLine($"Se agrego al cliente {cliente3.Numero}: {cliente3.Nombre}");


            //SE INTENTA AGREGAR UN CLIENTE REPETIDO
            if (negocio + cliente1)
                Console.WriteLine($"Se agrego al cliente {cliente1.Numero}: {cliente1.Nombre}");
            else
                Console.WriteLine("No se pudo agregar el cliente porque ya estaba en la cola.");


            //CLIENTES PENDIENTES DE ATENDER
            while (~negocio)
                Console.WriteLine($"Clientes pendientes de atencion: {negocio.ClientesPendientes}");
        }
    }
}
