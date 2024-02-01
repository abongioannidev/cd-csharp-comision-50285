using Clase12_Abm_Entity.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase12_Abm_Entity
{
    public partial class AMBUsuario : Form
    {
        public AMBUsuario()
        {
            InitializeComponent();
        }

        public AMBUsuario(Usuario usuario):this()
        {
            this.txtNombre.Text = usuario.Nombre;
            this.txtApellido.Text = usuario.Apellido;
            this.txtEmail.Text = usuario.Mail;
            this.txtUsuario.Text = usuario.NombreUsuario;
            this.txtPassword.Text = usuario.Contraseña;
        }
        public Usuario UsuarioCreado { get; private set; }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() { Apellido = this.txtApellido.Text, Nombre = this.txtNombre.Text,Contraseña = this.txtPassword.Text, NombreUsuario = txtUsuario.Text, Mail = this.txtEmail.Text };

            this.UsuarioCreado = usuario;

            this.Close();

        }
    }
}
