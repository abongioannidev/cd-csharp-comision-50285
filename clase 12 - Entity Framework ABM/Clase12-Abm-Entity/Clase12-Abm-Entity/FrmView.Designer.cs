namespace Clase12_Abm_Entity
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListar = new Button();
            dgvDatos = new DataGridView();
            btnBuscarId = new Button();
            txtId = new TextBox();
            btnAgregarUsuario = new Button();
            btnEliminarProducto = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(2, 12);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(117, 70);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(235, 12);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(454, 399);
            dgvDatos.TabIndex = 1;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new Point(2, 88);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new Size(117, 70);
            btnBuscarId.TabIndex = 2;
            btnBuscarId.Text = "Buscar por id";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 113);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(2, 164);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(117, 70);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(2, 240);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(117, 70);
            btnEliminarProducto.TabIndex = 5;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(2, 316);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(117, 70);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar Usuario";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 423);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(txtId);
            Controls.Add(btnBuscarId);
            Controls.Add(dgvDatos);
            Controls.Add(btnListar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private DataGridView dgvDatos;
        private Button btnBuscarId;
        private TextBox txtId;
        private Button btnAgregarUsuario;
        private Button btnEliminarProducto;
        private Button btnActualizar;
    }
}
