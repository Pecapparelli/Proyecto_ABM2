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
    public partial class frmSuscripcion : Form
    {
        public frmSuscripcion()
        {
            InitializeComponent();

            List<Usuarios> listaUsuarios = Usuarios_ADO.ListarUsuarios();

            cmbUsuario.DataSource = listaUsuarios;
            cmbUsuario.DisplayMember = "IdNombreApellido";
            cmbUsuario.ValueMember = "Id";
            cmbUsuario.SelectedIndex = -1;
        }

        private void btnSuscribir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = cmbUsuario.SelectedIndex + 1;

                Usuarios_pago usuarioPago = new Usuarios_pago(id);

                this.DialogResult = DialogResult.OK;

                if (Usuarios_pago_ADO.UsuarioDePago(usuarioPago))
                {
                    MessageBox.Show("El usuario se registró correctamente", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo falló", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}