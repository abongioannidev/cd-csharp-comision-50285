using clase15022024.Exceptions;
using clase15022024.Models;
using System.Data.SqlClient;

namespace clase15022024.AdoNet
{
    public static class UsuarioADO
    {
        /// <summary>
        /// Obtiene todos los datos del usuario desde la BD
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DataBaseException"></exception>
        public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            try
            {
                using (SqlConnection connection = ConnectionADO.GetConnection())
                {
                    List<Usuario> usuarios = new List<Usuario>();
                    string query = "SELECT * FROM Usuario";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["Id"]);
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Apellido = reader["Apellido"].ToString();
                        usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.Password = reader["Contraseña"].ToString();
                        usuario.Email = reader["Mail"].ToString();

                        usuarios.Add(usuario);
                    }
                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseException("Error al obtener todos los usuarios", ex);
            }


        }
        public static Usuario? ObtenerUsuarioPorId(int id)
        {
            try
            {
                List<Usuario> usuarios = UsuarioADO.ObtenerTodosLosUsuarios();
                return usuarios.Find(u => u.Id == id);

            }
            catch(Exception ex)
            {
                throw new DataBaseException("Error al obtenene un usuario por id", ex);
            }

        }

        public static bool BorrarUsuarioPorId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }
        public static bool CrearUsuario(Usuario nuevoUsuario)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) VALUES " +
                    "(@nombre,@apellido,@nombreUsuario,@password,@email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("nombre", nuevoUsuario.Nombre);
                command.Parameters.AddWithValue("apellido", nuevoUsuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", nuevoUsuario.NombreUsuario);
                command.Parameters.AddWithValue("password", nuevoUsuario.Password);
                command.Parameters.AddWithValue("email", nuevoUsuario.Email);
                return command.ExecuteNonQuery() > 0;

            }

        }

        public static bool ActualizarUsuario(Usuario nuevoUsuario)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE Usuario SET Nombre = @nombre,Apellido = @apellido, NombreUsuario = @nombreUsuario,Contraseña = @password,Mail = @email WHERE Id = @id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevoUsuario.Id);
                command.Parameters.AddWithValue("nombre", nuevoUsuario.Nombre);
                command.Parameters.AddWithValue("apellido", nuevoUsuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", nuevoUsuario.NombreUsuario);
                command.Parameters.AddWithValue("password", nuevoUsuario.Password);
                command.Parameters.AddWithValue("email", nuevoUsuario.Email);
                return command.ExecuteNonQuery() > 0;

            }

        }
    }
}
