using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.ComponentModel;

namespace WindowsFormsApp
{
    public partial class Form_Cliente : Form
    {
        public Cliente cliente;
        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<PaqueteParaMostrar> listaPaquetesParaMostrar = new BindingList<PaqueteParaMostrar>();

        public Form_Cliente(int id, string cuenta, string contra, int tipo)
        {
            InitializeComponent();
            cliente = new Cliente(id, cuenta, contra, tipo);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
        //    string paquete = Interaction.InputBox("nombre del paquete");
        //    string fecha = Interaction.InputBox("fecha");

        //      cliente.PedirPaquete();
        }

        private void Form_Cliente_Load(object sender, System.EventArgs e)
        {
             Paquete.agregarPaquetesALista(listaPaquetes);
            listaPaquetes = Usuario.ObtenerPaquetesPorUsuario(listaPaquetes, cliente.ID_Usuario);
            listaPaquetesParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void paquetesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            paquetesDGV.DataSource = listaPaquetesParaMostrar;
        }
    }
}
