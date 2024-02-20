namespace FrontProyectoFinal_CoderHouse
{
    partial class FrmGestion
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
            mstPrincipal = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mstText = new ToolStripTextBox();
            mstPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mstPrincipal
            // 
            mstPrincipal.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, mstText });
            mstPrincipal.Location = new Point(0, 0);
            mstPrincipal.Name = "mstPrincipal";
            mstPrincipal.Size = new Size(1114, 27);
            mstPrincipal.TabIndex = 0;
            mstPrincipal.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem1, productosToolStripMenuItem, ventasToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(48, 23);
            usuarioToolStripMenuItem.Text = "Inicio";
            // 
            // usuarioToolStripMenuItem1
            // 
            usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            usuarioToolStripMenuItem1.Size = new Size(180, 22);
            usuarioToolStripMenuItem1.Text = "Usuario";
            usuarioToolStripMenuItem1.Click += usuarioToolStripMenuItem1_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(180, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(180, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // mstText
            // 
            mstText.Name = "mstText";
            mstText.ReadOnly = true;
            mstText.Size = new Size(256, 23);
            // 
            // FrmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 574);
            ControlBox = false;
            Controls.Add(mstPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = mstPrincipal;
            MinimizeBox = false;
            Name = "FrmGestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGestion";
            mstPrincipal.ResumeLayout(false);
            mstPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mstPrincipal;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripTextBox mstText;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}