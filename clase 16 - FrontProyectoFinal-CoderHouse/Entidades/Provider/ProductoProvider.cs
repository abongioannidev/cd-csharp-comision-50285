using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Provider
{
    public class ProductoProvider : AbstractProvider
    {
        private string recurso;
        public ProductoProvider() : base()
        {
            this.recurso = "Producto";
        }

        public string EliminarProducto(Producto producto)
        {
            try
            {
                ApiResponse respuesta = base.Delete($"{this.recurso}/{producto.Id}");
                return respuesta.Mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el producto, notifique a su administrador", ex);
            }
        }

        public List<Producto> ObtenerTodosLosProductosDelUsuario(int idUsuario)
        {
            try
            {

                return base.GetJson<List<Producto>>($"{this.recurso}/{idUsuario}");
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo obtener todos los productos del usuario, notifique a su administrador", ex);
            }
        }

        public string ActualizarProducto(Producto producto)
        {
            try
            {
                ApiResponse response = base.PutJson<Producto>(this.recurso, producto);
                return response.Mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el producto, notifique a su administrador", ex);
            }
        }

        public string CrearProducto(Producto nuevoProducto)
        {
            try
            {
                ApiResponse response = base.PostJson<Producto>(this.recurso, nuevoProducto);
                return response.Mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el producto, notifique a su administrador", ex);
            }
        }
    }
}
