using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;


        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }


        public string Nombre
        {
            get { return this.nombre; }
        }
        public DateTime Fecha
        {
            get { return this.fechaCreacion; }
        }


        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool retorno = false;

            if (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }


        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion.ToString("yyyy/mm/dd")}");

            return sb.ToString();
        }
    }
}
