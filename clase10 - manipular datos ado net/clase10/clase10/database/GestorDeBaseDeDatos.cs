using clase10.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase10.database
{
    public class GestorDeBaseDeDatos
    {
        private string stringConnection;

        public GestorDeBaseDeDatos()
        {
            this.stringConnection = "Server=.;Database=coderhouse;Trusted_Connection=True;";
        }


        public Usuario ObtenerUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "SELECT * FROM Usuario where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader["id"]);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string nombreUsuario = reader.GetString(3);
                    string password = reader.GetString(4);
                    string email = reader.GetString(5);

                    Usuario usuario = new Usuario(id, nombre, apellido, nombreUsuario, password, email);

                    return usuario;
                }

                throw new Exception("Id no econtrado");


            }


        }

        public bool AgregarUsuario(Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) values (@nombre,@apellido,@nombreUsuario,@password,@email); select @@IDENTITY as ID";
                //string query = "INSERT INTO Usuario (Nombre,Apellido,NombreUsuario,Contraseña,Mail) values (@nombre,@apellido,@nombreUsuario,@password,@email); select @@IDENTITY as ID";

                SqlCommand command = new SqlCommand(query, connection);

              
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();

                return command.ExecuteNonQuery() > 0;


            }

        }

        public bool BorrarUnUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "DELETE FROM Usuario WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id",id );

                connection.Open();
                return command.ExecuteNonQuery() > 0;

            }

        }

        public bool ActualizarUsuarioPorId(int id, Usuario usuario)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {
                string query = "UPDATE Usuario SET Nombre = @nombre,Apellido = @apellido,NombreUsuario = @nombreUsuario,Contraseña= @password,Mail=@email WHERE id = @id ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombre", usuario.Nombre);
                command.Parameters.AddWithValue("apellido", usuario.Apellido);
                command.Parameters.AddWithValue("nombreUsuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("password", usuario.Password);
                command.Parameters.AddWithValue("email", usuario.Email);
                connection.Open();
                return command.ExecuteNonQuery() > 0;

            }

        }
        public bool ActualizarUsuarioPorId(int id, string apellido)
        {
            throw new  NotImplementedException("Metodo no implementado");
        }
    }
}
