using System;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        Archivos archivos = new Archivos();
        public Form1()
        {
            InitializeComponent();
        }

        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<Cliente> listaClientes = new BindingList<Cliente>();
        BindingList<Proveedor> listaProveedores = new BindingList<Proveedor>();
        BindingList<Repartidor> listaRepartidores = new BindingList<Repartidor>();

        private int rol = 0;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicio();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OcultarTodo() { 
             cuentaToolStripMenuItem.Visible = false;
             AdministrarUsuariosToolStripMenuItem.Visible = false;
              AdministrarEnviosToolStripMenuItem.Visible = false;
            entregarEnvioToolStripMenuItem.Visible=false;
        }

        private void MostrarSegunRol(int rol)
        {
            cuentaToolStripMenuItem.Visible = true;
            switch (rol)
            {
                case 1:
                    break;
                case 2:
                    entregarEnvioToolStripMenuItem.Visible = true;
                    break;
                case 3:
                    break;
                case 4:
                    AdministrarUsuariosToolStripMenuItem.Visible = true;
                    AdministrarEnviosToolStripMenuItem.Visible = true;
                   // entregarEnvioToolStripMenuItem.Visible =true;
                    break;
            }
        }

        private void agregarEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEnvio agregarEnvio = new AgregarEnvio(listaPaquetes);
            agregarEnvio.MdiParent = this;
            agregarEnvio.Show();
        }

        void agregarClientesALista(BindingList<Cliente> listaClientes)
        {
            int cantCuentas = archivos.Contar_archivo("cuentas.csv");
            for (int i=1; i<=cantCuentas; i++)
            {
                int tipo = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 3, i.ToString()));
                if (tipo == 1)
                {
                    int id = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 0, i.ToString()));
                    string usuario = archivos.Buscar_archivo("cuentas.csv", 0, 1, i.ToString());
                    string contraseña = (archivos.Buscar_archivo("cuentas.csv", 0, 2, i.ToString()));
                    string activo = (archivos.Buscar_archivo("cuentas.csv", 0, 4, i.ToString()));
                    Cliente cliente = new Cliente(id, usuario, contraseña, tipo);
                    listaClientes.Add(cliente);
                }
            }
        }
        void agregarProveedoresALista(BindingList<Proveedor> listaProveedor)
        {
            int cantCuentas = archivos.Contar_archivo("cuentas.csv");
            for (int i = 1; i <= cantCuentas; i++)
            {
                int tipo = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 3, i.ToString()));
                if (tipo == 3)
                {
                    int id = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 0, i.ToString()));
                    string usuario = archivos.Buscar_archivo("cuentas.csv", 0, 1, i.ToString());
                    string contraseña = (archivos.Buscar_archivo("cuentas.csv", 0, 2, i.ToString()));
                    string activo = (archivos.Buscar_archivo("cuentas.csv", 0, 4, i.ToString()));
                    Proveedor proveedor = new Proveedor(id, usuario, contraseña, tipo);
                    listaProveedores.Add(proveedor);
                }
            }
        }
        void agregarRepartidoresALista(BindingList<Repartidor> listaRepartidor)
        {
            int cantCuentas = archivos.Contar_archivo("cuentas.csv");
            for (int i = 1; i <= cantCuentas; i++)
            {
                int tipo = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 3, i.ToString()));
                if (tipo == 2)
                {
                    int id = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 0, i.ToString()));
                    string usuario = archivos.Buscar_archivo("cuentas.csv", 0, 1, i.ToString());
                    string contraseña = (archivos.Buscar_archivo("cuentas.csv", 0, 2, i.ToString()));
                    string activo = (archivos.Buscar_archivo("cuentas.csv", 0, 4, i.ToString()));
                    Repartidor repartidor = new Repartidor(id, usuario, contraseña, tipo);
                    listaRepartidores.Add(repartidor);
                }
            }
        }
        private void modificarEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEnvio modificarEnvio = new ModificarEnvio(listaPaquetes);
            modificarEnvio.MdiParent = this;
            modificarEnvio.Show();
        }

        private void unloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivos.Mantener_sesion(0, 0, "0", "0", 0, 0);
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            MessageBox.Show("Cerrado sesion con exito");
            inicio();
        }

        private void inicio()
        {
            listaPaquetes.Clear();
            listaClientes.Clear();
            listaProveedores.Clear();
            listaRepartidores.Clear();
            OcultarTodo();
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
            login.LoginExitoso += (rolRecibido) =>
            {
                rol = rolRecibido;
                OcultarTodo();
                MostrarSegunRol(rol);

            };
            Paquete.agregarPaquetesALista(listaPaquetes);
            agregarClientesALista(listaClientes);
            agregarProveedoresALista(listaProveedores);
            agregarRepartidoresALista(listaRepartidores);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCliente modificarCliente = new ModificarCliente(listaClientes);
            modificarCliente.MdiParent = this;
            modificarCliente.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor modificarProveedor = new ModificarProveedor(listaProveedores);
            modificarProveedor.MdiParent = this;
            modificarProveedor.Show();
        }

        private void movilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRepartidor modificarRepartidor = new ModificarRepartidor(listaRepartidores);
            modificarRepartidor.MdiParent = this;
            modificarRepartidor.Show();
        }

        private void entregarEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntregarEnvio entregarEnvio = new EntregarEnvio(listaPaquetes);
            entregarEnvio.MdiParent = this;
            entregarEnvio.Show();
        }
    }
}
