namespace Clase12_Abm_Entity
{
    partial class AMBUsuario
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
            Aceptar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(34, 222);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(216, 100);
            Aceptar.TabIndex = 0;
            Aceptar.Text = "btnAceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "usuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 99);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "password";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // AMBUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 334);
            ControlBox = false;
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(Aceptar);
            Name = "AMBUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AMBUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}