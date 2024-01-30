using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11_codefirst.models
{
    public class Producto
    {
        public int Id { get; set; }
        public string ? Descripcion { get; set; }
        public int Stock {  get; set; }
        public double Precio {  get; set; }
    }
}
