using Clase15_Endpoints_Modificacion.DTOs;
using Clase15_Endpoints_Modificacion.models;
using Clase15_Endpoints_Modificacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clase15_Endpoints_Modificacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private ProductoService productoService;
        public ProductoController(ProductoService productoService)
        {
            this.productoService = productoService;
        }
        [HttpGet]
        public IActionResult Index([FromQuery] string? nombre, [FromQuery] string? edad)
        {
            return base.Ok(new { mensaje = "Hola desde producto", estado = 200, parametros = new List<string> { nombre, edad } });

        }
        [HttpPost]
        public IActionResult AgregarUnNuevoProducto([FromBody] ProductoDTO producto)
        {

            if (this.productoService.AgregarUnProducto(producto))
            {

                return base.Ok(new { mensaje = "Prodcuto agregado", producto });
            }
            else
            {
                return base.Conflict(new { mensaje = "No se agrego un producto" });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult BorrarProducto(int id)
        {
            if(id > 0)
            {
                if(this.productoService.BorrarProductoPorId(id))
                {
                    return base.Ok(new { mensaje = "Producto borrado", status=200 });
                }
  
                    return base.Conflict(new { mensaje = "No se pudo borrar el producto" });
                
            }
            return base.BadRequest(new { status = 400, mensaje = "El id no puede ser negativo" });
        }

        [HttpPut("{id}")]
        public IActionResult ActualizarProductoPorId(int id, ProductoDTO productoDTO)
        {
            if (id > 0)
            {
                if(this.productoService.ActualizarProductoPorId(id, productoDTO)) 
                {
                    return base.Ok(new { mensaje = "Producto Actualizado", status = 200, productoDTO });
                }
                return base.Conflict(new { mensaje = "No se pudo Actualizar el producto" });

            }
            return base.BadRequest(new { status = 400, mensaje = "El id no puede ser negativo" });
        }
    }
    
}
