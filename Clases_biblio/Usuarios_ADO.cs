using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Clases_biblio
{
    public static class Usuarios_ADO
    {
        private static string connectionString;
        private static MySqlConnection connection;
        private static MySqlCommand command;

        static Usuarios_ADO()
        {
            Usuarios_ADO.connectionString = "Server=localhost; Database=proyecto_abm; Uid=root; Pwd=;";

            Usuarios_ADO.connection = new MySqlConnection(Usuarios_ADO.connectionString);
            Usuarios_ADO.command = new MySqlCommand();

            Usuarios_ADO.command.CommandType = System.Data.CommandType.Text;
            Usuarios_ADO.command.Connection = Usuarios_ADO.connection;
        }

        #region ALTA USUARIO
        public static bool AltaUsuario(Usuarios usuario)
        {
            bool resultado = true;

            try
            {
                string query = "INSERT INTO usuario(nombre, apellido, dni, prestamo) VALUES (@nombre, @apellido, @dni, @prestamo)";

                using (MySqlConnection connection = new MySqlConnection(Usuarios_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@dni", usuario.Dni);
                        command.Parameters.AddWithValue("@prestamo", usuario.Prestamo);

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
        #endregion

        #region LISTAR USUARIOS
        public static List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            try
            {
                string query = "SELECT * FROM usuario"; //Consulta que se va a ejecutar en la base de datos

                using (MySqlConnection connection = new MySqlConnection(Usuarios_ADO.connectionString)) //Se instancia una conexión con la base y se abre la conexión
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection)) // Se instancia un comando que recibe como parámetros la consulta y la conección
                    {
                        using (MySqlDataReader datareader = command.ExecuteReader())
                        {
                            while (datareader.Read())
                            {
                                int id = datareader.GetInt16(0);
                                string nombre = datareader.GetString(1);
                                string apellido = datareader.GetString(2);
                                string dni = datareader.GetString(3);
                                string prestamo = datareader.GetString(4);

                                Usuarios usuario = new Usuarios(id, nombre, apellido, dni, prestamo);

                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return usuarios;
        }

        #endregion

        #region EDITAR USUARIO

        public static bool EditarUsuario(Usuarios usuario)
        {
            bool resultado = true;

            try
            {
                string query = "UPDATE usuario SET nombre = @nombre, apellido = @apellido, dni = @dni WHERE id = @id";

                using (MySqlConnection connection = new MySqlConnection(Usuarios_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@dni", usuario.Dni);
                        command.Parameters.AddWithValue("@id", usuario.Id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {

            }

            return resultado;
        }

        #endregion

    }
}
