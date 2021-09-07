using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea crear un formulario?", "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                FrmSecundario frmSecundario = new FrmSecundario();

                //frmSecundario.Show();//No es modal
                frmSecundario.ShowDialog();
                Thread.Sleep(2000);
                frmSecundario.Hide();
                Thread.Sleep(2000);
            }
            else if (resultado == DialogResult.No)
                MessageBox.Show("Puse NO");
            else if (resultado == DialogResult.Cancel)
                Close();//Cierra el formulario
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtNombre.Text, (int)numEdad.Value);

            MessageBox.Show(persona.Mostrar());
            lblNombre.Text = txtNombre.Text;

            if (rbUno.Checked)
                MessageBox.Show("Se marco el radio 1");

            if (chCuatro.Checked)
                MessageBox.Show("Se marco el check 1");

            string listItem = (string)listBox1.SelectedItem;
            if (listItem != null)
                MessageBox.Show(listItem.ToString());

            string comboItem = (string)comboBox1.SelectedItem;
            MessageBox.Show(comboItem.ToString());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            chSeis.CheckState = CheckState.Indeterminate;

            listBox1.Items.Add("Yamil");
            listBox1.Items.Add("Mariana");
            listBox1.Items.Add("Selene");

            comboBox1.Items.Add("Yamil");
            comboBox1.Items.Add("Mariana");
            comboBox1.Items.Add("Selene");
        }
    }
}
