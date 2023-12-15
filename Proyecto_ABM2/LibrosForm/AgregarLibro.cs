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

namespace Proyecto_ABM2.LibrosForm
{
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string editorial = txtEditorial.Text;
            string estado = "Disponible";

            Libros nuevoLibro = new Libros(titulo, autor, editorial, estado);

            try
            {
                if (Libros_ADO.AgregarLibro(nuevoLibro))
                {
                    MessageBox.Show("El libro se cargó correctamente", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
