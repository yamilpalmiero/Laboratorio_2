using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        private static float temperaturaKelvin;
        private static float temperaturaCelcius;


        static void Main(string[] args)
        {
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelciusAKelvin(30);
            temperaturaCelcius = ConversorDeTemperatura.ConvertirKelvinACelcius(298);

            MostrarTemperaturas();
        }




        static void MostrarTemperaturas()
        {
            Console.WriteLine("Temperatura en Kelvin: {0}", temperaturaKelvin);
            Console.WriteLine("Temperatura en Celcius: {0}", temperaturaCelcius);
        }
    }
}
