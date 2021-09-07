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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            FrmSecundario frmSecundario = new FrmSecundario($"Soy {txtNombre.Text} {txtApellido.Text}", "¡Hola, Windows Forms!");

            frmSecundario.ShowDialog();
        }
    }
}
