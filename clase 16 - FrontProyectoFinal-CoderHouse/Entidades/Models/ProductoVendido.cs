using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class ProductoVendido
    {
        private int id;
        private int idProducto;
        private int stock;
        private int idVenta;

        public int Id { get => this.id; set => this.id = value; }
        public int IdProducto { get => this.idProducto; set => this.idProducto = value; }
        public int Stock { get => this.stock; set => this.stock = value; }
        public int IdVenta { get => this.idVenta; set => this.idVenta = value; }
    }
}
