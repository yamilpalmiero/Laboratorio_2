using System;
using System.Text;

namespace Biblioteca
{
    public class Jugador
    {
        //ATRIBUTOS
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        //CONSTRUCTORES
        private Jugador()
        {
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre)
            : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        //METODOS
        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / (float)this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Partidos jugados= {this.partidosJugados}");
            sb.AppendLine($"Goles convertidos= {this.totalGoles}");
            sb.AppendLine($"Promedio= {this.GetPromedioGoles()}");

            return sb.ToString();
        }

        //SOBRECARGAS
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
