using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Celcius
    {
        private float valor;

        //CONSTRUCTORES
        public Celcius()
        {

        }
        public Celcius(float valor)
        {
            this.valor = valor;
        }

        //GETTER
        public float GetValor()
        {
            return this.valor;
        }


        //SOBRECARGA CASTEO EXPLICITO
        public static explicit operator Fahrenheit(Celcius gradosCelcius)
        {
            Fahrenheit gradosFahrenheit = new Fahrenheit(gradosCelcius.GetValor() * 9 / 5 + 32);

            return gradosFahrenheit;
        }
        public static explicit operator Kelvin(Celcius gradosCelcius)
        {
            Kelvin gradosKelvin = new Kelvin((float)(((Fahrenheit)gradosCelcius).GetValor() + 459.67) * 5 / 9);

            return gradosKelvin;
        }
    }
}
