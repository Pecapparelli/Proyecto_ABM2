namespace Proyecto_ABM2;

using Clases_biblio;
using Proyecto_ABM2.LibrosForm;
using Proyecto_ABM2.UsuariosForm;
using System.Windows.Forms;

public partial class frmPrincipal : Form
{
    public frmPrincipal()
    {
        InitializeComponent();
    }

    private void AgregarColumna(string titulo, string propiedad)
    {
        DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
        nuevaColumna.HeaderText = titulo;
        nuevaColumna.DataPropertyName = propiedad;
        dgvLibros.Columns.Add(nuevaColumna);
    }

    #region BOTÓN AGREGAR LIBRO
    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAgregarLibro agregarLibro = new frmAgregarLibro();
        agregarLibro.ShowDialog();
    }
    #endregion

    #region BOTÓN EDITAR LIBRO
    private void mostrarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmEditarLibro editarLibro = new frmEditarLibro();
        editarLibro.ShowDialog();
    }
    #endregion

    #region BOTÓN MOSTRAR LISTA LIBROS
    private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //dgvLibros.DataSource = null;
        dgvLibros.Columns.Clear();

        List<Libros> libro = Libros_ADO.ListarLibros();       

        dgvLibros.AutoGenerateColumns = false;

        AgregarColumna("N° Inventario", "Inventario");

        AgregarColumna("Título", "Titulo");

        AgregarColumna("Autor", "Autor");

        AgregarColumna("Editorial", "Editorial");

        AgregarColumna("Estado", "Estado");

        dgvLibros.DataSource = libro;
    }
    #endregion



    #region BOTÓN ALTA USUARIO
    private void altaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAltaUsuario altaUsuario = new frmAltaUsuario();
        altaUsuario.ShowDialog();
    }
    #endregion

    #region BOTÓN MOSTRAR LISTA USUARIOS
    private void editarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        dgvLibros.Columns.Clear();

        List<Usuarios> usuario = Usuarios_ADO.ListarUsuarios();

        dgvLibros.AutoGenerateColumns=false;

        AgregarColumna("ID", "Id");

        AgregarColumna("Nombre","Nombre");

        AgregarColumna("Apellido","Apellido");

        AgregarColumna("DNI","Dni");

        AgregarColumna("Prestamo", "Prestamo");

        dgvLibros.DataSource = usuario;
    }
    #endregion


}
