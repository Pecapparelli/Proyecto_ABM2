using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_biblio
{
    internal class Usuarios_pago_ADO
    {
        private static string connectionString;
        private static MySqlConnection connection;
        private static MySqlCommand command;

        static Usuarios_pago_ADO()
        {
            Usuarios_pago_ADO.connectionString = "Server=localhost; Database=proyecto_abm; Uid=root; Pwd=;";

            Usuarios_pago_ADO.connection = new MySqlConnection(Usuarios_pago_ADO.connectionString);
            Usuarios_pago_ADO.command = new MySqlCommand();

            Usuarios_pago_ADO.command.CommandType = System.Data.CommandType.Text;
            Usuarios_pago_ADO.command.Connection = Usuarios_pago_ADO.connection;
        }

        public static bool AltaUsuarioPago()
        {
            bool resultado = true;

            try
            {
                string query = "INSERT INTO usuario_pago(nombre, apellido, dni, prestamo) VALUES (@nombre, @apellido, @dni, @prestamo)";

                using (MySqlConnection connection = new MySqlConnection(Usuarios_pago_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        //command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        //command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        //command.Parameters.AddWithValue("@dni", usuario.Dni);
                        //command.Parameters.AddWithValue("@prestamo", usuario.Prestamo);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
