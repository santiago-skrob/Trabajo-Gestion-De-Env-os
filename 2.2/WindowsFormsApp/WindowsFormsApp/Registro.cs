using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Registro : Form
    {
        Archivos archivos = new Archivos();
        public Registro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = this.textBox4.Text;
            string contra = this.textBox3.Text;
            string contra2 = this.textBox5.Text;

            if(usuario == "" || contra == "" || contra2 == "")
            {
                label1.Visible = true;
                label1.Text = "Los campos no pueden estar vacios";
            }
            else
            {
                int registrado = archivos.Registarse(usuario, contra, contra2);
                switch (registrado)
                {
                    case 1:
                        {
                            label1.Visible = true;
                            label1.Text = "Usuario ya existente";
                            break;
                        }
                    case 2:
                        {
                            label1.Visible = true;
                            label1.Text = "Las contraseñas no coinciden";
                            break;
                        }
                    case 3:
                        {
                            label1.Visible = false;
                            MessageBox.Show("Usuario registado con exito");
                            Login login = new Login();
                            login.MdiParent = this.MdiParent;
                            login.Show();
                            this.Close();
                            break;
                        }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this.MdiParent;
            login.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}