using clase10.database;
using clase10.modelo;

namespace clase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDeBaseDeDatos db = new GestorDeBaseDeDatos();
            try
            {
                //Usuario usuarioObtenido = db.ObtenerUsuarioPorId(2);
                //Console.WriteLine(usuarioObtenido.ToString());

                //Usuario usuarioNuevo = new Usuario("Pedro", "Perez", "pperez", "12345p", "pp@mail.com");

                //if (db.AgregarUsuario(usuarioNuevo))
                //{
                //    Console.WriteLine("Agregue un usuario");
                //}


                //if (db.BorrarUnUsuarioPorId(6))
                //{
                //    Console.WriteLine("Borre un usuario");
                //}
                Usuario usuarioAActualizar = new Usuario("Leo", "Messi", "lmessi", "leoCampeon", "lmessi@mail.com");
                if (db.ActualizarUsuarioPorId(7, usuarioAActualizar))
                {

                    Console.WriteLine("Actualice un usuario");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
