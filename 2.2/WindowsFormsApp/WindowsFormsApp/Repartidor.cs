using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp
{
    public class Repartidor : Usuario
    {
        public Repartidor(int id, string cuenta, string contra, int tipo) : base(id, cuenta, contra, tipo)
        {
            this.ID_Usuario = id;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Tipo = tipo;
        }
        public Repartidor(int id)
        {
            this.ID_Usuario = id;
        }
        public Repartidor()
        {
            
        }
     
    }
}