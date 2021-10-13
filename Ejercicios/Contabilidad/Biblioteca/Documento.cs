using System;

namespace Biblioteca
{
    public class Documento
    {
        protected int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public int Numero
        {
            get { return this.numero; }
        }
    }
}
