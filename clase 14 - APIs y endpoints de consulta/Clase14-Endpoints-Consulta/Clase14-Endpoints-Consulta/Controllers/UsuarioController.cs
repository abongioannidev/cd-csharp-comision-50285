using Clase14_Endpoints_Consulta.database;
using Clase14_Endpoints_Consulta.models;
using Clase14_Endpoints_Consulta.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clase14_Endpoints_Consulta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService) 
        { 
            this.usuarioService = usuarioService;
        }
        [HttpGet]
        public List<Usuario> ObtenerListadoDeUsuarios()
        {
            return this.usuarioService.ObtenerTodosLosUsuarios();
        }
    }
}
