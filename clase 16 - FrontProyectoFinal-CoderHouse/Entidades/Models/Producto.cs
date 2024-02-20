using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private double costo;
        private double precioVenta;
        private int stock;
        private int idUsuario;

        public int Id { get => this.id; set => this.id = value; }
        public string Descripciones { get => this.descripcion; set => this.descripcion = value; }
        public double Costo { get => this.costo; set => this.costo = value; }
        public double PrecioVenta { get => this.precioVenta; set => this.precioVenta = value; }
        public int IdUsuario { get => this.idUsuario; set => this.idUsuario = value; }
        public int Stock { get => this.stock; set => this.stock = value; }


        public override string ToString()
        {
            return $"ID: {(this.id == 0 ? "n/a" : this.id )}\nDescripcion: {this.descripcion}";
        }
    }
}
