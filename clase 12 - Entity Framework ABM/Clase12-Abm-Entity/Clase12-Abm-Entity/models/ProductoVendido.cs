using System;
using System.Collections.Generic;

namespace Clase12_Abm_Entity.models
{
    public partial class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        public virtual Producto IdProductoNavigation { get; set; } = null!;
        public virtual Ventum IdVentaNavigation { get; set; } = null!;
    }
}
