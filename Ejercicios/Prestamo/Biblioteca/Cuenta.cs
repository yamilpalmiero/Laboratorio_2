using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }
        public decimal Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public string Mostrar()
        {
            return $"La razon social es {this.Titular} y tiene ${this.Cantidad.ToString()}.- en su cuenta.";
        }

        public void Ingresar(decimal credito)
        {
            if (credito > 0)
            {
                this.Cantidad += credito;
            }
        }

        public void Retirar(decimal debito)
        {
            this.Cantidad -= debito;
        }
    }
}
