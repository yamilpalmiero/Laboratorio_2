using System;

namespace Biblioteca
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;

        /// <summary>
        /// Convierte una temperatura en grados Celcius a grados Kelvin
        /// </summary>
        /// <param name="temperaturaCelcius">Temperatura en grados Celcius a convertir</param>
        /// <returns>Temperatura en grados Kelvin correspondiente al argumento proporcionado</returns>
        public static float ConvertirCelciusAKelvin(float temperaturaCelcius)
        {
            float temperaturaKelvin = temperaturaCelcius + ceroAbsoluto;

            return temperaturaKelvin;
        }


        /// <summary>
        /// Convierte la temperatura en grados Kelvin a grados Celcius
        /// </summary>
        /// <param name="temperaturaKelvin">Temperatura en Kelvin a convertir</param>
        /// <returns>Temperatura convertida a grados Celcius</returns>
        public static float ConvertirKelvinACelcius(float temperaturaKelvin)
        {
            float temperaturaCelcius = temperaturaKelvin - ceroAbsoluto;

            return temperaturaCelcius;
        }
    }
}
