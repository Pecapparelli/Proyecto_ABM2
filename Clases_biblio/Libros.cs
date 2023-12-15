using System.ComponentModel;

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

        public int Inventario { get => inventario; set => inventario = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Estado { get => estado; set => estado = value; }



        public override string ToString()
        {
            return $"N° de inventario: {Inventario} - Título: {Titulo} - Autor: {Autor} - Editorial: {Editorial} - El libro se encuenra {Estado}";
        }
    }
}
