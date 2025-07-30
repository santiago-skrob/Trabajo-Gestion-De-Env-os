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
    public partial class ModificarEnvio : Form
    {
        Archivos archi = new Archivos();
        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<PaqueteParaMostrar> listaParaMostrar = new BindingList<PaqueteParaMostrar>();
        Paquete paqueteBuscado = new Paquete();
        public ModificarEnvio(BindingList<Paquete> listaPaquetesRecibida)
        {
            InitializeComponent();
            listaPaquetes = listaPaquetesRecibida;

        }

        private void idClienteLBL_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                descripcionLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 1, idPaqueteBOX.Text);
                idClienteLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 2, idPaqueteBOX.Text);
                idRepartidorLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 3, idPaqueteBOX.Text);
                idProveedorLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 4, idPaqueteBOX.Text);
                fechaEnvioLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 5, idPaqueteBOX.Text);
                fechaDestinoLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 6, idPaqueteBOX.Text);
                movilLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 7, idPaqueteBOX.Text);
                costoLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 8, idPaqueteBOX.Text);
                idProductosLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 9, idPaqueteBOX.Text);
                lugarSalidaLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 10, idPaqueteBOX.Text);
                lugarDestinoLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 11, idPaqueteBOX.Text);
                entregadoLBL.Text = archi.Buscar_archivo("paquetes.csv", 0, 12, idPaqueteBOX.Text);

                paqueteBuscado = Paquete.EncontrarPaqueteEnLista(listaPaquetes, Convert.ToInt32(idPaqueteBOX.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Id no encontrado, intente nuevamente");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarEnvio_Load(object sender, EventArgs e)
        {
                listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            paquetesDGV.DataSource = listaParaMostrar;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void modificarEnvioBOX_Click(object sender, EventArgs e)
        {
            try
            {
                listaPaquetes.Remove(paqueteBuscado);
                paqueteBuscado.Descripcion = descripcionBOX.Text;
                paqueteBuscado.Destino = lugarDestinoBOX.Text;
                paqueteBuscado.Salida = lugarSalidaBOX.Text;
                paqueteBuscado.Cliente.ID_Usuario = Convert.ToInt32(idClienteBOX.Text);
                paqueteBuscado.Proveedor.ID_Usuario = Convert.ToInt32(idProveedorBOX.Text);
                paqueteBuscado.FechaSalida = Convert.ToDateTime(fechEnvioDTP.Text);
                paqueteBuscado.Movil.Patente = movilBOX.Text;
                paqueteBuscado.Costo = Convert.ToInt32(costoBOX.Text);
                paqueteBuscado.Entregado = "no";
                string idProductos = archi.Buscar_archivo("paquetes.csv", 0, 10, idPaqueteBOX.Text);
                if (entregadoCBX.Checked)
                {
                    paqueteBuscado.Entregado = "si";
                }
                listaPaquetes.Add(paqueteBuscado);
                listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
                paquetesDGV.DataSource = listaParaMostrar;
                archi.Editar_archivo("paquetes.csv", Convert.ToInt32(idPaqueteBOX.Text), $"{idPaqueteBOX.Text};{paqueteBuscado.Descripcion};{paqueteBuscado.Cliente.ID_Usuario}" +
                    $";{paqueteBuscado.Repartidor.ID_Usuario};{paqueteBuscado.Proveedor.ID_Usuario};{paqueteBuscado.FechaSalida};{paqueteBuscado.FechaDestino};{paqueteBuscado.Movil.Patente};" +
                    $"{paqueteBuscado.Costo};{idProductos};{paqueteBuscado.Salida};{paqueteBuscado.Destino};{paqueteBuscado.Entregado}");
                descripcionLBL.Text = "-";
                idClienteLBL.Text = "-";
                idRepartidorLBL.Text = "-";
                idProveedorLBL.Text = "-";
                fechaEnvioLBL.Text = "-";
                fechaDestinoLBL.Text = "-";
                movilLBL.Text = "-";
                costoLBL.Text = "-";
                idProductosLBL.Text = "-";
                lugarSalidaLBL.Text = "-";
                lugarDestinoLBL.Text = "-";
                entregadoLBL.Text = "-";

                var L = (from p in listaPaquetes
                        orderby p.ID ascending
                        select p).ToList();
                listaPaquetes = new BindingList<Paquete>(L);
                listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
                paquetesDGV.DataSource = listaParaMostrar;


            }
            catch (FormatException ex)
            {
                MessageBox.Show("error al convertir datos numericos. verifique campos de entrada. recuerde completar todos los campos\n" + ex);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Cuenta no encontrada. Verifique que las cuentas existan. recuerde completar todos los campos\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado, recuerde completar todos los campos:\n" + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            archi.Eliminar_linea("paquetes.csv", Convert.ToInt32(idPaqueteBOX.Text));
            listaPaquetes.Remove(paqueteBuscado);
            listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            paquetesDGV.DataSource = listaParaMostrar;
            descripcionLBL.Text = "-";
            idClienteLBL.Text = "-";
            idRepartidorLBL.Text = "-";
            idProveedorLBL.Text = "-";
            fechaEnvioLBL.Text = "-";
            fechaDestinoLBL.Text = "-";
            movilLBL.Text = "-";
            costoLBL.Text = "-";
            idProductosLBL.Text = "-";
            lugarSalidaLBL.Text = "-";
            lugarDestinoLBL.Text = "-";
            entregadoLBL.Text = "-";
        }

        private void idPaqueteBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void entregadoLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
