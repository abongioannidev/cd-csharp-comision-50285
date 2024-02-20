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
    public partial class FrmGestionProducto : Form
    {
        enum EAccion { Creacion, Modificacion, Eliminacion }
        EAccion eAccion;
        ProductoProvider productoProvider;
        Usuario usuario;
        Producto? productoSeleccionado;
        static FrmGestionProducto instancia;
        private FrmGestionProducto(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.productoProvider = new ProductoProvider();
            this.ActualizaListadoProductos();
            this.EstableceVistaInicial();
        }
        public static FrmGestionProducto GetInstancia(Usuario usuario)
        {
            if(FrmGestionProducto.instancia is null || FrmGestionProducto.instancia.IsDisposed)
            {
                FrmGestionProducto.instancia = new FrmGestionProducto(usuario);
            }

            return FrmGestionProducto.instancia;
        }
        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.EstableceVistaInicial();
        }

        private void btnAbrirPanel_Click(object sender, EventArgs e)
        {
            this.EstableceVistaDeGestion();
        }

        private void EstableceVistaInicial()
        {
            this.pnlMenu.Hide();
            this.dgvProductos.Hide();
            this.grpProductoSeleccionado.Hide();
            this.btnAbrirPanel.Show();
        }

        private void EstableceVistaDeGestion()
        {
            this.pnlMenu.Show();
            this.dgvProductos.Show();
            this.grpProductoSeleccionado.Show();
            this.btnAbrirPanel.Hide();
        }

        private void ActualizaListadoProductos()
        {
            try
            {
                int idUsuario = this.usuario.Id;
                List<Producto> productos = this.productoProvider.ObtenerTodosLosProductosDelUsuario(idUsuario);
                this.dgvProductos.DataSource = null;
                this.dgvProductos.DataSource = productos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvProductos.SelectedRows.Count > 0)
            {


                this.productoSeleccionado = this.dgvProductos.SelectedRows[0].DataBoundItem as Producto;
                if (productoSeleccionado is not null)
                {
                    this.BloquearControles();
                    this.btnConfirmar.Hide();
                    this.grpProductoSeleccionado.Text = "Producto seleccionado:";
                    this.txtDescripcion.Text = this.productoSeleccionado.Descripciones;
                    this.nupCosto.Value = (decimal)this.productoSeleccionado.Costo;
                    this.nupPrecioVenta.Value = (decimal)this.productoSeleccionado.PrecioVenta;
                    this.nupStock.Value = this.productoSeleccionado.Stock;
                }
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (this.productoSeleccionado is not null)
            {
                this.eAccion = EAccion.Modificacion;
                this.DesbloquearControles();
                this.btnConfirmar.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (this.eAccion == EAccion.Modificacion)
            {
                if (this.productoSeleccionado is not null)
                {
                    this.ModificarProducto();
                }

            }
            else
            {
                this.CrearProducto();
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            if (this.productoSeleccionado is not null)
            {
                this.EliminarProducto();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            this.eAccion = EAccion.Creacion;
            this.productoSeleccionado = null;
            this.RestablecerControles();
            this.DesbloquearControles();
            this.btnConfirmar.Show();
            this.grpProductoSeleccionado.Text = "Crear Producto:";
        }

        private void DesbloquearControles()
        {
            this.txtDescripcion.ReadOnly = false;
            this.nupCosto.ReadOnly = false;
            this.nupPrecioVenta.ReadOnly = false;
            this.nupStock.ReadOnly = false;

        }
        private void BloquearControles()
        {
            this.txtDescripcion.ReadOnly = true;
            this.nupCosto.ReadOnly = true;
            this.nupPrecioVenta.ReadOnly = true;
            this.nupStock.ReadOnly = true;
        }

        private void RestablecerControles()
        {
            this.txtDescripcion.Text = string.Empty;
            this.nupCosto.Value = 0;
            this.nupPrecioVenta.Value = 0;
            this.nupStock.Value = 0;
        }

        private void ModificarProducto()
        {
            this.EjecutarAccion(this.productoProvider.ActualizarProducto, this.productoSeleccionado!, EAccion.Modificacion);
            this.BloquearControles();
            this.btnConfirmar.Hide();
        }
        private void EliminarProducto()
        {
            this.EjecutarAccion(this.productoProvider.EliminarProducto, this.productoSeleccionado!, EAccion.Eliminacion);
        }

        private void CrearProducto()
        {

            Producto nuevoProducto = new Producto();
            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                MessageBox.Show("Debe completar el campo requerido 'Descripcion'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDescripcion.Focus();
            }
            else
            {
                nuevoProducto.Descripciones = this.txtDescripcion.Text;
                nuevoProducto.Costo = (double)this.nupCosto.Value;
                nuevoProducto.PrecioVenta = (double)this.nupPrecioVenta.Value;
                nuevoProducto.Stock = (int)this.nupStock.Value;
                nuevoProducto.IdUsuario = this.usuario.Id;
                this.EjecutarAccion(this.productoProvider.CrearProducto, nuevoProducto, EAccion.Creacion);
                this.BloquearControles();
                this.btnConfirmar.Hide();

            }
        }

        private void EjecutarAccion(Func<Producto, string> accion, Producto producto, EAccion descripcion)
        {
            DialogResult resultado = MessageBox.Show($"Confirma la {descripcion} del producto {producto}", descripcion.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {

                    string respuesta = accion(producto);
                    MessageBox.Show(respuesta, descripcion.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizaListadoProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
