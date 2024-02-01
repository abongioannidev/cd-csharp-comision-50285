using Clase12_Abm_Entity.models;
using Clase12_Abm_Entity.service;

namespace Clase12_Abm_Entity
{
    public partial class FrmView : Form
    {
        Usuario usuarioSeleccionado;
        public FrmView()
        {
            InitializeComponent();
        }

        public void btnListar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();

            this.ActualizarDgv(usuarios);
        }


        private void ActualizarDgv(object objeto)
        {
            this.dgvDatos.DataSource = null;
            this.dgvDatos.DataSource = objeto;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Usuario usuarioBuscado = UsuarioService.ObtenerUsuarioPorId(id);
                List<Usuario> lista = new List<Usuario>();
                lista.Add(usuarioBuscado);


                this.ActualizarDgv(lista);

            }
            else
            {
                MessageBox.Show("Complete Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }



        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AMBUsuario frmAlta = new AMBUsuario();
            frmAlta.ShowDialog();
            this.Hide();
            Usuario usuario = frmAlta.UsuarioCreado;
            this.Show();
            if (UsuarioService.AgregarUsuario(usuario))
            {
                MessageBox.Show("Agregue un usuario", "Alta");
            }


        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string idString = this.txtId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = ProductoService.EliminarProductoPorId(id);

                if (resultado)
                {
                    MessageBox.Show("Borre", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Complete Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            AMBUsuario frm = new AMBUsuario(this.usuarioSeleccionado);
            frm.ShowDialog();

            Usuario usuarioModificado = frm.UsuarioCreado;

            if(UsuarioService.ActualizarUsuarioPorId(usuarioModificado,this.usuarioSeleccionado.Id))
            {
                MessageBox.Show("Actualice", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dgvDatos.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;

                this.usuarioSeleccionado = dato as Usuario;
            }
        }
    }
}
