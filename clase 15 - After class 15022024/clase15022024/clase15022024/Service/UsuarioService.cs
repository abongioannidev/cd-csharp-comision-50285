using clase15022024.AdoNet;
using clase15022024.Exceptions;
using clase15022024.Models;

namespace clase15022024.Service
{
    public static class UsuarioService
    {

        public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            return UsuarioADO.ObtenerTodosLosUsuarios();
        }

        public static Usuario ObtenerUsuarioPorNombreDeUsuario(string nombreDeUsuario)
        {
            List<Usuario> usuarios = UsuarioADO.ObtenerTodosLosUsuarios();

            Usuario? usuarioBuscado = usuarios.Find(u=> u.NombreUsuario == nombreDeUsuario);
            if (usuarioBuscado is null)
            {
                throw new Exception("Usuario no encontrado");
            }

            return usuarioBuscado;
        }

        public static Usuario? ObtenerUsuarioPorUsuarioYPassword(string usuario,string password)
        {
            List<Usuario> usuarios = UsuarioADO.ObtenerTodosLosUsuarios();



            Usuario? usuarioBuscado = usuarios.Find(u=> u.NombreUsuario == usuario && u.Password == password);


            if(usuarioBuscado is null)
            {
                throw new UsuarioNoEncontradoException("Usuario no encontrado");
            }
            return usuarioBuscado;
        } 
        



  
    }
}
