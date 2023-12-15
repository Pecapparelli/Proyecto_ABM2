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

    #region BOT�N AGREGAR LIBRO
    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAgregarLibro agregarLibro = new frmAgregarLibro();
        agregarLibro.ShowDialog();
    }
    #endregion

    #region BOT�N EDITAR LIBRO
    private void mostrarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmEditarLibro editarLibro = new frmEditarLibro();
        editarLibro.ShowDialog();
    }
    #endregion

    #region BOT�N MOSTRAR LISTA LIBROS
    private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        List<Libros> libro = Libros_ADO.ListarLibros();
        dgvLibros.DataSource = libro;

        dgvLibros.AutoGenerateColumns = false;
    }
    #endregion



    #region BOT�N ALTA USUARIO
    private void altaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAltaUsuario altaUsuario = new frmAltaUsuario();
        altaUsuario.ShowDialog();
    }
    #endregion

    #region BOT�N MOSTRAR LISTA USUARIOS
    private void editarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        List<Usuarios> usuario = Usuarios_ADO.ListarUsuarios();
        dgvLibros.DataSource = usuario;
    }
    #endregion


}
