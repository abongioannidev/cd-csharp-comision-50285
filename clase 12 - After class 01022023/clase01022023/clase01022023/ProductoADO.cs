using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase01022023
{
    public static class ProductoADO
    {
        private static string connectionString;


        static ProductoADO()
        {
            ProductoADO.connectionString = "Server=.; Database=coderhousetest; Trusted_Connection=True;";
        }

        //public static List<Producto> ObtenerTodosLosUsuarios()
        //{

        //}
        //public static Producto ObtenerUnUsuarioPorId()
        //{

        //}

        public static void CrearUsuario(Producto producto)
        {

        }

        public static void ActualizarUsuarioPorId(int id, Producto producto)
        {

        }


        public static void BorrarUsuarioPorId(int id)
        {

        }
    }
}
