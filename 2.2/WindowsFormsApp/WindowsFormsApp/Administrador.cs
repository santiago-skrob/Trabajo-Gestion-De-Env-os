using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Administrador : Usuario
    {
        Archivos archivos = new Archivos();

        public Administrador(int id, string cuenta, string contra, int tipo):base(id, cuenta, contra, tipo)
        {
            this.ID_Usuario = id;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Tipo = tipo;
        }

        public void ModificarUsuario()
        {
            throw new System.NotImplementedException();
        }

        public void EliminarUsuario()
        {
            throw new System.NotImplementedException();
        }

       /* public void ConfirmarPaquete()
        {
            throw new System.NotImplementedException();
        }*/

        public List<Usuario> CantidadUsuarios(Usuario lista)
        {
            int contador = 0;

            var cuentas = lista.ListaUsuarios;
            foreach (var c in cuentas)
            {
                contador++;
                int id = contador;
                string cuenta = archivos.Buscar_archivo("cuentas.csv", 0, 1, id.ToString());
                string contra = archivos.Buscar_archivo("cuentas.csv", 0, 2, id.ToString());
                int tipo = Convert.ToInt32(archivos.Buscar_archivo("cuentas.csv", 0, 3, id.ToString()));
                cuentas.Add(c);
            }
            return cuentas;
        }

        public int ContarUsuarios()
        {
            int contador = archivos.Contar_archivo("cuentas.csv");
            return contador;
        }
    }
}