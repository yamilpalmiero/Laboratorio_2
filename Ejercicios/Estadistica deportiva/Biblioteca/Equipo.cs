using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        //ATRIBUTOS
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        //CONSTRUCTORES
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        //SOBRECARGA
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j) || e.jugadores.Count >= e.cantidadDeJugadores)
                return false;

            e.jugadores.Add(j);
            return true;
        }
    }
}
