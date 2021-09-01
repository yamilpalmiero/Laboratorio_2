using System;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        public string Especie
        {
            get { return this.especie; }
            set { this.especie = value; }
        }
    }
}
