using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ModificarCliente : Form
    {
        Archivos archivos = new Archivos();
        BindingList<Cliente> listaClientes = new BindingList<Cliente>();
        Cliente clienteBuscado = new Cliente();
        public ModificarCliente(BindingList<Cliente> listaRecibida)
        {
            InitializeComponent();
            listaClientes=listaRecibida;
            cuentasDGV.DataSource=listaRecibida;
        }

        private void buscarIdBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoUsuario = archivos.Buscar_archivo("cuentas.csv", 0, 3, idClienteBOX.Text);
                if (tipoUsuario == "1")
                {
                    idLabel.Text = archivos.Buscar_archivo("cuentas.csv", 0, 0, idClienteBOX.Text);
                    contraLBL.Text = archivos.Buscar_archivo("cuentas.csv", 0, 2, idClienteBOX.Text);
                    usuarioLBL.Text = archivos.Buscar_archivo("cuentas.csv", 0, 1, idClienteBOX.Text);
                    tipoLBL.Text = tipoUsuario;
                    clienteBuscado = Usuario.BuscarUsuarioEnLista(listaClientes, Convert.ToInt32(idClienteBOX.Text));
                }
                else
                {
                    if (tipoUsuario == "2" || tipoUsuario == "3" || tipoUsuario == "4")
                    {
                        MessageBox.Show("El usuario no es cliente, tiene otro rango");
                    }
                    else
                    {
                        MessageBox.Show("El id no existe");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("id no encontrado. intente nuevamente\n" + ex);
            }


        }

        private void buscarCuentaBTN_Click(object sender, EventArgs e)
        {
         
        }

        private void buscarCuentaBTN_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cambiarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                archivos.Editar_archivo("cuentas.csv", Convert.ToInt32(idLabel.Text), $"{idLabel.Text};{usuarioBOX.Text};{contraBOX.Text};{tipoBOX.Text};{"1"}");
                clienteBuscado.Cuenta = usuarioBOX.Text;
                clienteBuscado.Contra = contraBOX.Text;
                clienteBuscado.Tipo = Convert.ToInt32(tipoBOX.Text);
                cuentasDGV.Refresh();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("error al convertir datos numericos. verifique campos de entrada. recuerde completar todos los campos\n" + ex);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Complete todos los datos para continuar" + ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado, recuerde completar todos los campos:\n" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            archivos.Eliminar_linea("cuentas.csv", Convert.ToInt32(idLabel.Text));
            listaClientes.Remove(clienteBuscado);
            idLabel.Text = "-";
            usuarioLBL.Text = "-";
            contraLBL.Text = "-";
            tipoLBL.Text = "-";
        }
    }
}
