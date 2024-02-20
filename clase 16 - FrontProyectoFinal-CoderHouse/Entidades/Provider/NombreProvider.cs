using Entidades.Models;
using System.Net.Http.Json;

namespace Entidades.Provider
{
    public class NombreProvider :AbstractProvider
    {

        private string recurso;
        public NombreProvider() : base()
        {
            this.recurso = "Nombre";
        }
        public string ObtenerNombreDelUsuario()
        {
            return base.GetString(this.recurso);
        }



    }
}
