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
    public partial class Form_Proveedor : Form
    {
        public Proveedor proveedor;
        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<PaqueteParaMostrar> listaPaquetesParaMostrar = new BindingList<PaqueteParaMostrar>();
        public Form_Proveedor(int id, string cuenta, string contra, int tipo)
        {
            InitializeComponent();
            proveedor = new Proveedor(id, cuenta, contra, tipo);
        }

        private void Form_Proveedor_Load(object sender, EventArgs e)
        {
            Paquete.agregarPaquetesALista(listaPaquetes);
            listaPaquetes = Usuario.ObtenerPaquetesPorUsuario(listaPaquetes, proveedor.ID_Usuario);
            listaPaquetesParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
        }

        private void paquetesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            paquetesDGV.DataSource = listaPaquetesParaMostrar;
        }
    }
}
