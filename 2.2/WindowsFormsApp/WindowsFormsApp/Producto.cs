using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp
{
    public class Producto : IcalculoIds<Producto>
    {

		public Producto(string nombre, string descripcion, int cantidad) {
			_nombre = nombre;
			_descripcion = descripcion;
			_stock = cantidad;
		}
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /*private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}*/

        private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

		/*private int _precio;

		public int Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}*/

		private int _stock;

		public int Stock
		{
			get { return _stock; }
			set { _stock = value; }
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
    }
}