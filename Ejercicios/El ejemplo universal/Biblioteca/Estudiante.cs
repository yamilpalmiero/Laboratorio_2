using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public int SetNotaPrimerParcial
        {
            set { this.notaPrimerParcial = value; }
        }
        public int SetNotaSegundoParcial
        {
            set { this.notaSegundoParcial = value; }
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2F;
        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
                return random.Next(6, 11);

            else
                return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ALUMNO:");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}\n");

            sb.AppendLine($"Nota 1er parcial: {this.notaPrimerParcial.ToString()}");
            sb.AppendLine($"Nota 2do parcial: {this.notaSegundoParcial.ToString()}\n");

            sb.AppendLine($"Promedio: {this.CalcularPromedio().ToString()}");

            if (CalcularNotaFinal() != -1)
                sb.AppendLine($"Nota final: {this.CalcularNotaFinal().ToString()}");
            else
                sb.AppendLine("Alumno desaprobado");

            return sb.ToString();
        }
    }
}
