using System;

namespace Biblioteca
{
    public class Tiempo
    {
        public int hora;
        public int minutos;
        public int segundos;
        private string formato;




        //SOBRECARGA CONSTRUCTORES
        public Tiempo(int hora, int minutos, string formato)
            : this(hora, minutos, 0)
        {
            this.formato = formato;
        }

        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }






        //SOBRECARGA DE OPERADORES
        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }




        //SOBRECARGA CONVERSION IMPLICITA
        public static implicit operator int (Tiempo t)
        {
            return (((t.hora * 60) + t.minutos) * 60) + t.segundos;
        }



        //SOBRECARGA CONVERSION EXPLICITA
        public static explicit operator Tiempo(string t)
        {
            string[] tiempoStr = t.Split(':');

            return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        }
    }
}
