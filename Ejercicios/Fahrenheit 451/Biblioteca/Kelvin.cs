using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Kelvin
    {
        private float valor;

        //CONSTRUCTORES
        public Kelvin()
        {

        }
        public Kelvin(float valor)
        {
            this.valor = valor;
        }

        //GETTER
        public float GetValor()
        {
            return this.valor;
        }


        //SOBRECARGA CASTEO EXPLICITO
        public static explicit operator Fahrenheit(Kelvin gradosKelvin)
        {
            Fahrenheit gradosFahrenheit = new Fahrenheit((float)(gradosKelvin.GetValor() * 9 / 5 - 459.67));

            return gradosFahrenheit;
        }
        public static explicit operator Celcius(Kelvin gradosKelvin)
        {
            Celcius gradosCelcius = new Celcius();

            return gradosCelcius;
        }
    }
}
