using Clase15_Endpoints_Modificacion.database;
using Clase15_Endpoints_Modificacion.models;

namespace Clase15_Endpoints_Modificacion.Services
{
    public class UsuarioService
    {
        private CoderContext context;
        public UsuarioService(CoderContext coderContext)
        { 
            this.context = coderContext;
        
        }


        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return this.context.Usuarios.ToList();
        }
    }
}
