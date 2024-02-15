using Clase15_Endpoints_Modificacion.database;
using Clase15_Endpoints_Modificacion.models;
using Clase15_Endpoints_Modificacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clase15_Endpoints_Modificacion.Controllers
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
