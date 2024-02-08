using Microsoft.AspNetCore.Mvc;

namespace Clase14_Endpoints_Consulta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NombreController : Controller
    {
        List<string> list;
        public NombreController() { 
            this.list = new List<string>() { "Alejandro", "Pepe", "Gonzalo" };
        }
        [HttpGet]
        public string ObtenerNombre()
        {
            return "Alejandro Bongioanni";
        }

        [HttpGet("listado")]
        public List<string> ObtenerListadoDeNombres()
        {
            return this.list;    
        }

        [HttpGet("listado/{id}")]
        public ActionResult<string> ObtenerNombrePorId(int id)
        {
            if(id< 0 || id >= list.Count)
            {
                return BadRequest(new {mensaje = $"El numero no puede ser negativo o mayor que {this.list.Count}",status = 400});
            }
            return this.list[id];
        }
    }
}
