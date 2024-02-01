using Clase12_Abm_Entity.database;
using Clase12_Abm_Entity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_Abm_Entity.service
{
    public static class UsuarioService
    {
        public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            using(CoderContext context = new CoderContext()) {

                List<Usuario> usuarios = context.Usuarios.ToList();

                return usuarios;

            }
        }

        public static Usuario ObtenerUsuarioPorId(int id)
        {
            using (CoderContext context = new CoderContext())
            {
                
                Usuario? usuarioBuscado = context.Usuarios.Where(u=> u.Id== id).FirstOrDefault();
                return usuarioBuscado;
            }
        }

        public static Usuario ObtenerUsuarioPorId2(int id)
        {
            List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();

            foreach (Usuario item in usuarios)
            {
                if(item.Id== id)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool AgregarUsuario(Usuario usuario)
        {
            using (CoderContext context = new CoderContext())
            {
                context.Usuarios.Add(usuario);

                context.SaveChanges();
                return true;
            }


        }

        public static bool ActualizarUsuarioPorId(Usuario usuario, int id)
        {
            using (CoderContext context = new CoderContext())
            {
                Usuario? usuarioBuscado = context.Usuarios.Where(u => u.Id == id).FirstOrDefault();


                usuarioBuscado.Nombre = usuario.Nombre;
                usuarioBuscado.NombreUsuario = usuario.NombreUsuario;
                usuarioBuscado.Apellido = usuario.Apellido;
                usuarioBuscado.Mail = usuario.Mail;

                context.Usuarios.Update(usuarioBuscado);

                context.SaveChanges();

                return true;
            }
        }
    }
}
