using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        private int id_usuario = 0;
        private int tipo = 0;
        private int activo = 0;
        private bool reiniciando_sesion = false;

        private string usuario_cargado = "";
        private string contra_cargado = "";
        Archivos archivos = new Archivos();
        public Login()
        {
            InitializeComponent();
        }

        public event Action<int> LoginExitoso;
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox2.Text;
            string contra = this.textBox1.Text;
            int activado = 0;

            if (checkBox1.Checked == true)
            {
                activado = 1;
            }


            if (usuario != "" || contra != "")
            {
                id_usuario = archivos.Iniciar_sesion(usuario, contra);

                if (id_usuario == 0)
                {
                    label3.Visible = true;
                }
                else
                {
                    tipo = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 3, id_usuario.ToString()));
                    activo = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 4, id_usuario.ToString()));
                    LoginExitoso?.Invoke(tipo);
                    if (activo == 1)
                    {
                        switch (tipo)
                        {
                            case 0:
                                {
                                    MessageBox.Show("Usuario inexistente");
                                    break;
                                }
                            case 1:
                                {
                                    Form_Cliente form = new Form_Cliente(id_usuario, usuario, contra, tipo);
                                    form.MdiParent = this.MdiParent;
                                    form.Show();
                                    this.Close();
                                    archivos.Mantener_sesion(activado, id_usuario, usuario, contra, tipo, activo);
                                    MessageBox.Show("Iniciado sesion con exito");
                                    break;
                                }
                            case 2:
                                {
                                    Form_Repartidor form = new Form_Repartidor(id_usuario, usuario, contra, tipo);
                                    form.MdiParent = this.MdiParent;
                                    form.Show();
                                    this.Close();
                                    archivos.Mantener_sesion(activado, id_usuario, usuario, contra, tipo, activo);
                                    MessageBox.Show("Iniciado sesion con exito");
                                    break;
                                }
                            case 3:
                                {
                                    Form_Proveedor form = new Form_Proveedor(id_usuario, usuario, contra, tipo);
                                    form.MdiParent = this.MdiParent;
                                    form.Show();
                                    this.Close();
                                    archivos.Mantener_sesion(activado, id_usuario, usuario, contra, tipo, activo);
                                    MessageBox.Show("Iniciado sesion con exito");
                                    break;
                                }
                            case 4:
                                {
                                    Form_Administador form = new Form_Administador(id_usuario, usuario, contra, tipo);
                                    form.MdiParent = this.MdiParent;
                                    form.Show();
                                    this.Close();
                                    archivos.Mantener_sesion(activado, id_usuario, usuario, contra, tipo, activo);
                                    MessageBox.Show("Iniciado sesion con exito");
                                    break;
                                }
                            default:
                                {
                                    MessageBox.Show("Usuario inexistente");
                                    break;
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.MdiParent = this.MdiParent;
            registro.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            string[] vector = archivos.Reiniciar_sesion();

            string activado = vector[0];

            string id_rec = vector[1];
            string usuario_rec = vector[2];
            string contra_rec = vector[3];
            string tipo_rec = vector[4];
            string activo_rec = vector[5];

            if (activado == "1")
            {
                if (activo_rec == "1")
                {
                    id_usuario = Convert.ToInt32(id_rec);
                    usuario_cargado = usuario_rec;
                    contra_cargado = contra_rec;
                    tipo = Convert.ToInt32(tipo_rec);
                    reiniciando_sesion = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            if (reiniciando_sesion == true)
            {
                LoginExitoso?.Invoke(tipo);
                switch (tipo)
                {
                    case 0:
                        {
                            MessageBox.Show("Error al cargar la sesion");
                            break;
                        }
                    case 1:
                        {
                            Form_Cliente form = new Form_Cliente(id_usuario, usuario_cargado, contra_cargado, tipo);
                            form.MdiParent = this.MdiParent;
                            form.Show();
                            this.Close();
                            break;
                        }
                    case 2:
                        {
                            Form_Repartidor form = new Form_Repartidor(id_usuario, usuario_cargado, contra_cargado, tipo);
                            form.MdiParent = this.MdiParent;
                            form.Show();
                            this.Close();
                            break;
                        }
                    case 3:
                        {
                            Form_Proveedor form = new Form_Proveedor(id_usuario, usuario_cargado, contra_cargado, tipo);
                            form.MdiParent = this.MdiParent;
                            form.Show();
                            this.Close();
                            break;
                        }
                    case 4:
                        {
                            Form_Administador form = new Form_Administador(id_usuario, usuario_cargado, contra_cargado, tipo);
                            form.MdiParent = this.MdiParent;
                            form.Show();
                            this.Close();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Error al cargar la sesion");
                            break;
                        }
                }
            }
        }
    }
}