using Entidades.Models;
using Entidades.Provider;

namespace FrontProyectoFinal_CoderHouse
{
    public partial class FrmPrincipal : Form
    {
        NombreProvider nombreProvider;
        UsuarioProvider usuarioProvider;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.nombreProvider = new NombreProvider();
            this.usuarioProvider = new UsuarioProvider();
        }

        public void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string nombre = this.nombreProvider.ObtenerNombreDelUsuario();

            this.Text = $"Ecommerce de {nombre}";
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtUsuario.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Debe completar los campos usuario y password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Focus();
            }
            else
            {
                try
                {
                    Usuario usuario = this.usuarioProvider.ObtenerUsuarioPorUsuarioYPassword(this.txtUsuario.Text, this.txtPassword.Text);

                    FrmGestion frmGestion = new FrmGestion(usuario);
                    this.Hide();
                    frmGestion.ShowDialog();
                    this.txtUsuario.Text = string.Empty;
                    this.txtPassword.Text = string.Empty;
                    this.Show();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
