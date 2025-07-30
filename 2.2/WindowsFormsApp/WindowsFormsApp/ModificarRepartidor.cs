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
    public partial class ModificarRepartidor : Form
    {
        Archivos archivos = new Archivos();
        BindingList<Repartidor> listaRepartidores = new BindingList<Repartidor>();
        Repartidor repartidorBuscado = new Repartidor();
        public ModificarRepartidor(BindingList<Repartidor> listaRecibida)
        {
            listaRepartidores = listaRecibida;
            InitializeComponent();
            cuentasDGV.DataSource = listaRecibida;
        }

        private void buscarIdBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoUsuario = archivos.Buscar_archivo("cuentas.csv", 0, 3, idRepartidorBOX.Text);
                if (tipoUsuario == "2")
                {
                    idLabel.Text = archivos.Buscar_archivo("cuentas.csv", 0, 0, idRepartidorBOX.Text);
                    contraLBL.Text = archivos.Buscar_archivo("cuentas.csv", 0, 2, idRepartidorBOX.Text);
                    usuarioLBL.Text = archivos.Buscar_archivo("cuentas.csv", 0, 1, idRepartidorBOX.Text);
                    tipoLBL.Text = tipoUsuario;
                    repartidorBuscado = Usuario.BuscarUsuarioEnLista(listaRepartidores, Convert.ToInt32(idRepartidorBOX.Text));
                }
                else
                {
                    if (tipoUsuario == "1" || tipoUsuario == "3" || tipoUsuario == "4")
                    {
                        MessageBox.Show("El usuario no es repartidor, tiene otro rango");
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

        private void cambiarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                archivos.Editar_archivo("cuentas.csv", Convert.ToInt32(idLabel.Text), $"{idLabel.Text};{usuarioBOX.Text};{contraBOX.Text};{tipoBOX.Text};{"1"}");
                repartidorBuscado.Cuenta = usuarioBOX.Text;
                repartidorBuscado.Contra = contraBOX.Text;
                repartidorBuscado.Tipo = Convert.ToInt32(tipoBOX.Text);
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
            listaRepartidores.Remove(repartidorBuscado);
            idLabel.Text = "-";
            usuarioLBL.Text = "-";
            contraLBL.Text = "-";
            tipoLBL.Text = "-";
        }

        private void ModificarRepartidor_Load(object sender, EventArgs e)
        {

        }
    }
}
