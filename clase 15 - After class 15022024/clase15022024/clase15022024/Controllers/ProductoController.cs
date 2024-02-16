using clase15022024.Models;
using clase15022024.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace clase15022024.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {

        [HttpGet]
        public ActionResult<List<Producto>> ObtenerTodosLosProductos()
        {
            return ProductoService.ObtenerTodosLosProductos();
        }


        [HttpPost]
        public IActionResult AgregarUnNuevoProducto([FromBody] Producto productoNuevo)
        {
            try
            {

                ProductoService.AgregarProducto(productoNuevo);
                return base.Created(nameof(AgregarUnNuevoProducto), new { mensaje = "Producto creado", status = HttpStatusCode.Created, productoNuevo });
            }
             catch (Exception ex)
            {
                return base.Conflict(new { mensaje = "Error al agregar un producto", status = HttpStatusCode.Conflict });
            }


        }
    }
}
