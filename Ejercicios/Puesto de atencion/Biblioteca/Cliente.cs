﻿using System;

namespace Biblioteca
{
    public class Cliente
    {
        //ATRIBUTOS
        private string nombre;
        private int numero;


        //CONSTRUCTORES
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero)
            : this(numero)
        {
            this.nombre = nombre;
        }


        //PROPIEDADES
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Numero
        {
            get { return this.numero; }
        }


        //SOBRECARGAS
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
