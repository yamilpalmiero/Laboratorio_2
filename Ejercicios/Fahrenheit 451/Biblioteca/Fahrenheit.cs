using System;

namespace Biblioteca
{
    public class Fahrenheit
    {
        private float valor;

        //CONSTRUCTORES
        public Fahrenheit()
        {

        }
        public Fahrenheit(float valor)
        {
            this.valor = valor;
        }

        //GETTER
        public float GetValor()
        {
            return this.valor;
        }


        //SOBRECARGA CASTEO EXPLICITO
        public static explicit operator Celcius(Fahrenheit gradosFahrenheit)
        {
            Celcius gradosCelcius = new Celcius((gradosFahrenheit.GetValor() - 32) * 5 / 9);

            return gradosCelcius;
        }
        public static explicit operator Kelvin(Fahrenheit gradosFahrenheit)
        {
            Kelvin gradosKelvin = new Kelvin((float)(gradosFahrenheit.GetValor() + 459.67) * 5 / 9);

            return gradosKelvin;
        }
    }
}
