using System;
using System.Collections.Generic;

namespace Diccionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            diccionario.Add("Taco", "Mexico");
            diccionario.Add("Asado", "Argentina");
            diccionario.Add("Pizza", "Italia");

            foreach(KeyValuePair<string, string> item in diccionario)
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");

            Console.WriteLine();

            diccionario.Remove("Taco");
            Console.WriteLine("------------------------");

            foreach(KeyValuePair<string, string> item in diccionario)
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");

            Console.WriteLine();

            diccionario["Taco"] = "EEUU";
            foreach (KeyValuePair<string, string> item in diccionario)
                Console.WriteLine($"Key: {item.Key} Value: {item.Value}");

            Console.WriteLine("------------------------");

            Console.WriteLine(diccionario.ContainsKey("Pasta"));
            Console.WriteLine(diccionario.ContainsKey("Pizza"));
            Console.WriteLine(diccionario.ContainsKey("Asado"));
            Console.WriteLine(diccionario.ContainsKey("Hamburguesa"));
        }
    }
}
