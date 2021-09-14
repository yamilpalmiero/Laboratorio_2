using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        //ATRIBUTOS
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;


        //CONSTRUCTORES
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }


        //PROPIEDADES
        public Cliente Cliente
        {
            get
            {
                if (clientes.Count > 0)
                    return clientes.Dequeue();

                return null;
            }
            set
            {
                foreach (Cliente item in this.clientes)
                {
                    if (item != value)
                        clientes.Enqueue(value);
                }
            }
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }


        //SOBRECARGAS
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }

            return false;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
