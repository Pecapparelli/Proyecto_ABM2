using Org.BouncyCastle.Asn1.Mozilla;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace Clases_biblio
{
    public class Libros
    {
        private int inventario;
        private string titulo;
        private string autor;
        private string editorial;
        private string estado;

        //CONSTRUCTOR AGREGAR LIBRO
        public Libros(string titulo, string autor, string editorial, string estado)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = editorial;
            this.estado = estado;
        }

        //CONSTRUCTOR PARA LISTAR LIBROS
        public Libros(int inventario, string titulo, string autor, string editorial, string estado)
        {
            this.inventario = inventario;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = editorial;
            this.estado = estado;
        }

        //CONSTRUCTOR SERIALIZER
       public Libros()
        {
        }

        public int Inventario { get => inventario; set => inventario = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Estado { get => estado; set => estado = value; }

        public string InventarioTitulo => $"{Inventario} - {Titulo}";



        public override string ToString()
        {
            return $"N° {Inventario} - Título: {Titulo} - Autor: {Autor} - Editorial: {Editorial} - El libro se encuenra: {Estado}";
        }

        public static void CatalogoTxt(string directorio, string nombreArchivo, string carpeta, List<Libros> catalogo)
        {
            string path = directorio + carpeta + nombreArchivo;

            StreamWriter sw = new StreamWriter(path, false);
            try
            {
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                foreach (Libros libro in catalogo)
                {
                    sw.WriteLine(libro);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            finally 
            {
                sw.Close();
            }

        }
    }
}
