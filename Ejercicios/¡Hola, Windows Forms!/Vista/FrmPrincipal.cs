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
            FrmSecundario frmSecundario = new FrmSecundario($"Soy {txtNombre.Text} {txtApellido.Text} " +
                $"y mi materia favorita es {cmbMateria.SelectedItem.ToString()}", "¡Hola, Windows Forms!");

            frmSecundario.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cmbMateria.Items.Add("Programacion I");
            cmbMateria.Items.Add("Matematica");
            cmbMateria.Items.Add("Ingles I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Programacion II");
            cmbMateria.Items.Add("Estadistica");
            cmbMateria.Items.Add("Ingles II");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
        }
    }
}
