using clase15022024.Models;
using System.Data.SqlClient;

namespace clase15022024.AdoNet
{
    public static class VentaADO
    {
        public static List<Venta> ObtenerTodosLasVentas()
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                List<Venta> ventas = new List<Venta>();
                string query = "SELECT * FROM Venta";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.Id = Convert.ToInt32(reader["Id"]);
                    venta.Comentario = reader["Comentarios"].ToString();
                    venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                    ventas.Add(venta);
                }
                return ventas;
            }
        }


        public static Venta? ObtenerVentaPorId(int id)
        {
            List<Venta> venta = VentaADO.ObtenerTodosLasVentas();
            return venta.Find(u => u.Id == id);
        }

        public static bool BorrarVentaPorId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM Venta WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool CrearVenta(Venta venta)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO Venta (Comentarios,IdUsuario) VALUES " +
                    "(@comentarios,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("comentarios", venta.Comentario);
                command.Parameters.AddWithValue("idUsuario", venta.IdUsuario);
                return command.ExecuteNonQuery() > 0;
            }
        }


        public static bool ActualizarVenta(Venta nuevaVenta)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE ProductoVendido SET Comentarios = @comentarios, IdUsuario = @idUsuario WHERE Id = @id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevaVenta.Id);
                command.Parameters.AddWithValue("comentarios", nuevaVenta.Comentario);
                command.Parameters.AddWithValue("idUsuario", nuevaVenta.IdUsuario);
                return command.ExecuteNonQuery() > 0;

            }

        }
    }

}
