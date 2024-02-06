using WebApiSistemaGestion.Service;
namespace FrmView
{
    public partial class FrmView : Form
    {

        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            this.dgvUsuarios.DataSource = UsuarioService.GetAllUser();
        }
    }
}
