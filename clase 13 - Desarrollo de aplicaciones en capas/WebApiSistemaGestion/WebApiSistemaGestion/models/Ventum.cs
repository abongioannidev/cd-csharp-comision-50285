namespace WebApiSistemaGestion.models
{
    public partial class Ventum
    {
        public Ventum()
        {
            ProductoVendidos = new HashSet<ProductoVendido>();
        }

        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
        public virtual ICollection<ProductoVendido> ProductoVendidos { get; set; }
    }
}
