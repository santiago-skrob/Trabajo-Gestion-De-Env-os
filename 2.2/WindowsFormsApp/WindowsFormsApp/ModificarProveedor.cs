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
    public partial class ModificarProveedor : Form
    {
        Archivos archivos = new Archivos();
        BindingList<Proveedor> listaProveedores = new BindingList<Proveedor>();
        Proveedor proveedorBuscado = new Proveedor();
        public ModificarProveedor(BindingList<Proveedor> listaRecibida)
        {
           listaProveedores=listaRecibida;
            InitializeComponent();
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            cuentasDGV.DataSource = listaProveedores;
        }
      

        private void buscarCuentaBTN_Click(object sender, EventArgs e)
        {

        }

        private void buscarCuentaBTN_Click_1(object sender, EventArgs e)
        {
          
        }

        private void buscarIdBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tipoUsuario = archivos.Buscar_archivo("cuentas.csv", 0, 3, idProveBOX.Text);
                proveedorBuscado = Usuario.BuscarUsuarioEnLista(listaProveedores, Convert.ToInt32(idProveBOX.Text));
                if (tipoUsuario == "3")
                {
                    idLabel.Text = archivos.Buscar_archivo("cuentas.csv", 0, 0, idProveBOX.Text);
                    contraLBL.Text = archivos.Buscar_archivo("cuentas.csv", 0, 2, idProveBOX.Text);
                    usuarioLBL.Text = archivos.Buscar_archivo("cuentas.csv", 0, 1, idProveBOX.Text);
                    tipoLBL.Text = tipoUsuario;
                }
                else
                {
                    if (tipoUsuario == "1" || tipoUsuario == "2" || tipoUsuario == "4")
                    {
                        MessageBox.Show("El usuario no es Proveedor, tiene otro rango");
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

        private void cambiarBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                archivos.Editar_archivo("cuentas.csv", Convert.ToInt32(idLabel.Text), $"{idLabel.Text};{usuarioBOX.Text};{contraBOX.Text};{tipoBOX.Text};{"1"}");
                proveedorBuscado.Cuenta = usuarioBOX.Text;
                proveedorBuscado.Contra = contraBOX.Text;
                proveedorBuscado.Tipo = Convert.ToInt32(tipoBOX.Text);
                cuentasDGV.Refresh();
                
                List<Proveedor> listaProv = listaProveedores.ToList();
                listaProv.Sort();
                listaProveedores = new BindingList<Proveedor>(listaProv);
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
            archivos.Eliminar_linea("cuentas.csv",Convert.ToInt32(idLabel.Text));
            listaProveedores.Remove(proveedorBuscado);
            idLabel.Text = "-";
            usuarioLBL.Text = "-";
            contraLBL.Text = "-";
            tipoLBL.Text = "-";
        }
    }
}
