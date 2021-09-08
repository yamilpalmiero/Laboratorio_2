using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();

            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList();

            podio.Sort(CompararCantidadRepeticiones);
            MostrarPodio(podio);
        }




        //METODOS
        private Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtbTexto.Text;
            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                    contadorPalabras[palabra]++;

                else
                    contadorPalabras.Add(palabra, 1);
            }

            return contadorPalabras;
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        private void MostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if (podio.Count == 0)
                sb.AppendLine("Nose ingresaron palabras");
            else
            {
                for (int i = 0; i < 3 && i < podio.Count; i++)
                {
                    KeyValuePair<string, int> par = podio[i];
                    sb.AppendLine($"Palabra: {par.Key} - Cantidad: {par.Value}");
                }
            }

            MessageBox.Show(sb.ToString(), "Podio");
        }
    }
}
