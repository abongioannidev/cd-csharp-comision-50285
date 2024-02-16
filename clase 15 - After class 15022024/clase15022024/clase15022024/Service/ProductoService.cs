using clase15022024.AdoNet;
using clase15022024.Models;

namespace clase15022024.Service
{
    public static class ProductoService
    {

        public static List<Producto> ObtenerTodosLosProductos()
        {
            return ProductoADO.ObtenerTodosLosProductos();
        }

        public static void AgregarProducto(Producto producto)
        {
            if(!ProductoADO.CrearProducto(producto))
            {
                throw new Exception("No se pudo crear el producto");
            }
        }
    }
}
