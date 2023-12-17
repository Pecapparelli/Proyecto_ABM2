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

            //Inicia el ComboBox con el formulario
            List<Libros> listaLibros = Libros_ADO.ListarLibros();

            //Se hace una lista de libros solo con los que se encuentran en estado diferente a "No disponible"
            List<Libros> librosDisponibles = listaLibros.Where(libro => libro.Estado != "No disponible").ToList();

            cmbLibros.DataSource = librosDisponibles;
            cmbLibros.DisplayMember = "InventarioTitulo";
            cmbLibros.ValueMember = "Inventario";
            cmbLibros.SelectedIndex = -1;
        }

        private void cmbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpia los TextBox antes de cargar la info del ComboBox
            txtTitulo.Text = null;
            txtEditorial.Text = null;
            txtAutor.Text = null;

            if (cmbLibros.SelectedItem != null)
            {
                Libros libroSeleccionado = (Libros)cmbLibros.SelectedItem;

                txtTitulo.Text = $"{libroSeleccionado.Titulo}";
                txtAutor.Text = $"{libroSeleccionado.Autor}";
                txtEditorial.Text = $"{libroSeleccionado.Editorial}";

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int inventario = cmbLibros.SelectedIndex + 1;
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string editorial = txtEditorial.Text;
            string estado;
            
            
            if (!chbBaja.Checked) 
            {
                estado = "Disponible";
            }
            else 
            {
                estado = "No disponible";
            }

            Libros libroEditado = new Libros(inventario, titulo, autor, editorial, estado);
            this.DialogResult = DialogResult.OK;
            try
            {
                if (Libros_ADO.EditarLibro(libroEditado))
                {
                    MessageBox.Show("El libro se editó correctamente", "Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
