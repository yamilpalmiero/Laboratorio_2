using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private double lado;
        private double altura;

        public Rectangulo()
        {

        }

        public Rectangulo(double lado, double altura)
        {
            this.lado = lado;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return $"Dibujando rectangulo.";
        }

        public override double CalcularSuperficie()
        {
            return lado * altura;
        }

        public override double CalcularPerimetro()
        {
            return lado * 2 + altura * 2;
        }
    }
}
