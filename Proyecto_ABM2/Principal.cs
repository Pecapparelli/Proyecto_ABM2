namespace Proyecto_ABM2;

using Clases_biblio;
using Proyecto_ABM2.LibrosForm;
using Proyecto_ABM2.UsuariosForm;
using System.Runtime.Serialization.Formatters.Binary;
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
    private void mostrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
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

    #region ARCHIVO .TXT LIBROS
    private void exportartxtToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string directorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string carpeta = @"\Archivos ABM";
        string nombreArchivo = @"\Catálogo.txt";
        string path = directorio + carpeta + nombreArchivo; //declaro un path con los atributos que estan en las lineas anteriores

        List<Libros> catalogo = Libros_ADO.ListarLibros();
        try
        {
            if (File.Exists(path)) //si el archivo de la ruta existe
            {
                DialogResult resultado = MessageBox.Show("El archivo ya contiene datos ¿Desea actualizar?", "Error", MessageBoxButtons.OKCancel); //le pregunto si desea pisar los datos
                if (resultado == DialogResult.OK)//si ingresa ok
                {
                    File.Delete(path);//elimina el archivo
                    Libros.CatalogoTxt(directorio, nombreArchivo, carpeta, catalogo);
                    MessageBox.Show("El archivo se ha actualizado de manera correcta");
                }
                else
                {
                    MessageBox.Show("No se actualizo el archivo de texto");
                }
            }
            else//si el archivo no existe
            {
                Libros.CatalogoTxt(directorio, nombreArchivo, carpeta, catalogo); //le pido que cree un nuevo archivo
                MessageBox.Show("El archivo se ha creado con exito");
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    #endregion

    #region ARCHIVO .XML LIBROS
    private void exportarXMLToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Archivos ABM\\Catálogo.xml"; //declaro el path  
                                                                                                                     //utilizando el environment get folder path para obtener la ruta del escritorio del usuario en el sistema y espeficia la carpeta q deseo obtener
        List<Libros> catalogo = Libros_ADO.ListarLibros();
        try
        {
            if (File.Exists(path)) //si el archivo de la ruta existe
            {
                DialogResult result = MessageBox.Show("El archivo ya contiene datos, desea pisarlos?", "Error", MessageBoxButtons.OKCancel);
                //le pregunto si desea pisar los datos
                if (result == DialogResult.OK)//si ingresa ok
                {
                    File.Delete(path);//elimina el archivo
                    Serializar.Escribir(catalogo, path); //lo vuelve a crear
                    MessageBox.Show("El archivo se ha actualizado de manera correcta");
                }
                else
                {
                    MessageBox.Show("No se actualizo el archivo de texto");
                }
            }
            else//si el archivo no existe
            {
                Serializar.Escribir(catalogo, path); //le pido que cree un nuevo archivo
                MessageBox.Show("El archivo se ha creado con exito");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    #endregion

    #region BOTÓN ALTA USUARIO
    private void altaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmAltaUsuario altaUsuario = new frmAltaUsuario();
        altaUsuario.ShowDialog();
    }
    #endregion


    #region BOTON EDITAR USUARIO
    private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmEditarUsuario editarUsuario = new frmEditarUsuario();
        editarUsuario.ShowDialog();
    }
    #endregion

    private void suscribirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmSuscripcion suscripcion = new frmSuscripcion();
        suscripcion.ShowDialog();
    }

    #region BOTÓN MOSTRAR LISTA USUARIOS
    private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        dgvLibros.Columns.Clear();

        List<Usuarios> usuario = Usuarios_ADO.ListarUsuarios();

        dgvLibros.AutoGenerateColumns = false;

        AgregarColumna("ID", "Id");

        AgregarColumna("Nombre", "Nombre");

        AgregarColumna("Apellido", "Apellido");

        AgregarColumna("DNI", "Dni");

        AgregarColumna("Prestamo", "Prestamo");

        dgvLibros.DataSource = usuario;
    }
    #endregion

    private void usuariosPagoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        dgvLibros.Columns.Clear();

        List<Usuarios_pago> usuarioPago = Usuarios_pago_ADO.ListarUsuariosPagos();

       
        dgvLibros.AutoGenerateColumns = false;

        AgregarColumna("ID", "Id");

        AgregarColumna("Nombre", "Nombre");

        AgregarColumna("Apellido", "Apellido");

        AgregarColumna("DNI", "Dni");

        AgregarColumna("Prestamo 1", "Prestamo");

        AgregarColumna("Prestamo 2", "Prestamo2");
         
        AgregarColumna("Prestamo 3", "Prestamo3");

        AgregarColumna("Vencimiento", "Vencimiento");

        dgvLibros.DataSource = usuarioPago;
    }
}
