using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp
{
    public class Proveedor : Usuario
    {
        public Proveedor(int id, string cuenta, string contra, int tipo) : base(id, cuenta, contra, tipo)
        {
            this.ID_Usuario = id;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Tipo = tipo;        
        }

        public Proveedor (int id)
        {
            this.ID_Usuario = id;
        }
        public Proveedor()
        {
          
        }

        private List<Producto> _lista_productos;

        public List<Producto> ListaProductos
        {
            get { return _lista_productos; }
            set { _lista_productos = value; }
        }


  
    }
}