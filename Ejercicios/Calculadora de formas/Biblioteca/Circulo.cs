using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public Circulo()
        {

        }

        public Circulo(double radio)
            : this()
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return $"Dibujando circulo.";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
