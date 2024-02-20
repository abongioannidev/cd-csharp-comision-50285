namespace FrontProyectoFinal_CoderHouse
{
    partial class FrmGestionUsuario
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
            grpIdentidad = new GroupBox();
            grpNombre = new GroupBox();
            grpCuenta = new GroupBox();
            btnActualizar = new Button();
            lblUsuario = new Label();
            txtId = new TextBox();
            txtEmail = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNombreUsuario = new TextBox();
            txtPassword = new TextBox();
            lblId = new Label();
            lblEmail = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblNombreUsuario = new Label();
            lblPassword = new Label();
            grpIdentidad.SuspendLayout();
            grpNombre.SuspendLayout();
            grpCuenta.SuspendLayout();
            SuspendLayout();
            // 
            // grpIdentidad
            // 
            grpIdentidad.Controls.Add(lblEmail);
            grpIdentidad.Controls.Add(lblId);
            grpIdentidad.Controls.Add(txtEmail);
            grpIdentidad.Controls.Add(txtId);
            grpIdentidad.Location = new Point(12, 48);
            grpIdentidad.Name = "grpIdentidad";
            grpIdentidad.Size = new Size(200, 203);
            grpIdentidad.TabIndex = 0;
            grpIdentidad.TabStop = false;
            grpIdentidad.Text = "Datos de identidad";
            // 
            // grpNombre
            // 
            grpNombre.Controls.Add(lblApellido);
            grpNombre.Controls.Add(lblNombre);
            grpNombre.Controls.Add(txtApellido);
            grpNombre.Controls.Add(txtNombre);
            grpNombre.Location = new Point(218, 48);
            grpNombre.Name = "grpNombre";
            grpNombre.Size = new Size(200, 203);
            grpNombre.TabIndex = 1;
            grpNombre.TabStop = false;
            grpNombre.Text = "Datos de nombre";
            // 
            // grpCuenta
            // 
            grpCuenta.Controls.Add(lblPassword);
            grpCuenta.Controls.Add(lblNombreUsuario);
            grpCuenta.Controls.Add(txtPassword);
            grpCuenta.Controls.Add(txtNombreUsuario);
            grpCuenta.Location = new Point(424, 48);
            grpCuenta.Name = "grpCuenta";
            grpCuenta.Size = new Size(200, 203);
            grpCuenta.TabIndex = 1;
            grpCuenta.TabStop = false;
            grpCuenta.Text = "Datos de cuenta";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(178, 257);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(279, 68);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(170, -1);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(287, 46);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Datos del usuario:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(6, 49);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(188, 43);
            txtId.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(6, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 43);
            txtEmail.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(6, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 43);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(6, 121);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(188, 43);
            txtApellido.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(6, 49);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(188, 43);
            txtNombreUsuario.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(6, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 43);
            txtPassword.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 8;
            lblId.Text = "Id:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 103);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 103);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(6, 31);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(112, 15);
            lblNombreUsuario.TabIndex = 12;
            lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // FrmGestionUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 341);
            Controls.Add(lblUsuario);
            Controls.Add(btnActualizar);
            Controls.Add(grpCuenta);
            Controls.Add(grpNombre);
            Controls.Add(grpIdentidad);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestionUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGestionUsuario";
            grpIdentidad.ResumeLayout(false);
            grpIdentidad.PerformLayout();
            grpNombre.ResumeLayout(false);
            grpNombre.PerformLayout();
            grpCuenta.ResumeLayout(false);
            grpCuenta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpIdentidad;
        private GroupBox grpNombre;
        private GroupBox grpCuenta;
        private Button btnActualizar;
        private Label lblUsuario;
        private TextBox txtEmail;
        private TextBox txtId;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private TextBox txtNombreUsuario;
        private Label lblEmail;
        private Label lblId;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblPassword;
        private Label lblNombreUsuario;
    }
}