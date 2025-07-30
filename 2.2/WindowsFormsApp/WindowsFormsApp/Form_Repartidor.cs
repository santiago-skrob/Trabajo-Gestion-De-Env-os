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
    public partial class Form_Repartidor : Form
    {
        public Repartidor repartidor;
        BindingList<Paquete> listaPaquetes = new BindingList<Paquete>();
        BindingList<PaqueteParaMostrar> listaPaquetesParaMostrar = new BindingList<PaqueteParaMostrar>();
        public Form_Repartidor(int id, string cuenta, string contra, int tipo)
        {
            InitializeComponent();
            repartidor = new Repartidor(id, cuenta, contra, tipo);
        }

        private void Form_Repartidor_Load(object sender, EventArgs e)
        {
            Paquete.agregarPaquetesALista(listaPaquetes);
            listaPaquetes = Usuario.ObtenerPaquetesPorUsuario(listaPaquetes, repartidor.ID_Usuario);
            listaPaquetesParaMostrar = PaqueteParaMostrar.ConvertirListaParaMostrar(listaPaquetes);
            cuentaLBL.Text = repartidor.Cuenta;
        }

        private void paquetesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
