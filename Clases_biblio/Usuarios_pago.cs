using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_biblio
{
    public class Usuarios_pago : Usuarios
    {
        private string prestamo2;
        private string prestamo3;
        private string vencimiento;

        public Usuarios_pago(int id, string nombre, string apellido, string dni, string prestamo, string prestamo2, string prestamo3, string vencimiento) : base(id, nombre, apellido, dni, prestamo)
        {
            this.Prestamo2 = prestamo2;
            this.Prestamo3 = prestamo3;
            this.Vencimiento = vencimiento;
        }

        //CONSTRUCTOR REGISTRO
        public Usuarios_pago(int id) : base(id)
        {
            this.Id = id;
        }

        public string Prestamo2 { get => prestamo2; set => prestamo2 = value; }
        public string Prestamo3 { get => prestamo3; set => prestamo3 = value; }
        public string Vencimiento { get => vencimiento; set => vencimiento = value; }

        public override string ToString()
        {
            return $"ID: {Id} Nombre: {Nombre} Apellido {Apellido} DNI: {Dni} Libro en prestamo: {Prestamo}, {Prestamo2}, {Prestamo3} Su usuario pago vence: {Vencimiento}";
        }

    }
}
