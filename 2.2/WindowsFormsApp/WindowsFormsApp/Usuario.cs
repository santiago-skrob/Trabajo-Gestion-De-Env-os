using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System;

namespace WindowsFormsApp
{
    public abstract class Usuario : IcalculoIds <Usuario>, IComparable<Usuario>
    {
        public int CompareTo(Usuario usuario)
        {
            if (usuario == null) return 1;
            return this.ID_Usuario.CompareTo(usuario.ID_Usuario);
        }
        protected Usuario() { }
        protected Usuario(int id, string cuenta, string contra, int tipo)
        {
            this.ID_Usuario = id;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Tipo = tipo;
        }

        private List<Usuario> _lista_usuarios;

        public List<Usuario> ListaUsuarios
        {
            get { return _lista_usuarios; }
            set { _lista_usuarios = value; }
        }

        private int _id_usuario;

        public int ID_Usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private string _cuenta;

        public string Cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }

        private string _contra;

        public string Contra
        {
            get { return _contra; }
            set { _contra = value; }
        }

        private int _tipo;

        public int Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public int calcularID(string ruta)
        {
            int id = -1;
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string linea = "";
            string[] vector = new string[0];
            linea = sr.ReadLine();
            linea = sr.ReadLine();
            while (linea != null)
            {
                vector = linea.Split(';');
                linea = sr.ReadLine();
            }
            if (vector.Length > 0 && int.TryParse(vector[0], out int ultimoID))
            {
                id = ultimoID + 1;
            }
            else
            {
                id = 1; // si no hay datos validos, arranca en 1
            }
            sr.Close();
            fs.Close();
            return id;
        }


        public static T BuscarUsuarioEnLista<T> (BindingList<T> listaRecibida,int id)
            where T : Usuario
        {
            foreach(var p in listaRecibida)
            {
                if(p.ID_Usuario == id)
                {
                    return p;
                }
            }
            return null ;
        }

        public static BindingList<Paquete> ObtenerPaquetesPorUsuario(BindingList<Paquete> listaPaquetesRecibida, int idUsuario )
        {
            BindingList<Paquete> listaPaquetesUsuario = new BindingList<Paquete>();
            foreach (var paq in listaPaquetesRecibida)
            {
                if (paq.Cliente.ID_Usuario == idUsuario)
                {
                    listaPaquetesUsuario.Add(paq);
                }
                if (paq.Repartidor.ID_Usuario == idUsuario)
                {
                    listaPaquetesUsuario.Add(paq);
                }
                if (paq.Proveedor.ID_Usuario == idUsuario)
                {
                    listaPaquetesUsuario.Add(paq);
                }
            }
            return listaPaquetesUsuario;
        }
    }
}
