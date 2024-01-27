namespace Entidades
{
    public class Persona
    {
        private string nombre;
        protected string apellido;
        private DateTime fechaNac;

        //public Persona() { }
        public Persona(string nombre, string apellido, DateTime fechaNac) 
            :this(nombre, apellido)
        {
            this.fechaNac = fechaNac;
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nombre Invalido");
                }
                this.nombre = value;
            }
        }

        public int Edad
        {
            get
            {

                DateTime hoy = DateTime.Now;
                int edad = hoy.Year - this.fechaNac.Year;
                return edad;
            }
        }

        public virtual string Saludar()
        {
            return $"Y mi apellido es {this.nombre}";
        }
    }
}
