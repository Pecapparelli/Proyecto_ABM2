using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clases_biblio
{
    public static class Libros_ADO
    {
        private static string connectionString;
        private static MySqlConnection connection;
        private static MySqlCommand command;

        static Libros_ADO()
        {
            Libros_ADO.connectionString = "Server=localhost; Database=proyecto_abm; Uid=root; Pwd=;";

            Libros_ADO.connection = new MySqlConnection(Libros_ADO.connectionString);
            Libros_ADO.command = new MySqlCommand();

            Libros_ADO.command.CommandType = System.Data.CommandType.Text;
            Libros_ADO.command.Connection = Libros_ADO.connection;
        }

        #region AGREGAR
        public static bool AgregarLibro(Libros libro)
        {
            bool resultado = true;

            try
            {
                string query = "INSERT INTO libro(titulo, autor, editorial, estado) VALUES (@titulo, @autor, @editorial, @estado)";

                using (MySqlConnection connection = new MySqlConnection(Libros_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@titulo", libro.Titulo);
                        command.Parameters.AddWithValue("@autor", libro.Autor);
                        command.Parameters.AddWithValue("@editorial", libro.Editorial);
                        command.Parameters.AddWithValue("@estado", libro.Estado);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"ERROR: {ex.Message}");
                resultado = false;
            }

            return resultado;
        }
        #endregion


        #region LISTAR LIBROS

        public static List<Libros> ListarLibros()
        {
            List<Libros> libros = new List<Libros>();

            try
            {
                string query = "SELECT * FROM libro"; //Consulta que se ba a ejecutar en la base de datos

                using (MySqlConnection connection = new MySqlConnection(Libros_ADO.connectionString)) //Se instancia una conexión con la base y se abre la conexión
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection)) // Se instancia un comando que recibe como parámetros la consulta y la conección
                    {
                        using (MySqlDataReader datareader = command.ExecuteReader())
                        {
                            while (datareader.Read())
                            {
                                int inventario = datareader.GetInt16(0);
                                string titulo = datareader.GetString(1);
                                string autor = datareader.GetString(2);
                                string editorial = datareader.GetString(3);
                                string estado = datareader.GetString(4);

                                Libros libro = new Libros(inventario, titulo, autor, editorial, estado);

                                libros.Add(libro);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar o mostrar el error
                Console.WriteLine($"Error al leer autores: {ex.Message}");
            }

            return libros;
        }

        #endregion


        #region PRESTAR
        public static bool PrestarLibro(Libros libro)
        {
            bool resultado = true;

            try
            {
                string query = "UPDATE libro SET estado = 'En prestamo' WHERE inventario = @inventario";

                using (MySqlConnection connection = new MySqlConnection(Libros_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inventario", libro.Inventario);
                        command.Parameters.AddWithValue("@estado", libro.Estado);

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


        #region EDITAR LIBRO
        public static bool EditarLibro(Libros libro)
        {
            bool resultado = true;
            try
            {
                string query = "UPDATE libro SET titulo = @titulo, autor = @autor, editorial = @editorial WHERE inventario = @inventario";

                using (MySqlConnection connection = new MySqlConnection(Libros_ADO.connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@titulo", libro.Titulo);
                        command.Parameters.AddWithValue("@autor", libro.Autor);
                        command.Parameters.AddWithValue("@editorial", libro.Editorial);
                        command.Parameters.AddWithValue("@inventario", libro.Inventario);

                    command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {

            }

            return true;
        }
        #endregion
    }
}