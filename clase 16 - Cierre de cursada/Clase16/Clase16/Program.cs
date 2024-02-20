using System.Globalization;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Clase16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuarioNuevo = new Usuario();
            usuarioNuevo.NombreUsuario = "pepe";
            usuarioNuevo.Nombre = "Luis";
            usuarioNuevo.Apellido = "Perez";
            usuarioNuevo.Mail = "mail@mail.com";
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:5001/api/Usuario");


            string dataSerailziada = JsonSerializer.Serialize<Usuario>(usuarioNuevo);
            request.Content = new StringContent(dataSerailziada,Encoding.UTF8,"application/json");
      

           
   


        }
    }
}
