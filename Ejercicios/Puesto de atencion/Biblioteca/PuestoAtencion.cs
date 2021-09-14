using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        //ENUMERADO
        public enum Puesto
        {
            Caja1,
            Caja2
        }


        //ATRIBUTOS
        private static int numeroActual;
        private Puesto puesto;


        //CONSTRUCTORES
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }


        //PROPIEDADES
        static int NumeroActual
        {
            get { return ++PuestoAtencion.numeroActual; }
        }


        //METODOS
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
                Thread.Sleep(3000);

            return true;
        }
    }
}
