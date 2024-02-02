namespace clase01022023
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private double costo;
        private double precioVenta;
        private int idUsuario;

        public int Id { get => this.id; set => this.id = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
        public double Costo { get => this.costo; set => this.costo = value; }
        public double PrecioVenta { get => this.precioVenta; set => this.precioVenta = value; }
        public int IdUsuario { get => this.idUsuario; set => this.idUsuario = value; }
    }
}