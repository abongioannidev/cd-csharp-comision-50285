using Entidades;
using System.Collections;
namespace clase26012023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona alejandro= new Persona("Alejandro","Bongioanni", new DateTime(2020,05,01));


            //Console.WriteLine(alejandro.Nombre);
            //Console.WriteLine(alejandro.Edad);

            //alejandro.Saludar();

            Alumno alumnoPepe = new Alumno("Pepe", "Diaz", new DateTime(2020, 05, 01));

            Persona profesorLuis = new Profesor("Luis", "Perez", new DateTime(2020, 05, 01));

            List<Persona> personas = new List<Persona>();

            

            Console.WriteLine(alumnoPepe.Saludar());


            //personas.Add(alumnoPepe);
            //personas.Add(profesorLuis);

            //foreach (var item in personas)
            //{
            //    Console.WriteLine(item.Saludar());
            //}



            



            personas.Clear();





            Console.WriteLine("Hello, World!");
        }
    }



}
