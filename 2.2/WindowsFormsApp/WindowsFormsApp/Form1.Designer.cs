namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarEnviosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.AdministrarEnviosToolStripMenuItem,
            this.AdministrarUsuariosToolStripMenuItem,
            this.entregarEnvioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.unloginToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            this.cuentaToolStripMenuItem.Click += new System.EventHandler(this.cuentaToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // unloginToolStripMenuItem
            // 
            this.unloginToolStripMenuItem.Name = "unloginToolStripMenuItem";
            this.unloginToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.unloginToolStripMenuItem.Text = "Unlogin";
            this.unloginToolStripMenuItem.Click += new System.EventHandler(this.unloginToolStripMenuItem_Click);
            // 
            // AdministrarEnviosToolStripMenuItem
            // 
            this.AdministrarEnviosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEnvioToolStripMenuItem,
            this.modificarEnvioToolStripMenuItem});
            this.AdministrarEnviosToolStripMenuItem.Name = "AdministrarEnviosToolStripMenuItem";
            this.AdministrarEnviosToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.AdministrarEnviosToolStripMenuItem.Text = "Administrar Envio";
            this.AdministrarEnviosToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // agregarEnvioToolStripMenuItem
            // 
            this.agregarEnvioToolStripMenuItem.Name = "agregarEnvioToolStripMenuItem";
            this.agregarEnvioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarEnvioToolStripMenuItem.Text = "Agregar Envio";
            this.agregarEnvioToolStripMenuItem.Click += new System.EventHandler(this.agregarEnvioToolStripMenuItem_Click);
            // 
            // modificarEnvioToolStripMenuItem
            // 
            this.modificarEnvioToolStripMenuItem.Name = "modificarEnvioToolStripMenuItem";
            this.modificarEnvioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modificarEnvioToolStripMenuItem.Text = "Modificar envio";
            this.modificarEnvioToolStripMenuItem.Click += new System.EventHandler(this.modificarEnvioToolStripMenuItem_Click);
            // 
            // AdministrarUsuariosToolStripMenuItem
            // 
            this.AdministrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.movilesToolStripMenuItem});
            this.AdministrarUsuariosToolStripMenuItem.Name = "AdministrarUsuariosToolStripMenuItem";
            this.AdministrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.AdministrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // movilesToolStripMenuItem
            // 
            this.movilesToolStripMenuItem.Name = "movilesToolStripMenuItem";
            this.movilesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.movilesToolStripMenuItem.Text = "Repartidores";
            this.movilesToolStripMenuItem.Click += new System.EventHandler(this.movilesToolStripMenuItem_Click);
            // 
            // entregarEnvioToolStripMenuItem
            // 
            this.entregarEnvioToolStripMenuItem.Name = "entregarEnvioToolStripMenuItem";
            this.entregarEnvioToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.entregarEnvioToolStripMenuItem.Text = "Entregar Envio";
            this.entregarEnvioToolStripMenuItem.Click += new System.EventHandler(this.entregarEnvioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Paqueteria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem AdministrarEnviosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unloginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregarEnvioToolStripMenuItem;
    }
}

