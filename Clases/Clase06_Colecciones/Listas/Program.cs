using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            foreach (int item in numeros)
                Console.WriteLine(item);

            Console.WriteLine();

            Console.WriteLine(numeros.Count);

            Console.WriteLine();

            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 3)
                    numeros.RemoveAt(i);
            }
            foreach (int item in numeros)
                Console.WriteLine(item);
        }
    }
}
