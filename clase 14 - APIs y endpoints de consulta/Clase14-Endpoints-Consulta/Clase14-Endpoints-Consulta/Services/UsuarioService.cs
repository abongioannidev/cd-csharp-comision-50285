using Clase14_Endpoints_Consulta.database;
using Clase14_Endpoints_Consulta.models;

namespace Clase14_Endpoints_Consulta.Services
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
