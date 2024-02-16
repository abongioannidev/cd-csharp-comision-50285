using clase15022024.Models;
using System.Data.SqlClient;

namespace clase15022024.AdoNet
{
    public static class ProductoVendidoADO
    {
        public static List<ProductoVendido> ObtenerTodosLosProductosVendidos()
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
                string query = "SELECT * FROM ProductoVendido";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductoVendido productoVendido = new ProductoVendido();
                    productoVendido.Id = Convert.ToInt32(reader["Id"]);
                    productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                    productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                    productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);

                    productosVendidos.Add(productoVendido);
                }
                return productosVendidos;
            }
        }


        public static ProductoVendido? ObtenerProductoVendidoPorId(int id)
        {
            List<ProductoVendido> productoVendido = ProductoVendidoADO.ObtenerTodosLosProductosVendidos();
            return productoVendido.Find(u => u.Id == id);
        }

        public static bool BorrarProductoVendidoPorId(int id)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "DELETE FROM ProductoVendido WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);
                return command.ExecuteNonQuery() > 0;

            }
        }

        public static bool CrearProductoVendido(ProductoVendido productoVendido)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "INSERT INTO ProductoVendido (Stock,IdProducto,IdVenta) VALUES " +
                    "(@stock,@idProducto,@idVenta)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("stock", productoVendido.Stock);
                command.Parameters.AddWithValue("idProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue("idVenta", productoVendido.IdVenta);
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            using (SqlConnection connection = ConnectionADO.GetConnection())
            {
                string query = "UPDATE ProductoVendido SET Stock = @stock, IdProducto = @idProducto, IdVenta = @idVenta WHERE Id = @id)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", nuevoProductoVendido.Id);
                command.Parameters.AddWithValue("stock", nuevoProductoVendido.Stock);
                command.Parameters.AddWithValue("idProducto", nuevoProductoVendido.IdProducto);
                command.Parameters.AddWithValue("idVenta", nuevoProductoVendido.IdVenta);
                return command.ExecuteNonQuery() > 0;

            }

        }
    }
}
