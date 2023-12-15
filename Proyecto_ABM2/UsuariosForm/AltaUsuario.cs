using Clases_biblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ABM2.UsuariosForm
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string prestamo = "-";



            Usuarios nuevoUsuario = new Usuarios(nombre, apellido, dni, prestamo);

            try
            {
                if (Usuarios_ADO.AltaUsuario(nuevoUsuario))
                {
                    MessageBox.Show("El usuario se cargó correctamente", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo falló", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

            }

        }
    }
}
