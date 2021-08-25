using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static float Calcular(float numero1, float numero2, string operador)
        {
            switch (operador)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                    return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    if (Validar(numero2))
                        return numero1 / numero2;
                    else
                        return float.NaN;
                default:
                    return float.NaN;
            }
        }




        private static bool Validar(float numero)
        {
            bool retorno = false;

            if (numero != 0)
                retorno = true;

            return retorno;
        }
    }
}
