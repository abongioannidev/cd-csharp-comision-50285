

using WebApiSistemaGestion.database;
using WebApiSistemaGestion.models;

namespace WebApiSistemaGestion.Service
{
    public static class UsuarioService
    {
        public static List<Usuario> GetAllUser()
        {
            using(CoderContext context = new CoderContext())
            {
                return  context.Usuarios.ToList();
            }
        }

    }
}
