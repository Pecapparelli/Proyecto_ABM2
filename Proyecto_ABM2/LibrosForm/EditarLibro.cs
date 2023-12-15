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
    public partial class frmEditarLibro : Form
    {
        public frmEditarLibro()
        {
            InitializeComponent();

            List<Libros> listaLibros = Libros_ADO.ListarLibros();

            cmbLibros.DataSource = listaLibros;
            cmbLibros.DisplayMember = "InventarioTitulo";
            cmbLibros.ValueMember = "Inventario";
            cmbLibros.SelectedIndex = -1;
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedItem != null)
            {
                Libros libroseleccionado = (Libros)cmbLibros.SelectedItem;

                txtTitulo.Text = $"{libroseleccionado.Titulo}";
                txtAutor.Text = $"{libroseleccionado.Autor}";
                txtEditorial.Text = $"{libroseleccionado.Editorial}";

            }
        }
    }
}
