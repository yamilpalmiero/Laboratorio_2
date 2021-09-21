using System;

namespace Biblioteca
{
    public abstract class Figura //Abstracta porque dice el ejercicio que no se puede instanciar
    {
        public virtual string Dibujar()
        {
            return $"Dibujando forma...";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}
