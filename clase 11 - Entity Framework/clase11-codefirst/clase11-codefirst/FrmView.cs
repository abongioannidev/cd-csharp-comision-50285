using clase11_codefirst.database;
using clase11_codefirst.models;

namespace clase11_codefirst
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }


        public void btnCargarDatos_Click(object sender, EventArgs e)
        {
            using(DataBaseContext context = new DataBaseContext()) { 
            
                List<Producto> productos= context.Productos.ToList();

                this.dgvProductos.DataSource = productos;
            }
        }
    }
}
