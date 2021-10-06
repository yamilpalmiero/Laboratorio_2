using System;

namespace Biblioteca
{
    public static class StringExtendido
    {
        public static int ContarPalabras(this string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                throw new ArgumentException();
            }

            return cadena.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
