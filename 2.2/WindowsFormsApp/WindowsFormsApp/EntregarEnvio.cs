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
    public partial class EntregarEnvio : Form
    {
        Archivos archi = new Archivos();
        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<PaqueteParaMostrar> listaParaMostrar = new BindingList<PaqueteParaMostrar>();
        Paquete paqueteBuscado = new Paquete();
        public EntregarEnvio(BindingList<Paquete> listaRecibida)
        {
            InitializeComponent();
            listaPaquetes=listaRecibida;
        }

        private void buscarPaqueteBTN_Click(object sender, EventArgs e)
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

        private void EntregarEnvio_Load(object sender, EventArgs e)
        {
            listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            paquetesDGV.DataSource = listaParaMostrar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaPaquetes.Remove(paqueteBuscado);
            if (entregadoCBX.Checked)
            {
                paqueteBuscado.Entregado = "si";
                string idProductos = archi.Buscar_archivo("paquetes.csv", 0, 10, idPaqueteBOX.Text);
                archi.Editar_archivo("paquetes.csv", paqueteBuscado.ID, $"{paqueteBuscado.ID}; {paqueteBuscado.Descripcion};{paqueteBuscado.Cliente.ID_Usuario};{paqueteBuscado.Repartidor.ID_Usuario};" +
                    $"{paqueteBuscado.Repartidor.ID_Usuario};{paqueteBuscado.FechaSalida};{paqueteBuscado.FechaDestino};{paqueteBuscado.Movil.Patente};{paqueteBuscado.Costo};" +
                    $"{idProductos};{paqueteBuscado.Salida};{paqueteBuscado.Destino};{paqueteBuscado.Entregado}");
            }
            else
            {
                MessageBox.Show("Chequear casilla para continuar");
            }
            listaPaquetes.Add(paqueteBuscado);
            listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            paquetesDGV.DataSource = listaParaMostrar;
        }
    }
}
