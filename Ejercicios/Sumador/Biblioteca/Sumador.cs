﻿using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;


        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador()
            : this(0)
        {

        }


        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;

            return a + b;
        }


        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (int)s1 == (int)s2;
        }
    }
}
