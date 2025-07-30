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
    public partial class AgregarEnvio : Form
    {
        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<PaqueteParaMostrar> listaParaMostrar = new BindingList<PaqueteParaMostrar>();
        List<Producto> listaProductosTemporal = new List<Producto>();
        Archivos archivos = new Archivos();

        public AgregarEnvio(BindingList<Paquete> listaPaquetesRecibida)
        {
            InitializeComponent();
            listaPaquetes = listaPaquetesRecibida;
        }
      
        private void AgregarEnvio_Load(object sender, EventArgs e)
        {
            listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            paquetesDGV.DataSource = listaParaMostrar;
        }

        private void agregarProductoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto(productosBOX.Text, descripcionBOX.Text, Convert.ToInt32(cantidadBOX.Text));
                producto.Stock = Convert.ToInt32(cantidadBOX.Text);
                listaProductosTemporal.Add(producto);
                int idProve = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 0, cuentaProveBOX.Text));
                int idCliente = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 0, cuentaClieBOX.Text));
                int idRepartidor = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 0, cuentaRepartidorBOX.Text));
                archivos.Agregar_archivo("productos.csv", 0, "a", $"{archivos.calcularID("productos.csv")};{idProve};{idCliente};{idRepartidor};{archivos.calcularID("paquetes.csv")};{descripcionPorductoBOX.Text};{cantidadBOX.Text};{precioProductoBOX.Text};{costoBOX.Text}");
                MessageBox.Show("producto agregado");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("error al convertir datos numericos. verifique campos de entrada\n" + ex);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Cuenta no encontrada. Verifique que las cuentas existan.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message);
            }
        }

        private void agregarEnvioBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paquete = new Paquete();
                int idProve = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 0, cuentaProveBOX.Text));
                string contraProve = archivos.Buscar_archivo("cuentas.csv", 1, 2, cuentaProveBOX.Text);
                int tipoProve = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 3, cuentaProveBOX.Text));
                Proveedor proveedor = new Proveedor(idProve, cuentaProveBOX.Text, contraProve, tipoProve);

                int idCliente = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 0, cuentaClieBOX.Text));
                string contraClie = archivos.Buscar_archivo("cuentas.csv", 1, 2, cuentaClieBOX.Text);
                int tipoClie = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 3, cuentaClieBOX.Text));
                Cliente cliente = new Cliente(idCliente, cuentaClieBOX.Text, contraClie, tipoClie);

                int idRepartidor = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 0, cuentaRepartidorBOX.Text));
                string contraRepartidor = archivos.Buscar_archivo("cuentas.csv", 1, 2, cuentaRepartidorBOX.Text);
                int tipoRepartidor = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 1, 3, cuentaRepartidorBOX.Text));
                Repartidor repartidor = new Repartidor(idRepartidor, cuentaRepartidorBOX.Text, contraRepartidor, tipoRepartidor);

                paquete.ID = archivos.calcularID("paquetes.csv");
                string patenteMovil = patenteBOX.Text;
                paquete.Destino = lugarDestinoBOX.Text;
                paquete.Proveedor = proveedor;
                paquete.Cliente = cliente;
                paquete.Repartidor = repartidor;
                paquete.ListaProductos = listaProductosTemporal;
                paquete.Movil = new Movil(patenteMovil);
                paquete.Movil.Patente = patenteBOX.Text;
                paquete.Salida = lugarSalidaBOX.Text;
                paquete.FechaSalida = fechaSalidaDTP.Value;
                paquete.Descripcion = descripcionBOX.Text;
                paquete.Costo = Convert.ToInt32(costoBOX.Text);
                paquete.Salida = lugarSalidaBOX.Text;
                paquete.Destino = lugarDestinoBOX.Text;
                paquete.Entregado = "no";

                archivos.Agregar_archivo("paquetes.csv", 0, "a", $"{paquete.ID};{descripcionBOX.Text};{idCliente};{idRepartidor};{idProve};" +
                    $"{paquete.FechaSalida.ToString()};{paquete.FechaDestino.ToString()};{paquete.Movil.Patente};{paquete.Costo};" +
                    $"{archivos.obtenerIDproductosPorPaquete("productos.csv", archivos.calcularID("paquetes.csv"))};{lugarSalidaBOX.Text};{lugarDestinoBOX.Text};{paquete.Entregado}");

                listaPaquetes.Add(paquete);
                listaParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
                MessageBox.Show($"paquete agregado, id del paquete: {paquete.ID}");
                listaProductosTemporal.Clear();
                paquetesDGV.DataSource = listaParaMostrar;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("error al convertir datos numericos. verifique campos de entrada\n" + ex);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Cuenta no encontrada. Verifique que las cuentas existan.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void eliminarProductoBTN_Click(object sender, EventArgs e)
        {
            Producto productoEncontrado = listaProductosTemporal.FirstOrDefault(p => p.Nombre == productosBOX.Text);
            listaProductosTemporal.Remove(productoEncontrado);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productosBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }

        
}
