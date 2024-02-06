using Entidades.database;
using Entidades.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.service
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
