namespace FrontProyectoFinal_CoderHouse
{
    partial class FrmGestionProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnCrearProducto = new Button();
            btnCerrarPanel = new Button();
            btnAbrirPanel = new Button();
            dgvProductos = new DataGridView();
            grpProductoSeleccionado = new GroupBox();
            btnConfirmar = new Button();
            nupPrecioVenta = new NumericUpDown();
            nupCosto = new NumericUpDown();
            nupStock = new NumericUpDown();
            label4 = new Label();
            lblCosto = new Label();
            lblStock = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grpProductoSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.PeachPuff;
            pnlMenu.Controls.Add(btnEliminarProducto);
            pnlMenu.Controls.Add(btnModificarProducto);
            pnlMenu.Controls.Add(btnCrearProducto);
            pnlMenu.Controls.Add(btnCerrarPanel);
            pnlMenu.Location = new Point(-1, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(134, 456);
            pnlMenu.TabIndex = 0;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(3, 120);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(128, 32);
            btnEliminarProducto.TabIndex = 4;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(4, 82);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(128, 32);
            btnModificarProducto.TabIndex = 3;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.Location = new Point(3, 44);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(128, 32);
            btnCrearProducto.TabIndex = 2;
            btnCrearProducto.Text = "Crear Producto";
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // btnCerrarPanel
            // 
            btnCerrarPanel.BackColor = Color.Red;
            btnCerrarPanel.ForeColor = Color.White;
            btnCerrarPanel.Location = new Point(107, 0);
            btnCerrarPanel.Name = "btnCerrarPanel";
            btnCerrarPanel.Size = new Size(28, 28);
            btnCerrarPanel.TabIndex = 1;
            btnCerrarPanel.Text = "X";
            btnCerrarPanel.UseVisualStyleBackColor = false;
            btnCerrarPanel.Click += btnCerrarPanel_Click;
            // 
            // btnAbrirPanel
            // 
            btnAbrirPanel.BackColor = Color.Green;
            btnAbrirPanel.FlatAppearance.BorderSize = 0;
            btnAbrirPanel.FlatStyle = FlatStyle.Flat;
            btnAbrirPanel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirPanel.ForeColor = Color.Snow;
            btnAbrirPanel.Location = new Point(-26, 0);
            btnAbrirPanel.Name = "btnAbrirPanel";
            btnAbrirPanel.Size = new Size(65, 38);
            btnAbrirPanel.TabIndex = 1;
            btnAbrirPanel.Text = "➡️";
            btnAbrirPanel.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirPanel.UseVisualStyleBackColor = false;
            btnAbrirPanel.Click += btnAbrirPanel_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(139, 182);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(658, 256);
            dgvProductos.TabIndex = 2;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // grpProductoSeleccionado
            // 
            grpProductoSeleccionado.Controls.Add(btnConfirmar);
            grpProductoSeleccionado.Controls.Add(nupPrecioVenta);
            grpProductoSeleccionado.Controls.Add(nupCosto);
            grpProductoSeleccionado.Controls.Add(nupStock);
            grpProductoSeleccionado.Controls.Add(label4);
            grpProductoSeleccionado.Controls.Add(lblCosto);
            grpProductoSeleccionado.Controls.Add(lblStock);
            grpProductoSeleccionado.Controls.Add(lblDescripcion);
            grpProductoSeleccionado.Controls.Add(txtDescripcion);
            grpProductoSeleccionado.Location = new Point(139, 0);
            grpProductoSeleccionado.Name = "grpProductoSeleccionado";
            grpProductoSeleccionado.Size = new Size(658, 176);
            grpProductoSeleccionado.TabIndex = 3;
            grpProductoSeleccionado.TabStop = false;
            grpProductoSeleccionado.Text = "Producto Seleccionado:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(522, 91);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(127, 61);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Visible = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // nupPrecioVenta
            // 
            nupPrecioVenta.DecimalPlaces = 2;
            nupPrecioVenta.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nupPrecioVenta.Location = new Point(185, 109);
            nupPrecioVenta.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupPrecioVenta.Name = "nupPrecioVenta";
            nupPrecioVenta.ReadOnly = true;
            nupPrecioVenta.Size = new Size(173, 43);
            nupPrecioVenta.TabIndex = 12;
            // 
            // nupCosto
            // 
            nupCosto.DecimalPlaces = 2;
            nupCosto.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nupCosto.Location = new Point(185, 45);
            nupCosto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupCosto.Name = "nupCosto";
            nupCosto.ReadOnly = true;
            nupCosto.Size = new Size(173, 43);
            nupCosto.TabIndex = 11;
            // 
            // nupStock
            // 
            nupStock.DecimalPlaces = 2;
            nupStock.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nupStock.Location = new Point(6, 109);
            nupStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupStock.Name = "nupStock";
            nupStock.ReadOnly = true;
            nupStock.Size = new Size(173, 43);
            nupStock.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 91);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio venta:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(185, 26);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(41, 15);
            lblCosto.TabIndex = 6;
            lblCosto.Text = "Costo:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(6, 91);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(6, 26);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(6, 44);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Size = new Size(171, 43);
            txtDescripcion.TabIndex = 0;
            // 
            // FrmGestionProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpProductoSeleccionado);
            Controls.Add(dgvProductos);
            Controls.Add(pnlMenu);
            Controls.Add(btnAbrirPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestionProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGestionProducto";
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grpProductoSeleccionado.ResumeLayout(false);
            grpProductoSeleccionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnCerrarPanel;
        private Button btnAbrirPanel;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnCrearProducto;
        private DataGridView dgvProductos;
        private GroupBox grpProductoSeleccionado;
        private TextBox txtDescripcion;
        private Label label4;
        private Label lblCosto;
        private Label lblStock;
        private Label lblDescripcion;
        private NumericUpDown nupPrecioVenta;
        private NumericUpDown nupCosto;
        private NumericUpDown nupStock;
        private Button btnConfirmar;
    }
}