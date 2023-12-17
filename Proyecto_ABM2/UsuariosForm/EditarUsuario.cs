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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();

            List<Usuarios> listaUsuarios = Usuarios_ADO.ListarUsuarios();

            cmbUsuario.DataSource = listaUsuarios;
            cmbUsuario.DisplayMember = "IdNombreApellido";
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.SelectedIndex = -1;
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtDni.Text = null;

            if (cmbUsuario.SelectedItem != null)
            {
                Usuarios usuarioSeleccionado = (Usuarios)cmbUsuario.SelectedItem;

                txtNombre.Text = $"{usuarioSeleccionado.Nombre}";
                txtApellido.Text = $"{usuarioSeleccionado.Apellido}";
                txtDni.Text = $"{usuarioSeleccionado.Dni}";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = cmbUsuario.SelectedIndex + 1;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;

                Usuarios usuarioEditado = new Usuarios(id, nombre, apellido, dni);

                this.DialogResult = DialogResult.OK;

                if (Usuarios_ADO.EditarUsuario(usuarioEditado))
                {
                    MessageBox.Show("El usuario se editó correctamente", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo falló", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"ERROR: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
