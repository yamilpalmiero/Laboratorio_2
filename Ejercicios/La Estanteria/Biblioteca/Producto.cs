using System;

namespace Biblioteca
{
    public class Producto
    {
        //ATRIBUTOS
        private string codigoDeBarra;
        private string marca;
        private float precio;


        //CONSTRUCTORES
        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }


        //METODOS
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"Codigo de barra: {p.codigoDeBarra}\nMarca: {p.marca}\nPrecio: {p.precio}";
        }


        //SOBRECARGAS
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if((p1 is null || p2 is null))
                return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
        }
        
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
