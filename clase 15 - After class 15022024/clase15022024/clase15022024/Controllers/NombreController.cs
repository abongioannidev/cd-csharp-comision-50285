using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NombreController : Controller
    {
        [HttpGet]
        public ActionResult<string> ObtenerNombreDelAlumno()
        {
            return "Alejandro Bongioanni";
        }
    }
}
