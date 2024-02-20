using Entidades.Models;
using Entidades.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontProyectoFinal_CoderHouse
{
    public partial class FrmGestionUsuario : Form
    {
        private Usuario usuario;
        private UsuarioProvider usuarioProvider;
        private static FrmGestionUsuario instancia;
        private FrmGestionUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.usuarioProvider = new UsuarioProvider();
            this.CargarInformacion();
        }

        public static FrmGestionUsuario GetInstancia(Usuario usuario)
        {
           
            if(FrmGestionUsuario.instancia is null || FrmGestionUsuario.instancia.IsDisposed)
            {
                FrmGestionUsuario.instancia = new FrmGestionUsuario(usuario);
            }

            return FrmGestionUsuario.instancia;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma la actualizacion del usuario?", "Actualizacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.usuario.Apellido = this.txtApellido.Text;
                this.usuario.Nombre = this.txtNombre.Text;
                this.usuario.Contraseña = this.txtPassword.Text;
                this.usuario.Mail = this.txtEmail.Text;
                this.usuario.NombreUsuario = this.txtNombreUsuario.Text;
                try
                {
                    string respuesta = this.usuarioProvider.ActualizarUsuario(this.usuario);
                    MessageBox.Show(respuesta, "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        private void CargarInformacion()
        {
            this.txtId.Text = this.usuario.Id.ToString();
            this.txtEmail.Text = this.usuario.Mail;
            this.txtNombre.Text = this.usuario.Nombre;
            this.txtApellido.Text = this.usuario.Apellido;
            this.txtNombreUsuario.Text = this.usuario.NombreUsuario;
            this.txtPassword.Text = this.usuario.Contraseña;
        }
    }
}
