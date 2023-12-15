using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_biblio
{
    public class Usuarios
    {
        private int id;
        private string nombre;
        private string apellido;
        private string dni;
        private string prestamo;


        //CONSTRUCTOR ALTA USUARIO
        public Usuarios(string nombre, string apellido, string dni, string prestamo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Prestamo = prestamo;
        }

        //CONSTRUCTOR MOSTRAR LISTA
        public Usuarios(int id, string nombre, string apellido, string dni, string prestamo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Prestamo = prestamo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Prestamo { get => prestamo; set => prestamo = value; }

        public override string ToString()
        {
            return $"ID: {Id} Nombre: {Nombre} Apellido {Apellido} DNI: {Dni} Libro en prestamo: {Prestamo}";
        }
    }
}
