using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        Random random = new Random();


        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }


        public string Nombre
        {
            get { return this.nombre; }
        }
        public List<T> Equipos
        {
            get { return this.equipos; }
        }


        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;

            foreach (Equipo item in torneo.equipos)
            {
                if (item == equipo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo is not null && equipo is not null && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine($"Equipos:");
            foreach (T item in equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            int scoreE1 = random.Next(0, 5);
            int scoreE2 = random.Next(0, 5);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{equipo1.Nombre} ({scoreE1}) - ({scoreE2}) {equipo2.Nombre}");

            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                int index1 = random.Next(0, this.equipos.Count - 1);
                int index2 = random.Next(0, this.equipos.Count - 1);

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(CalcularPartido(this.equipos[index1], this.equipos[index2]));

                return sb.ToString();
            }
        }
    }
}
