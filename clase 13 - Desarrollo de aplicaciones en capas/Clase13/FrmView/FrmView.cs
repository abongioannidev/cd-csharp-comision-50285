using Entidades.service;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
