using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Provider
{
    public class UsuarioProvider : AbstractProvider
    {
        private string recurso;
        public UsuarioProvider() : base()
        {
            this.recurso = "Usuario";
        }

        public Usuario ObtenerUsuarioPorUsuarioYPassword(string usuario, string password)
        {
            try
            {
                return base.GetJson<Usuario>($"{this.recurso}/{usuario}/{password}");

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo authenticar el usuario", ex);
            }
        }

        public Usuario ObtenerUsuarioPorNombreDeUsuario(string usuario)
        {
            return base.GetJson<Usuario>($"{this.recurso}/{usuario}");
        }


        public string ActualizarUsuario(Usuario usuario)
        {
            try
            {
                ApiResponse response = base.PutJson<Usuario>(this.recurso, usuario);
                return response.Mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el usuario, notifique a su administrador", ex);
            }
        }
    }
}
