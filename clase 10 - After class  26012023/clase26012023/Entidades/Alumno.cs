using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        public Alumno(string nombre, string apellido) : base(nombre, apellido)
        {
        }

        public Alumno(string nombre, string apellido, DateTime fecha) : base(nombre, apellido, fecha)
        {
        }


        public override string Saludar()
        {
            return $"soy un alumno {base.Saludar()}";
        }
    }
}
