using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_biblio
{
    public static class Usuarios_pago_ADO
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

        #region DE USUARIO A USUARIO PAGO
        public static bool UsuarioDePago(Usuarios_pago usuario)
        {
            bool resultado = true;

            try
            {
                string insertQuery = "INSERT INTO usuario_pago(id, nombre, apellido, dni, prestamo1, prestamo2, prestamo3, vencimiento)" +
                    "SELECT id, nombre, apellido, dni, prestamo, '-', '-', DATE_ADD(CURRENT_DATE, INTERVAL 1 MONTH)" +
                    "FROM usuario WHERE id =@id";

                using (MySqlConnection connection = new MySqlConnection(Usuarios_pago_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", usuario.Id);

                        command.ExecuteNonQuery();
                    }
                }

                string deleteQuery = "DELETE FROM usuario WHERE Id = @id;";

                using (MySqlConnection connection = new MySqlConnection(Usuarios_pago_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
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

        #region LISTAR USUARIOS PAGOS
        public static List<Usuarios_pago> ListarUsuariosPagos()
        {
            List<Usuarios_pago> usuariosPagos = new List<Usuarios_pago>();
            try
            {
                string query = "SELECT * FROM usuario_pago"; //Consulta que se va a ejecutar en la base de datos

                using (MySqlConnection connection = new MySqlConnection(Usuarios_pago_ADO.connectionString)) //Se instancia una conexión con la base y se abre la conexión
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
                                string prestamo2 = datareader.GetString(5);
                                string prestamo3 = datareader.GetString(6);
                                string vencimiento = datareader.GetString(7);

                                Usuarios_pago usuarioPago = new Usuarios_pago(id, nombre, apellido, dni, prestamo, prestamo2, prestamo3, vencimiento);

                                usuariosPagos.Add(usuarioPago);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return usuariosPagos;
        }
        #endregion

    }
}
