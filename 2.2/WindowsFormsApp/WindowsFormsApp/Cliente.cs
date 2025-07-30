using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.ComponentModel;

namespace WindowsFormsApp
{
    public class Cliente : Usuario 
    {
        public Cliente(int id, string cuenta, string contra, int tipo) : base(id, cuenta, contra, tipo)
        {
            this.ID_Usuario = id;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Tipo = tipo;
        }
        public Cliente(int id) 
        {
            this.ID_Usuario = id;
        }

        public Cliente()
        {
        }


        private List<Paquete> _lista_paquetes;

        public List<Paquete> ListaPaquetes
        {
            get { return _lista_paquetes; }
            set { _lista_paquetes = value; }
        }

  
    }
}