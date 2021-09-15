using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante : Persona
    {
        public int legajo;
        public List<string> materias;

        public Estudiante(List<string> materias, int legajo, string nombre, string apellido, long dni)
            : base(nombre, apellido, dni)
        {
            this.materias = new List<string>();
            this.legajo = legajo;
        }


        public string Estudiar()
        {
            return $"Estoy estudiando...";
        }

        public string MostrarAlumno()
        {
            return $"{base.MostrarPersona()}\nLegajo: {this.legajo}";
        }
    }
}
