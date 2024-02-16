using clase15022024.AdoNet;
using clase15022024.Exceptions;
using clase15022024.Models;
using clase15022024.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace clase15022024.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet]
        public ActionResult<List<Usuario>> GetUsuarios()
        {
            return UsuarioService.ObtenerTodosLosUsuarios();
        }

        [HttpGet("{usuario}/{password}")]

        public ActionResult<Usuario> ObtenerUsuarioPorNombreYPassword(string usuario, string password)
        {
            try
            {

                return UsuarioService.ObtenerUsuarioPorUsuarioYPassword(usuario, password);
            }
            catch (DataBaseException ex)
            {
                return base.Conflict(new { error = ex.Message, status = HttpStatusCode.InternalServerError });
            }
            catch(UsuarioNoEncontradoException ex)
            {
                return base.Conflict(new { error = ex.Message, status = HttpStatusCode.NoContent });
            }
            catch (Exception ex)
            {
                return base.Conflict(new { error = ex.Message, status = HttpStatusCode.Conflict });
            }


        }

    }
}
