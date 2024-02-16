using clase15022024.AdoNet;
using clase15022024.Models;

namespace clase15022024.Service
{
    public static class ProductoVendidoService
    {

        public static List<ProductoVendido> ObtenerProductosVendidosPorIdUsuario(int idUsuario)
        {
            List<Producto> productos = ProductoADO.ObtenerTodosLosProductos();


            List<Producto> productosFiltrados = productos.Where(p=>p.IdUsuario == idUsuario).ToList();


            List<ProductoVendido> resultadoFinal = new List<ProductoVendido>();
            List<ProductoVendido> productosVendidos = ProductoVendidoADO.ObtenerTodosLosProductosVendidos();
            foreach (Producto p in productosFiltrados)
            {
                int id = p.Id;
                ProductoVendido? pVendido = productosVendidos.Find(p => p.IdProducto == id);
                
                if(pVendido is not null)
                {
                    resultadoFinal.Add(pVendido);   
                }
            }


            return resultadoFinal;

        }
    }
}
