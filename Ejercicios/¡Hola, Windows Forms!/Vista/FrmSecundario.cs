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
    public partial class FrmSecundario : Form
    {
        private string titulo;
        private string mensaje;


        public FrmSecundario(string mensaje, string titulo)
        {
            InitializeComponent();
            this.mensaje = mensaje;
            this.titulo = titulo;
        }

        private void FrmSecundario_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }
    }
}
