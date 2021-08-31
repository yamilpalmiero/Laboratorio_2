using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 10;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int tintaFinal;

            if (tinta <= cantidadTintaMaxima)
                tintaFinal += tinta;

            if (tinta <= cantidadTintaMaxima && )
            {
                this.tinta += tinta;
            }
        }
    }
}
