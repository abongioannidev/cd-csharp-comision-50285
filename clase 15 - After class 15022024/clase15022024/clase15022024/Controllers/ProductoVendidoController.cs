using clase15022024.Models;
using clase15022024.Service;
using Microsoft.AspNetCore.Mvc;

namespace clase15022024.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        [HttpGet("{idUsuario}")]
        public ActionResult<List<ProductoVendido>> ObtenerProductosVendidosPorIdUsuario(int idUsuario)
        {
            return ProductoVendidoService.ObtenerProductosVendidosPorIdUsuario(idUsuario);
        }
    }
}
