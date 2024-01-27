using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjemploGenrica<T>
    {
        private T algo;

        public EjemploGenrica(T algo)
        {
            this.algo = algo;
        }

        public string MostrarTipo()
        {
            return typeof(T).Name;
        }
    }
}
