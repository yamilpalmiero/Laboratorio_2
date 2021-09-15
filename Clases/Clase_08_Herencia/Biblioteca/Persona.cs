using System;

namespace Biblioteca
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;

        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string MostrarPersona()
        {
            return $"Nombre: {this.nombre}\nApellido: {this.apellido}\nDNI: {this.dni}";
        }
    }
}
