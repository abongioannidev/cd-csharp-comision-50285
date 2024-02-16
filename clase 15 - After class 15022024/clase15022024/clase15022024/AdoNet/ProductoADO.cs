using clase15022024.Models;
using System.Data.SqlClient;

namespace clase15022024.AdoNet
{
    public static class ProductoADO
    {
        public static List<Producto> ObtenerTodosLosProductos()
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                List<Producto> productos = new List<Producto>();
                string query = "SELECT * FROM Producto";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(reader["Id"]);
                    producto.PrecioVenta = Convert.ToUInt32(reader["PrecioVenta"]);
                    producto.Descripcion = reader["Descripciones"].ToString();
                    producto.Costo = Convert.ToUInt32(reader["Costo"]);
                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                    productos.Add(producto);
                }
                return productos;
            }
        }

        public static Producto? ObtenerProductoPorId(int id)
        {
            List<Producto> producto = ProductoADO.ObtenerTodosLosProductos();
            return producto.Find(u => u.Id == id);
        }

        public static bool BorrarProductoPorId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM Producto WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool CrearProducto(Producto producto)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO Producto (Descripciones,Costo,PrecioVenta,Stock,IdUsuario) VALUES " +
                    "(@descripciones,@costo,@precioVenta,@stock,@idUsuario)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("descripciones", producto.Descripcion);
                command.Parameters.AddWithValue("costo", producto.Costo);
                command.Parameters.AddWithValue("precioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("stock", producto.Stock);
                command.Parameters.AddWithValue("idUsuario", producto.IdUsuario);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarProducto(Producto nuevoProducto)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE Producto SET Descripciones = @descripciones,Costo = @costo, PrecioVenta = @precioVenta,Stock = @stock,IdUsuario = @idUsuario WHERE Id = @id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevoProducto.Id);
                command.Parameters.AddWithValue("descripciones", nuevoProducto.Descripcion);
                command.Parameters.AddWithValue("precioVenta", nuevoProducto.PrecioVenta);
                command.Parameters.AddWithValue("stock", nuevoProducto.Stock);
                command.Parameters.AddWithValue("idUsuario", nuevoProducto.IdUsuario);
                return command.ExecuteNonQuery() > 0;

            }

        }
    }
}
