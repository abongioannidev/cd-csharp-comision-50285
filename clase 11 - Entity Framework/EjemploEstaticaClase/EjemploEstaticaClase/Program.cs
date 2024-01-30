namespace EjemploEstaticaClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro("Firulais");
            Perro p3 = new Perro("Bobi");
            Console.WriteLine("Hello, World!");
        }
    }


    public static class AdoPersonas
    {


        private static string conecctionString;

        static AdoPersonas()
        {
            AdoPersonas.conecctionString = "";
        }

        public static string ObtenerUnaPersonaPorId()
        {
            return conecctionString;
        }
    }


    public class Perro
    {
        private static int cantiColas;
        private string nombre;
        static Perro()
        {
            Perro.cantiColas = 1;
        }

        public Perro(string nombre)
        {
            this.nombre = nombre;   
        }
    }
}
