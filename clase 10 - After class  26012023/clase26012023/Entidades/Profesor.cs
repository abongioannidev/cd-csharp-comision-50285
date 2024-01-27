using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        public Profesor(string nombre, string apellido, DateTime fechaNac) : base(nombre, apellido, fechaNac)
        {
        }

        public override string Saludar()
        {
            return $"soy un Profesor  y mi apellido es {this.apellido}";
        }
    }
}
