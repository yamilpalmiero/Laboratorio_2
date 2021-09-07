using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[] array = { 1, 2, 3, 4, 5 };

            foreach (int item in array)
                Console.WriteLine(item);

            Console.WriteLine("--- Lo doy vuelta con Reverse ---");

            Array.Reverse(array);//Da vuelta el array

            foreach (int item in array)
                Console.WriteLine(item);

            Console.WriteLine("---------------------------------");

            Console.WriteLine(array2D.Length);//Cantidad de elementos
            Console.WriteLine(array2D.Rank);//Cantidad de dimensiones
            Console.WriteLine(array2D.GetLength(0));//Cantidad del indice que le pasas por parametro
        }
    }
}
