using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Venta
    {
        private int id;
        private string comentario;
        private int idUsuario;

        public int Id { get => this.id; set => this.id = value; }
        public string Comentario { get => this.comentario; set => this.comentario = value; }
        public int IdUsuario { get => this.idUsuario; set => this.idUsuario = value; }
    }
}
