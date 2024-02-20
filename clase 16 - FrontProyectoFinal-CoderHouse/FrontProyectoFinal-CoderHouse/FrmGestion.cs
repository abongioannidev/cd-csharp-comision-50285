using Entidades.Models;
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
    public partial class FrmGestion : Form
    {
        Usuario usuario;
        public FrmGestion(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.mstText.Text = $"Bienvenido: {usuario}";

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea cerrar la sesion?", "Sesion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGestionUsuario frmGestionUsuario = FrmGestionUsuario.GetInstancia(this.usuario);
            frmGestionUsuario.MdiParent = this;
            frmGestionUsuario.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProducto frmGestionProducto = FrmGestionProducto.GetInstancia(this.usuario);
            frmGestionProducto.MdiParent = this;
            frmGestionProducto.Show();
        }
    }
}
