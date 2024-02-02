using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase01022023
{
    public static class UsuarioADO
    {
        private static string connectionString;


        static UsuarioADO()
        {
            UsuarioADO.connectionString = "Server=.; Database=coderhousetest; Trusted_Connection=True;";
        }

        public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            try
            {
                List<Usuario> listadoDeUsuarios = new List<Usuario>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM USUARIO;";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["Id"]);
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Apellido = reader["Apellido"].ToString();
                        usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.Password = reader["Contraseña"].ToString();
                        usuario.Email = reader["Mail"].ToString();

                        listadoDeUsuarios.Add(usuario);

                    }
                }

                return listadoDeUsuarios;

            }
            catch (Exception ex)
            {
                throw new AdoUsuariosException("Error al obtener todos los usarios",ex);
            }
     

        }
        public static Usuario ObtenerUnUsuarioPorId(int id)
        {
            //List<Usuario> usuarios = UsuarioADO.ObtenerTodosLosUsuarios();

            //foreach (Usuario item in usuarios)
            //{
            //    if(item.Id == id)
            //    {
            //        return item;
            //    }
            //}

            //throw new Exception("Usuario inexistente");


            //return UsuarioADO.ObtenerTodosLosUsuarios().Find(u=> u.Id == id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USUARIO WHERE ID=@ID;";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("ID", id);
                connection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(reader["Id"]);
                    usuario.Nombre = reader["Nombre"].ToString();
                    usuario.Apellido = reader["Apellido"].ToString();
                    usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.Password = reader["Contraseña"].ToString();
                    usuario.Email = reader["Mail"].ToString();

                    return usuario;

                }
            }
            throw new Exception("Usuario inexistente");

        }

        public static void CrearUsuario(Usuario usuario)
        {

        }

        public static void ActualizarUsuarioPorId(int id,Usuario usuario)
        {

        }


        public static void BorrarUsuarioPorId(int id)
        {

        }
    }
}
