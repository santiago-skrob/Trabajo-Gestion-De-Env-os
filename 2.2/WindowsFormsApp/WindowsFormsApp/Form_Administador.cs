using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp
{
    public partial class Form_Administador : Form
    {
        public bool edicion = false;

        public Usuario usuario;

        public Administrador administrador;
        public Archivos archivo = new Archivos();
        public Form_Administador(int id, string cuenta, string contra, int tipo)
        {
            InitializeComponent();
            administrador = new Administrador(id, cuenta, contra, tipo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void Form_Administador_Load(object sender, EventArgs e)
        {
            actualizar();
            //List <Usuario> lista = usuario.ListaUsuarios;
        }

        private void actualizar()
        {
            dataGridView1.Rows.Clear();

            int total = administrador.ContarUsuarios();
            int contador = 0;
            string id;
            string cuenta;
            string contra;
            string tipo;
            string activo;

            while (contador <= total)
            {
                contador = contador + 1;
                id = contador.ToString();
                cuenta = archivo.Buscar_archivo("cuentas.csv", 0, 1, id);
                contra = archivo.Buscar_archivo("cuentas.csv", 0, 2, id);
                tipo = archivo.Buscar_archivo("cuentas.csv", 0, 3, id);
                activo = archivo.Buscar_archivo("cuentas.csv", 0, 4, id);

                if (activo == "1")
                {
                    dataGridView1.Rows.Add(id, cuenta, contra, tipo);
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (edicion == true)
            {
                int columna = e.ColumnIndex;
                int fila = e.RowIndex;

                string encabezado = dataGridView1.Columns[columna].HeaderText;
                string id = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                
                if(columna != 0)
                {
                    string texto = Interaction.InputBox("Editando: " + encabezado + " de id: " + id);
                    if (texto != "")
                    {
                        bool correcto = archivo.Editar_archivo("cuentas.csv", fila, columna, texto);
                        //MessageBox.Show(correcto.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Contenido vacio");
                    }
                }
                actualizar();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}