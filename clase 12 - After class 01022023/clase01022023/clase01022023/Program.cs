namespace clase01022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Usuario> listado = UsuarioADO.ObtenerTodosLosUsuarios();


            Console.WriteLine("Termine");

        }
    }
}
